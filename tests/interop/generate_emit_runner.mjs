import fs from "fs";
import path from "path";
import { fileURLToPath } from "url";

const __dir = path.dirname(fileURLToPath(import.meta.url));
const VEC_DIR = process.env.VEC_DIR || path.join(__dir, ".tests-cache", "vectors");

const manifestPath = path.join(VEC_DIR, "manifest.json");
const manifest = JSON.parse(fs.readFileSync(manifestPath, "utf-8"));

const models = manifest.testModels || [];
const scalars = manifest.scalars || {};

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

let modelFuncs = '';
let modelCalls = '';
for (const model of models) {
  modelFuncs += `
    void TestModel${model}(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.msgpack");
            var r = new MsgPackReader(data);
            var obj = ${model}Methods.${model}Codec.Decode(r);
            var w = new MsgPackWriter();
            ${model}Methods.${model}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.msgpack")!);
            File.WriteAllBytes($"{outDir}/${model}.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.json");
            var r = new JsonReader(data);
            var obj = ${model}Methods.${model}Codec.Decode(r);
            var w = new JsonWriter();
            ${model}Methods.${model}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.json")!);
            File.WriteAllBytes($"{outDir}/${model}.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.unformatted.json");
            var r = new JsonReader(data);
            var obj = ${model}Methods.${model}Codec.Decode(r);
            var w = new JsonWriter();
            ${model}Methods.${model}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/${model}.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/${model}.gron");
            var r = new GronReader(data);
            var obj = ${model}Methods.${model}Codec.Decode(r);
            var w = new GronWriter();
            ${model}Methods.${model}Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/${model}.gron")!);
            File.WriteAllBytes($"{outDir}/${model}.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ${model} gron: {e.Message}"); }
    }
`;
  modelCalls += `        TestModel${model}(ref passed, ref failed);\n`;
}

const code = `using Specodec;
using Alltypes;
using System;
using System.IO;

var vecDir = Environment.GetEnvironmentVariable("VEC_DIR") ?? throw new Exception("VEC_DIR not set");
var outDir = Environment.GetEnvironmentVariable("OUT_DIR") ?? throw new Exception("OUT_DIR not set");

int passed = 0;
int failed = 0;

${scalarFuncs}
${modelFuncs}

// Scalar tests
${scalarCalls}
// Model tests
${modelCalls}

Console.WriteLine($"emit-csharp: {passed} passed, {failed} failed");
if (failed > 0) Environment.Exit(1);
`;

const outDirPath = path.join(__dir, "emit");
fs.mkdirSync(outDirPath, { recursive: true });
const outFile = path.join(outDirPath, "Program.cs");
fs.writeFileSync(outFile, code);
console.log(`Generated emit/Program.cs with ${models.length} models + ${Object.keys(scalars).length} scalars`);
