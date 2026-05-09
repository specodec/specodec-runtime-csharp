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

public static class EmitTest_all_types__unions {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelUnionFieldHolder(ref passed, ref failed, vecDir, outDir);
        TestModelOptUnionFieldHolder(ref passed, ref failed, vecDir, outDir);
        TestModelUnionArrayHolder(ref passed, ref failed, vecDir, outDir);
        TestModelUnionMixedHolder(ref passed, ref failed, vecDir, outDir);
        TestModelUnionScalarHolder(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelUnionFieldHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionFieldHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = UnionFieldHolderMethods.UnionFieldHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            UnionFieldHolderMethods.UnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionFieldHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/UnionFieldHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionFieldHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionFieldHolder.json");
            var r = new JsonReader(data);
            var obj = UnionFieldHolderMethods.UnionFieldHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionFieldHolderMethods.UnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionFieldHolder.json")!);
            File.WriteAllBytes($"{outDir}/UnionFieldHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionFieldHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionFieldHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = UnionFieldHolderMethods.UnionFieldHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionFieldHolderMethods.UnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionFieldHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/UnionFieldHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionFieldHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionFieldHolder.gron");
            var r = new GronReader(data);
            var obj = UnionFieldHolderMethods.UnionFieldHolderCodec.Decode(r);
            var w = new GronWriter();
            UnionFieldHolderMethods.UnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionFieldHolder.gron")!);
            File.WriteAllBytes($"{outDir}/UnionFieldHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionFieldHolder gron: {e.Message}"); }
    }

    static void TestModelOptUnionFieldHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionFieldHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionFieldHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptUnionFieldHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionFieldHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionFieldHolder.json");
            var r = new JsonReader(data);
            var obj = OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionFieldHolder.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionFieldHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionFieldHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionFieldHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionFieldHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionFieldHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionFieldHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionFieldHolder.gron");
            var r = new GronReader(data);
            var obj = OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Decode(r);
            var w = new GronWriter();
            OptUnionFieldHolderMethods.OptUnionFieldHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionFieldHolder.gron")!);
            File.WriteAllBytes($"{outDir}/OptUnionFieldHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionFieldHolder gron: {e.Message}"); }
    }

    static void TestModelUnionArrayHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionArrayHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = UnionArrayHolderMethods.UnionArrayHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            UnionArrayHolderMethods.UnionArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionArrayHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/UnionArrayHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionArrayHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionArrayHolder.json");
            var r = new JsonReader(data);
            var obj = UnionArrayHolderMethods.UnionArrayHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionArrayHolderMethods.UnionArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionArrayHolder.json")!);
            File.WriteAllBytes($"{outDir}/UnionArrayHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionArrayHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionArrayHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = UnionArrayHolderMethods.UnionArrayHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionArrayHolderMethods.UnionArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionArrayHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/UnionArrayHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionArrayHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionArrayHolder.gron");
            var r = new GronReader(data);
            var obj = UnionArrayHolderMethods.UnionArrayHolderCodec.Decode(r);
            var w = new GronWriter();
            UnionArrayHolderMethods.UnionArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionArrayHolder.gron")!);
            File.WriteAllBytes($"{outDir}/UnionArrayHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionArrayHolder gron: {e.Message}"); }
    }

    static void TestModelUnionMixedHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionMixedHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = UnionMixedHolderMethods.UnionMixedHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            UnionMixedHolderMethods.UnionMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionMixedHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/UnionMixedHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionMixedHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionMixedHolder.json");
            var r = new JsonReader(data);
            var obj = UnionMixedHolderMethods.UnionMixedHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionMixedHolderMethods.UnionMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionMixedHolder.json")!);
            File.WriteAllBytes($"{outDir}/UnionMixedHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionMixedHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionMixedHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = UnionMixedHolderMethods.UnionMixedHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionMixedHolderMethods.UnionMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionMixedHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/UnionMixedHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionMixedHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionMixedHolder.gron");
            var r = new GronReader(data);
            var obj = UnionMixedHolderMethods.UnionMixedHolderCodec.Decode(r);
            var w = new GronWriter();
            UnionMixedHolderMethods.UnionMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionMixedHolder.gron")!);
            File.WriteAllBytes($"{outDir}/UnionMixedHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionMixedHolder gron: {e.Message}"); }
    }

    static void TestModelUnionScalarHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionScalarHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = UnionScalarHolderMethods.UnionScalarHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            UnionScalarHolderMethods.UnionScalarHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionScalarHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/UnionScalarHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionScalarHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionScalarHolder.json");
            var r = new JsonReader(data);
            var obj = UnionScalarHolderMethods.UnionScalarHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionScalarHolderMethods.UnionScalarHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionScalarHolder.json")!);
            File.WriteAllBytes($"{outDir}/UnionScalarHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionScalarHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionScalarHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = UnionScalarHolderMethods.UnionScalarHolderCodec.Decode(r);
            var w = new JsonWriter();
            UnionScalarHolderMethods.UnionScalarHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionScalarHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/UnionScalarHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionScalarHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/UnionScalarHolder.gron");
            var r = new GronReader(data);
            var obj = UnionScalarHolderMethods.UnionScalarHolderCodec.Decode(r);
            var w = new GronWriter();
            UnionScalarHolderMethods.UnionScalarHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/UnionScalarHolder.gron")!);
            File.WriteAllBytes($"{outDir}/UnionScalarHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL UnionScalarHolder gron: {e.Message}"); }
    }

}
