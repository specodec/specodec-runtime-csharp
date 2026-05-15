import { execSync } from 'child_process';
import { readFileSync, existsSync, mkdirSync, rmSync, readdirSync, writeFileSync } from 'fs';
import { join, dirname } from 'path';
import { fileURLToPath } from 'url';

const __dir = dirname(fileURLToPath(import.meta.url));
const CACHE = join(__dir, '.tests-cache');
const EMIT_GEN = join(__dir, 'emit_gen');
const OUT_DIR = join(__dir, 'output');

function run(cmd) {
  console.log('  >', cmd);
  execSync(cmd, { stdio: 'inherit' });
}

console.log('\n=== Step 1: Install dependencies ===');
run(`npm install`);

console.log('\n=== Step 2: Using cached .tests-cache ===');

console.log('\n=== Step 3: Generate vectors ===');
run(`cd ${CACHE} && npm install --silent && node gen_types.mjs`);
const VEC_DIR = join(CACHE, 'vectors');

console.log('\n=== Step 4: Generate emit code ===');
if (existsSync(EMIT_GEN)) rmSync(EMIT_GEN, { recursive: true });
mkdirSync(EMIT_GEN, { recursive: true });
run(`npx tsp compile ${CACHE}/alltypes.tsp --emit=@specodec/typespec-emitter-csharp --option @specodec/typespec-emitter-csharp.emitter-output-dir=${EMIT_GEN}`);
console.log('  Emit OK');

console.log('\n=== Step 5: Generate test runner ===');
const srcDir = join(__dir, 'emit');
if (!existsSync(srcDir)) mkdirSync(srcDir, { recursive: true });
run(`VEC_DIR=${VEC_DIR} node generate_emit_runner.mjs`);

console.log('\n=== Step 6: Fetch runtime from Forgejo NuGet ===');
const emitDir = join(__dir, 'emit');

// Download NuGet package and extract DLL
const nugetUrl = "http://10.199.64.20:3000/api/packages/specodec/nuget/package/specodec/1.0.0/specodec.1.0.0.nupkg";
run(`curl -sfL -o /tmp/specodec.nupkg "${nugetUrl}"`);
run(`unzip -o /tmp/specodec.nupkg -d /tmp/specodec-nuget`);
const emitRuntimeDir = join(emitDir, 'runtime');
if (!existsSync(emitRuntimeDir)) mkdirSync(emitRuntimeDir, { recursive: true });
run(`cp /tmp/specodec-nuget/lib/net9.0/specodec.dll ${emitRuntimeDir}/specodec.dll || cp /tmp/specodec-nuget/lib/net8.0/specodec.dll ${emitRuntimeDir}/specodec.dll || true`);

const alltypesDir = join(emitDir, 'alltypes');
if (existsSync(alltypesDir)) rmSync(alltypesDir, { recursive: true });
run(`cp -r ${EMIT_GEN} ${alltypesDir}`);

const csproj = `<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFrameworks>net8.0;net9.0;net10.0</TargetFrameworks>
    <Nullable>enable</Nullable>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="specodec">
      <HintPath>runtime/specodec.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
`;
writeFileSync(join(emitDir, 'emit.csproj'), csproj);

console.log('\n=== Step 7: Run tests ===');
if (existsSync(OUT_DIR)) rmSync(OUT_DIR, { recursive: true });
mkdirSync(OUT_DIR, { recursive: true });
try { run(`cd ${emitDir} && export VEC_DIR=${VEC_DIR} && export OUT_DIR=${OUT_DIR} && dotnet run --framework net10.0 --project emit.csproj`); } catch (e) { console.log("C# tests completed (some failures expected)"); }

console.log('\n=== Step 8: Compare output ===');
const manifest = JSON.parse(readFileSync(join(VEC_DIR, 'manifest.json'), 'utf-8'));
let match = 0, mismatch = 0;

for (const [name] of Object.entries(manifest.scalars || {})) {
  const expected = join(VEC_DIR, 'scalars', `${name}.mp`);
  const actual = join(OUT_DIR, 'scalars', `${name}.mp`);
  if (!existsSync(actual)) { mismatch++; console.log(`MISSING: ${name}.mp`); continue; }
  if (readFileSync(expected).equals(readFileSync(actual))) match++;
  else { mismatch++; console.log(`MISMATCH: ${name}.mp`); }
}
for (const model of [...(manifest.testModels || []), ...(manifest.testUnions || [])]) {
  for (const [outExt, vecExt] of [['msgpack','msgpack'], ['json','json'], ['unformatted.json','json'], ['gron','gron']]) {
    const expected = join(VEC_DIR, `${model}.${vecExt}`);
    const actual = join(OUT_DIR, `${model}.${outExt}`);
    if (!existsSync(expected)) continue;
    if (!existsSync(actual)) { mismatch++; console.log(`MISSING: ${model}.${outExt}`); continue; }
    if (readFileSync(expected).equals(readFileSync(actual))) match++;
    else { mismatch++; console.log(`MISMATCH: ${model}.${outExt}`); }
  }
}
const total = match + mismatch;
console.log(`${match}/${total} match, ${mismatch} mismatch`);
if (mismatch > 0) process.exit(1);

console.log('\n=== ALL PASSED ===');
