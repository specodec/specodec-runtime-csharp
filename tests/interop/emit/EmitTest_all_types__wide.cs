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

public static class EmitTest_all_types__wide {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelWide20(ref passed, ref failed, vecDir, outDir);
        TestModelWide25(ref passed, ref failed, vecDir, outDir);
        TestModelWide30(ref passed, ref failed, vecDir, outDir);
        TestModelWide35(ref passed, ref failed, vecDir, outDir);
        TestModelWide40(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelWide20(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide20.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.json");
            var r = new JsonReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new JsonWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.json")!);
            File.WriteAllBytes($"{outDir}/Wide20.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new JsonWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide20.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.gron");
            var r = new GronReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new GronWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.gron")!);
            File.WriteAllBytes($"{outDir}/Wide20.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 gron: {e.Message}"); }
    }

    static void TestModelWide25(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide25.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.json");
            var r = new JsonReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new JsonWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.json")!);
            File.WriteAllBytes($"{outDir}/Wide25.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new JsonWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide25.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.gron");
            var r = new GronReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new GronWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.gron")!);
            File.WriteAllBytes($"{outDir}/Wide25.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 gron: {e.Message}"); }
    }

    static void TestModelWide30(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide30.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.json");
            var r = new JsonReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new JsonWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.json")!);
            File.WriteAllBytes($"{outDir}/Wide30.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new JsonWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide30.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.gron");
            var r = new GronReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new GronWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.gron")!);
            File.WriteAllBytes($"{outDir}/Wide30.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 gron: {e.Message}"); }
    }

    static void TestModelWide35(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide35.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.json");
            var r = new JsonReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new JsonWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.json")!);
            File.WriteAllBytes($"{outDir}/Wide35.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new JsonWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide35.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.gron");
            var r = new GronReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new GronWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.gron")!);
            File.WriteAllBytes($"{outDir}/Wide35.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 gron: {e.Message}"); }
    }

    static void TestModelWide40(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide40.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.json");
            var r = new JsonReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new JsonWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.json")!);
            File.WriteAllBytes($"{outDir}/Wide40.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new JsonWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide40.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.gron");
            var r = new GronReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new GronWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.gron")!);
            File.WriteAllBytes($"{outDir}/Wide40.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 gron: {e.Message}"); }
    }

}
