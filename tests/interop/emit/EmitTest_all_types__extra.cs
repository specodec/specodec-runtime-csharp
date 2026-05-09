using AllTypes.Arrays;
using AllTypes.Edge;
using AllTypes.Enums;
using AllTypes.Extra;
using AllTypes.Many;
using AllTypes.Mixed;
using AllTypes.nested.deep;
using AllTypes.nested;
using AllTypes.Nests;
using AllTypes.Opt;
using AllTypes.Pairs;
using AllTypes.Recursive;
using AllTypes.Scalars;
using AllTypes;
using AllTypes.Unions;
using AllTypes.Wide;
using Specodec;
using System;
using System.IO;

public static class EmitTest_all_types__extra {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelOptArr1(ref passed, ref failed, vecDir, outDir);
        TestModelOptArr2(ref passed, ref failed, vecDir, outDir);
        TestModelOptArr3(ref passed, ref failed, vecDir, outDir);
        TestModelOptArr4(ref passed, ref failed, vecDir, outDir);
        TestModelOptArr5(ref passed, ref failed, vecDir, outDir);
        TestModelNestOpt1(ref passed, ref failed, vecDir, outDir);
        TestModelNestOpt2(ref passed, ref failed, vecDir, outDir);
        TestModelNestOpt3(ref passed, ref failed, vecDir, outDir);
        TestModelNestOpt4(ref passed, ref failed, vecDir, outDir);
        TestModelNestOpt5(ref passed, ref failed, vecDir, outDir);
        TestModelNestOptInner1(ref passed, ref failed, vecDir, outDir);
        TestModelNestOptInner2(ref passed, ref failed, vecDir, outDir);
        TestModelNestOptInner3(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest1(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest2(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest3(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest4(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest5(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest6(ref passed, ref failed, vecDir, outDir);
        TestModelDeepNest7(ref passed, ref failed, vecDir, outDir);
        TestModelTimestampEntry(ref passed, ref failed, vecDir, outDir);
        TestModelConfigEntry(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelOptArr1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.json");
            var r = new JsonReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new JsonWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.json")!);
            File.WriteAllBytes($"{outDir}/OptArr1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new JsonWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.gron");
            var r = new GronReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new GronWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 gron: {e.Message}"); }
    }

    static void TestModelOptArr2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.json");
            var r = new JsonReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new JsonWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.json")!);
            File.WriteAllBytes($"{outDir}/OptArr2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new JsonWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.gron");
            var r = new GronReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new GronWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 gron: {e.Message}"); }
    }

    static void TestModelOptArr3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.json");
            var r = new JsonReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new JsonWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.json")!);
            File.WriteAllBytes($"{outDir}/OptArr3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new JsonWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.gron");
            var r = new GronReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new GronWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 gron: {e.Message}"); }
    }

    static void TestModelOptArr4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.json");
            var r = new JsonReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new JsonWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.json")!);
            File.WriteAllBytes($"{outDir}/OptArr4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new JsonWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.gron");
            var r = new GronReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new GronWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 gron: {e.Message}"); }
    }

    static void TestModelOptArr5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.json");
            var r = new JsonReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new JsonWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.json")!);
            File.WriteAllBytes($"{outDir}/OptArr5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new JsonWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.gron");
            var r = new GronReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new GronWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 gron: {e.Message}"); }
    }

    static void TestModelNestOpt1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.json");
            var r = new JsonReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.gron");
            var r = new GronReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new GronWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 gron: {e.Message}"); }
    }

    static void TestModelNestOpt2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.json");
            var r = new JsonReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.gron");
            var r = new GronReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new GronWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 gron: {e.Message}"); }
    }

    static void TestModelNestOpt3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.json");
            var r = new JsonReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.gron");
            var r = new GronReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new GronWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 gron: {e.Message}"); }
    }

    static void TestModelNestOpt4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.json");
            var r = new JsonReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.gron");
            var r = new GronReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new GronWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 gron: {e.Message}"); }
    }

    static void TestModelNestOpt5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.json");
            var r = new JsonReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.gron");
            var r = new GronReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new GronWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 gron: {e.Message}"); }
    }

    static void TestModelNestOptInner1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.json");
            var r = new JsonReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.gron");
            var r = new GronReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 gron: {e.Message}"); }
    }

    static void TestModelNestOptInner2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.json");
            var r = new JsonReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.gron");
            var r = new GronReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 gron: {e.Message}"); }
    }

    static void TestModelNestOptInner3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.json");
            var r = new JsonReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.gron");
            var r = new GronReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 gron: {e.Message}"); }
    }

    static void TestModelDeepNest1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.json");
            var r = new JsonReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.gron");
            var r = new GronReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new GronWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 gron: {e.Message}"); }
    }

    static void TestModelDeepNest2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.json");
            var r = new JsonReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.gron");
            var r = new GronReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new GronWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 gron: {e.Message}"); }
    }

    static void TestModelDeepNest3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.json");
            var r = new JsonReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.gron");
            var r = new GronReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new GronWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 gron: {e.Message}"); }
    }

    static void TestModelDeepNest4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.json");
            var r = new JsonReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.gron");
            var r = new GronReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new GronWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 gron: {e.Message}"); }
    }

    static void TestModelDeepNest5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.json");
            var r = new JsonReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.gron");
            var r = new GronReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new GronWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 gron: {e.Message}"); }
    }

    static void TestModelDeepNest6(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.json");
            var r = new JsonReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.gron");
            var r = new GronReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new GronWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 gron: {e.Message}"); }
    }

    static void TestModelDeepNest7(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.json");
            var r = new JsonReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.gron");
            var r = new GronReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new GronWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 gron: {e.Message}"); }
    }

    static void TestModelTimestampEntry(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.msgpack");
            var r = new MsgPackReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new MsgPackWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.msgpack")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.json");
            var r = new JsonReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new JsonWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.json")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.unformatted.json");
            var r = new JsonReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new JsonWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.gron");
            var r = new GronReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new GronWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.gron")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry gron: {e.Message}"); }
    }

    static void TestModelConfigEntry(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.msgpack");
            var r = new MsgPackReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new MsgPackWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.msgpack")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.json");
            var r = new JsonReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new JsonWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.json")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.unformatted.json");
            var r = new JsonReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new JsonWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.gron");
            var r = new GronReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new GronWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.gron")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry gron: {e.Message}"); }
    }

}
