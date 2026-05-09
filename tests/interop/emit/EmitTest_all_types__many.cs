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

public static class EmitTest_all_types__many {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelFive01(ref passed, ref failed, vecDir, outDir);
        TestModelFive02(ref passed, ref failed, vecDir, outDir);
        TestModelFive03(ref passed, ref failed, vecDir, outDir);
        TestModelFive04(ref passed, ref failed, vecDir, outDir);
        TestModelFive05(ref passed, ref failed, vecDir, outDir);
        TestModelFive06(ref passed, ref failed, vecDir, outDir);
        TestModelFive07(ref passed, ref failed, vecDir, outDir);
        TestModelFive08(ref passed, ref failed, vecDir, outDir);
        TestModelFive09(ref passed, ref failed, vecDir, outDir);
        TestModelFive10(ref passed, ref failed, vecDir, outDir);
        TestModelTen01(ref passed, ref failed, vecDir, outDir);
        TestModelTen02(ref passed, ref failed, vecDir, outDir);
        TestModelTen03(ref passed, ref failed, vecDir, outDir);
        TestModelTen04(ref passed, ref failed, vecDir, outDir);
        TestModelTen05(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelFive01(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new MsgPackWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.json");
            var r = new JsonReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new JsonWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.json")!);
            File.WriteAllBytes($"{outDir}/Five01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new JsonWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.gron");
            var r = new GronReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new GronWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.gron")!);
            File.WriteAllBytes($"{outDir}/Five01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 gron: {e.Message}"); }
    }

    static void TestModelFive02(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new MsgPackWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.json");
            var r = new JsonReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new JsonWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.json")!);
            File.WriteAllBytes($"{outDir}/Five02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new JsonWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.gron");
            var r = new GronReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new GronWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.gron")!);
            File.WriteAllBytes($"{outDir}/Five02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 gron: {e.Message}"); }
    }

    static void TestModelFive03(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new MsgPackWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.json");
            var r = new JsonReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new JsonWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.json")!);
            File.WriteAllBytes($"{outDir}/Five03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new JsonWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.gron");
            var r = new GronReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new GronWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.gron")!);
            File.WriteAllBytes($"{outDir}/Five03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 gron: {e.Message}"); }
    }

    static void TestModelFive04(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new MsgPackWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.json");
            var r = new JsonReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new JsonWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.json")!);
            File.WriteAllBytes($"{outDir}/Five04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new JsonWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.gron");
            var r = new GronReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new GronWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.gron")!);
            File.WriteAllBytes($"{outDir}/Five04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 gron: {e.Message}"); }
    }

    static void TestModelFive05(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new MsgPackWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.json");
            var r = new JsonReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new JsonWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.json")!);
            File.WriteAllBytes($"{outDir}/Five05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new JsonWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.gron");
            var r = new GronReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new GronWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.gron")!);
            File.WriteAllBytes($"{outDir}/Five05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 gron: {e.Message}"); }
    }

    static void TestModelFive06(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new MsgPackWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five06.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.json");
            var r = new JsonReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new JsonWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.json")!);
            File.WriteAllBytes($"{outDir}/Five06.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new JsonWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five06.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.gron");
            var r = new GronReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new GronWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.gron")!);
            File.WriteAllBytes($"{outDir}/Five06.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 gron: {e.Message}"); }
    }

    static void TestModelFive07(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new MsgPackWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five07.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.json");
            var r = new JsonReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new JsonWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.json")!);
            File.WriteAllBytes($"{outDir}/Five07.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new JsonWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five07.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.gron");
            var r = new GronReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new GronWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.gron")!);
            File.WriteAllBytes($"{outDir}/Five07.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 gron: {e.Message}"); }
    }

    static void TestModelFive08(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new MsgPackWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five08.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.json");
            var r = new JsonReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new JsonWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.json")!);
            File.WriteAllBytes($"{outDir}/Five08.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new JsonWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five08.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.gron");
            var r = new GronReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new GronWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.gron")!);
            File.WriteAllBytes($"{outDir}/Five08.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 gron: {e.Message}"); }
    }

    static void TestModelFive09(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new MsgPackWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five09.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.json");
            var r = new JsonReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new JsonWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.json")!);
            File.WriteAllBytes($"{outDir}/Five09.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new JsonWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five09.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.gron");
            var r = new GronReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new GronWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.gron")!);
            File.WriteAllBytes($"{outDir}/Five09.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 gron: {e.Message}"); }
    }

    static void TestModelFive10(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new MsgPackWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.json");
            var r = new JsonReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new JsonWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.json")!);
            File.WriteAllBytes($"{outDir}/Five10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new JsonWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.gron");
            var r = new GronReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new GronWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.gron")!);
            File.WriteAllBytes($"{outDir}/Five10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 gron: {e.Message}"); }
    }

    static void TestModelTen01(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.json");
            var r = new JsonReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new JsonWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.json")!);
            File.WriteAllBytes($"{outDir}/Ten01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new JsonWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.gron");
            var r = new GronReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new GronWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.gron")!);
            File.WriteAllBytes($"{outDir}/Ten01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 gron: {e.Message}"); }
    }

    static void TestModelTen02(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.json");
            var r = new JsonReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new JsonWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.json")!);
            File.WriteAllBytes($"{outDir}/Ten02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new JsonWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.gron");
            var r = new GronReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new GronWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.gron")!);
            File.WriteAllBytes($"{outDir}/Ten02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 gron: {e.Message}"); }
    }

    static void TestModelTen03(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.json");
            var r = new JsonReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new JsonWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.json")!);
            File.WriteAllBytes($"{outDir}/Ten03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new JsonWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.gron");
            var r = new GronReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new GronWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.gron")!);
            File.WriteAllBytes($"{outDir}/Ten03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 gron: {e.Message}"); }
    }

    static void TestModelTen04(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.json");
            var r = new JsonReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new JsonWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.json")!);
            File.WriteAllBytes($"{outDir}/Ten04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new JsonWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.gron");
            var r = new GronReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new GronWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.gron")!);
            File.WriteAllBytes($"{outDir}/Ten04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 gron: {e.Message}"); }
    }

    static void TestModelTen05(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.json");
            var r = new JsonReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new JsonWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.json")!);
            File.WriteAllBytes($"{outDir}/Ten05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new JsonWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.gron");
            var r = new GronReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new GronWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.gron")!);
            File.WriteAllBytes($"{outDir}/Ten05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 gron: {e.Message}"); }
    }

}
