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

public static class EmitTest_all_types__mixed {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelModelArr1(ref passed, ref failed, vecDir, outDir);
        TestModelModelArr2(ref passed, ref failed, vecDir, outDir);
        TestModelModelArr3(ref passed, ref failed, vecDir, outDir);
        TestModelModelArr4(ref passed, ref failed, vecDir, outDir);
        TestModelModelArr5(ref passed, ref failed, vecDir, outDir);
        TestModelMix01(ref passed, ref failed, vecDir, outDir);
        TestModelMix02(ref passed, ref failed, vecDir, outDir);
        TestModelMix03(ref passed, ref failed, vecDir, outDir);
        TestModelMix04(ref passed, ref failed, vecDir, outDir);
        TestModelMix05(ref passed, ref failed, vecDir, outDir);
        TestModelMix06(ref passed, ref failed, vecDir, outDir);
        TestModelMix07(ref passed, ref failed, vecDir, outDir);
        TestModelMix08(ref passed, ref failed, vecDir, outDir);
        TestModelMix09(ref passed, ref failed, vecDir, outDir);
        TestModelMix10(ref passed, ref failed, vecDir, outDir);
        TestModelMix11(ref passed, ref failed, vecDir, outDir);
        TestModelMix12(ref passed, ref failed, vecDir, outDir);
        TestModelMix13(ref passed, ref failed, vecDir, outDir);
        TestModelMix14(ref passed, ref failed, vecDir, outDir);
        TestModelMix15(ref passed, ref failed, vecDir, outDir);
        TestModelAllOpt1(ref passed, ref failed, vecDir, outDir);
        TestModelAllOpt2(ref passed, ref failed, vecDir, outDir);
        TestModelAllOpt3(ref passed, ref failed, vecDir, outDir);
        TestModelAllOpt4(ref passed, ref failed, vecDir, outDir);
        TestModelAllOpt5(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelModelArr1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.json");
            var r = new JsonReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.gron");
            var r = new GronReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new GronWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 gron: {e.Message}"); }
    }

    static void TestModelModelArr2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.json");
            var r = new JsonReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.gron");
            var r = new GronReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new GronWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 gron: {e.Message}"); }
    }

    static void TestModelModelArr3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.json");
            var r = new JsonReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.gron");
            var r = new GronReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new GronWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 gron: {e.Message}"); }
    }

    static void TestModelModelArr4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.json");
            var r = new JsonReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.gron");
            var r = new GronReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new GronWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 gron: {e.Message}"); }
    }

    static void TestModelModelArr5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.json");
            var r = new JsonReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.gron");
            var r = new GronReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new GronWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 gron: {e.Message}"); }
    }

    static void TestModelMix01(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.json");
            var r = new JsonReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new JsonWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.json")!);
            File.WriteAllBytes($"{outDir}/Mix01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new JsonWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.gron");
            var r = new GronReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new GronWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.gron")!);
            File.WriteAllBytes($"{outDir}/Mix01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 gron: {e.Message}"); }
    }

    static void TestModelMix02(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.json");
            var r = new JsonReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new JsonWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.json")!);
            File.WriteAllBytes($"{outDir}/Mix02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new JsonWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.gron");
            var r = new GronReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new GronWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.gron")!);
            File.WriteAllBytes($"{outDir}/Mix02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 gron: {e.Message}"); }
    }

    static void TestModelMix03(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.json");
            var r = new JsonReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new JsonWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.json")!);
            File.WriteAllBytes($"{outDir}/Mix03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new JsonWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.gron");
            var r = new GronReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new GronWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.gron")!);
            File.WriteAllBytes($"{outDir}/Mix03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 gron: {e.Message}"); }
    }

    static void TestModelMix04(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.json");
            var r = new JsonReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new JsonWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.json")!);
            File.WriteAllBytes($"{outDir}/Mix04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new JsonWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.gron");
            var r = new GronReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new GronWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.gron")!);
            File.WriteAllBytes($"{outDir}/Mix04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 gron: {e.Message}"); }
    }

    static void TestModelMix05(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.json");
            var r = new JsonReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new JsonWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.json")!);
            File.WriteAllBytes($"{outDir}/Mix05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new JsonWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.gron");
            var r = new GronReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new GronWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.gron")!);
            File.WriteAllBytes($"{outDir}/Mix05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 gron: {e.Message}"); }
    }

    static void TestModelMix06(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix06.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.json");
            var r = new JsonReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new JsonWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.json")!);
            File.WriteAllBytes($"{outDir}/Mix06.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new JsonWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix06.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.gron");
            var r = new GronReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new GronWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.gron")!);
            File.WriteAllBytes($"{outDir}/Mix06.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 gron: {e.Message}"); }
    }

    static void TestModelMix07(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix07.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.json");
            var r = new JsonReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new JsonWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.json")!);
            File.WriteAllBytes($"{outDir}/Mix07.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new JsonWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix07.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.gron");
            var r = new GronReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new GronWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.gron")!);
            File.WriteAllBytes($"{outDir}/Mix07.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 gron: {e.Message}"); }
    }

    static void TestModelMix08(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix08.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.json");
            var r = new JsonReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new JsonWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.json")!);
            File.WriteAllBytes($"{outDir}/Mix08.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new JsonWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix08.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.gron");
            var r = new GronReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new GronWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.gron")!);
            File.WriteAllBytes($"{outDir}/Mix08.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 gron: {e.Message}"); }
    }

    static void TestModelMix09(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix09.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.json");
            var r = new JsonReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new JsonWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.json")!);
            File.WriteAllBytes($"{outDir}/Mix09.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new JsonWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix09.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.gron");
            var r = new GronReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new GronWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.gron")!);
            File.WriteAllBytes($"{outDir}/Mix09.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 gron: {e.Message}"); }
    }

    static void TestModelMix10(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.json");
            var r = new JsonReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new JsonWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.json")!);
            File.WriteAllBytes($"{outDir}/Mix10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new JsonWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.gron");
            var r = new GronReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new GronWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.gron")!);
            File.WriteAllBytes($"{outDir}/Mix10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 gron: {e.Message}"); }
    }

    static void TestModelMix11(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix11.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.json");
            var r = new JsonReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new JsonWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.json")!);
            File.WriteAllBytes($"{outDir}/Mix11.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new JsonWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix11.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.gron");
            var r = new GronReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new GronWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.gron")!);
            File.WriteAllBytes($"{outDir}/Mix11.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 gron: {e.Message}"); }
    }

    static void TestModelMix12(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix12.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.json");
            var r = new JsonReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new JsonWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.json")!);
            File.WriteAllBytes($"{outDir}/Mix12.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new JsonWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix12.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.gron");
            var r = new GronReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new GronWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.gron")!);
            File.WriteAllBytes($"{outDir}/Mix12.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 gron: {e.Message}"); }
    }

    static void TestModelMix13(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix13.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.json");
            var r = new JsonReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new JsonWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.json")!);
            File.WriteAllBytes($"{outDir}/Mix13.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new JsonWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix13.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.gron");
            var r = new GronReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new GronWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.gron")!);
            File.WriteAllBytes($"{outDir}/Mix13.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 gron: {e.Message}"); }
    }

    static void TestModelMix14(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix14.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.json");
            var r = new JsonReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new JsonWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.json")!);
            File.WriteAllBytes($"{outDir}/Mix14.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new JsonWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix14.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.gron");
            var r = new GronReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new GronWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.gron")!);
            File.WriteAllBytes($"{outDir}/Mix14.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 gron: {e.Message}"); }
    }

    static void TestModelMix15(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix15.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.json");
            var r = new JsonReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new JsonWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.json")!);
            File.WriteAllBytes($"{outDir}/Mix15.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new JsonWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix15.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.gron");
            var r = new GronReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new GronWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.gron")!);
            File.WriteAllBytes($"{outDir}/Mix15.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 gron: {e.Message}"); }
    }

    static void TestModelAllOpt1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.json");
            var r = new JsonReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.gron");
            var r = new GronReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new GronWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 gron: {e.Message}"); }
    }

    static void TestModelAllOpt2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.json");
            var r = new JsonReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.gron");
            var r = new GronReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new GronWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 gron: {e.Message}"); }
    }

    static void TestModelAllOpt3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.json");
            var r = new JsonReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.gron");
            var r = new GronReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new GronWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 gron: {e.Message}"); }
    }

    static void TestModelAllOpt4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.json");
            var r = new JsonReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.gron");
            var r = new GronReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new GronWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 gron: {e.Message}"); }
    }

    static void TestModelAllOpt5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.json");
            var r = new JsonReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.gron");
            var r = new GronReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new GronWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 gron: {e.Message}"); }
    }

}
