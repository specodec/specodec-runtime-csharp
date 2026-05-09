import fs from "fs";
import path from "path";
import { fileURLToPath } from "url";

const __dir = path.dirname(fileURLToPath(import.meta.url));
const EMIT_GEN = path.join(__dir, 'emit_gen');
const VEC_DIR = process.env.VEC_DIR || path.join(__dir, ".tests-cache", "vectors");

const manifestPath = path.join(VEC_DIR, "manifest.json");
const manifest = JSON.parse(fs.readFileSync(manifestPath, "utf-8"));

const models = [...(manifest.testModels || []), ...(manifest.testUnions || [])];
const scalars = manifest.scalars || {};
const testUnions = new Set(manifest.testUnions || []);
function isUnionTest(name) { return testUnions.has(name); }
function unionNameOf(testName) { return testName.replace(/_[^_]+$/, ''); }

function toPascalCase(name) {
  let result = name.replace(/\./g, '_').replace(/-/g, '_');
  return result.charAt(0).toUpperCase() + result.slice(1);
}

function getReadMethod(type) {
  const map = { "int32":"ReadInt32","int64":"ReadInt64","uint32":"ReadUint32","uint64":"ReadUint64","float32":"ReadFloat32","float64":"ReadFloat64","string":"ReadString","bytes":"ReadBytes","bool":"ReadBool" };
  return map[type] || "ReadInt32";
}

function getWriteMethod(type) {
  const map = { "int32":"WriteInt32","int64":"WriteInt64","uint32":"WriteUint32","uint64":"WriteUint64","float32":"WriteFloat32","float64":"WriteFloat64","string":"WriteString","bytes":"WriteBytes","bool":"WriteBool" };
  return map[type] || "WriteInt32";
}

function nsSnake(ns) {
  return ns.replace(/\./g, '_').replace(/([A-Z])/g, (m,c,off)=>(off>0?'_':'')+c.toLowerCase());
}

// --- Discover namespaces from emit_gen for using statements ---
const csFiles = fs.readdirSync(EMIT_GEN).filter(f => f.endsWith('.cs'));
const namespaces = csFiles.map(f => {
  const content = fs.readFileSync(path.join(EMIT_GEN, f), 'utf-8');
  const m = content.match(/namespace ([\w.]+);/);
  return m ? m[1] : null;
}).filter(Boolean);
const allUsingStatements = [...new Set([...namespaces, 'Specodec', 'System', 'System.IO'])].map(ns => `using ${ns};`).join('\n');

// --- Scalar test functions ---
let scalarFuncs = '';
let scalarCalls = '';

for (const [name, info] of Object.entries(scalars)) {
  const pascal = toPascalCase(name);
  scalarFuncs += `
    void TestScalar${pascal}(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/${name}.mp");
            var r = new MsgPackReader(data);
            var value = r.${getReadMethod(info.type)}();
            var w = new MsgPackWriter();
            w.${getWriteMethod(info.type)}(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/${name}.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/${name}.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${name} mp: {e.Message}"); }
    }
`;
  scalarCalls += `        TestScalar${pascal}(ref passed, ref failed);\n`;
}

// --- Group models by namespace ---
const modelNamespaces = manifest.modelNamespaces || {};
const nsGroups = {};
for (const model of models) {
  const ns = modelNamespaces[model] || "AllTypes";
  if (!nsGroups[ns]) nsGroups[ns] = [];
  nsGroups[ns].push(model);
}

// --- Generate test file per namespace ---
const outDirPath = path.join(__dir, "emit");
fs.mkdirSync(outDirPath, { recursive: true });

const nsOrder = Object.keys(nsGroups);

for (const [ns, nsModels] of Object.entries(nsGroups)) {
  const sn = nsSnake(ns);

  let modelFuncs = '';
  let modelCalls = '';

  for (const model of nsModels) {
    const codecName = isUnionTest(model) ? unionNameOf(model) : model;
    modelFuncs += `
    static void TestModel${model}(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.msgpack");
            var r = new MsgPackReader(data);
            var obj = ${codecName}Methods.${codecName}Codec.Decode(r);
            var w = new MsgPackWriter();
            ${codecName}Methods.${codecName}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.msgpack")!);
            File.WriteAllBytes($"{outDir}/${model}.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.json");
            var r = new JsonReader(data);
            var obj = ${codecName}Methods.${codecName}Codec.Decode(r);
            var w = new JsonWriter();
            ${codecName}Methods.${codecName}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.json")!);
            File.WriteAllBytes($"{outDir}/${model}.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.unformatted.json");
            var r = new JsonReader(data);
            var obj = ${codecName}Methods.${codecName}Codec.Decode(r);
            var w = new JsonWriter();
            ${codecName}Methods.${codecName}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/${model}.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.gron");
            var r = new GronReader(data);
            var obj = ${codecName}Methods.${codecName}Codec.Decode(r);
            var w = new GronWriter();
            ${codecName}Methods.${codecName}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.gron")!);
            File.WriteAllBytes($"{outDir}/${model}.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} gron: {e.Message}"); }
    }
`;
    modelCalls += `        TestModel${model}(ref passed, ref failed, vecDir, outDir);\n`;
  }

  const testCode = `${allUsingStatements}

public static class EmitTest_${sn} {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
${modelCalls}    }
${modelFuncs}
}
`;
  fs.writeFileSync(path.join(outDirPath, `EmitTest_${sn}.cs`), testCode);
  console.log(`  EmitTest_${sn}.cs: ${nsModels.length} models`);
}

// --- Generate main Program.cs ---
let mainCalls = '';
for (const ns of nsOrder) {
  const sn = nsSnake(ns);
  mainCalls += `        EmitTest_${sn}.Run(ref passed, ref failed, vecDir, outDir);\n`;
}

const mainCode = `${allUsingStatements}

var vecDir = Environment.GetEnvironmentVariable("VEC_DIR") ?? throw new Exception("VEC_DIR not set");
var outDir = Environment.GetEnvironmentVariable("OUT_DIR") ?? throw new Exception("OUT_DIR not set");

int passed = 0;
int failed = 0;

${scalarFuncs}

// Scalar tests
${scalarCalls}
// Model tests (by namespace)
${mainCalls}

Console.WriteLine($"emit-csharp: {passed} passed, {failed} failed");
if (failed > 0) Environment.Exit(1);
`;

fs.writeFileSync(path.join(outDirPath, "Program.cs"), mainCode);
console.log(`Generated emit/Program.cs + ${nsOrder.length} namespace test files (${models.length} models + ${Object.keys(scalars).length} scalars)`);
