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

public static class EmitTest_all_types__enums {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelEnumHolder(ref passed, ref failed, vecDir, outDir);
        TestModelOptEnumHolder(ref passed, ref failed, vecDir, outDir);
        TestModelEnumArrayHolder(ref passed, ref failed, vecDir, outDir);
        TestModelEnumMixedHolder(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelEnumHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = EnumHolderMethods.EnumHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            EnumHolderMethods.EnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/EnumHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumHolder.json");
            var r = new JsonReader(data);
            var obj = EnumHolderMethods.EnumHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumHolderMethods.EnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumHolder.json")!);
            File.WriteAllBytes($"{outDir}/EnumHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = EnumHolderMethods.EnumHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumHolderMethods.EnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EnumHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumHolder.gron");
            var r = new GronReader(data);
            var obj = EnumHolderMethods.EnumHolderCodec.Decode(r);
            var w = new GronWriter();
            EnumHolderMethods.EnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumHolder.gron")!);
            File.WriteAllBytes($"{outDir}/EnumHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumHolder gron: {e.Message}"); }
    }

    static void TestModelOptEnumHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptEnumHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptEnumHolderMethods.OptEnumHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            OptEnumHolderMethods.OptEnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptEnumHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptEnumHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptEnumHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptEnumHolder.json");
            var r = new JsonReader(data);
            var obj = OptEnumHolderMethods.OptEnumHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptEnumHolderMethods.OptEnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptEnumHolder.json")!);
            File.WriteAllBytes($"{outDir}/OptEnumHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptEnumHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptEnumHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptEnumHolderMethods.OptEnumHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptEnumHolderMethods.OptEnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptEnumHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptEnumHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptEnumHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptEnumHolder.gron");
            var r = new GronReader(data);
            var obj = OptEnumHolderMethods.OptEnumHolderCodec.Decode(r);
            var w = new GronWriter();
            OptEnumHolderMethods.OptEnumHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptEnumHolder.gron")!);
            File.WriteAllBytes($"{outDir}/OptEnumHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptEnumHolder gron: {e.Message}"); }
    }

    static void TestModelEnumArrayHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumArrayHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = EnumArrayHolderMethods.EnumArrayHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            EnumArrayHolderMethods.EnumArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumArrayHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/EnumArrayHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumArrayHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumArrayHolder.json");
            var r = new JsonReader(data);
            var obj = EnumArrayHolderMethods.EnumArrayHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumArrayHolderMethods.EnumArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumArrayHolder.json")!);
            File.WriteAllBytes($"{outDir}/EnumArrayHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumArrayHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumArrayHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = EnumArrayHolderMethods.EnumArrayHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumArrayHolderMethods.EnumArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumArrayHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EnumArrayHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumArrayHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumArrayHolder.gron");
            var r = new GronReader(data);
            var obj = EnumArrayHolderMethods.EnumArrayHolderCodec.Decode(r);
            var w = new GronWriter();
            EnumArrayHolderMethods.EnumArrayHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumArrayHolder.gron")!);
            File.WriteAllBytes($"{outDir}/EnumArrayHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumArrayHolder gron: {e.Message}"); }
    }

    static void TestModelEnumMixedHolder(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumMixedHolder.msgpack");
            var r = new MsgPackReader(data);
            var obj = EnumMixedHolderMethods.EnumMixedHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            EnumMixedHolderMethods.EnumMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumMixedHolder.msgpack")!);
            File.WriteAllBytes($"{outDir}/EnumMixedHolder.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumMixedHolder mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumMixedHolder.json");
            var r = new JsonReader(data);
            var obj = EnumMixedHolderMethods.EnumMixedHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumMixedHolderMethods.EnumMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumMixedHolder.json")!);
            File.WriteAllBytes($"{outDir}/EnumMixedHolder.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumMixedHolder json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumMixedHolder.unformatted.json");
            var r = new JsonReader(data);
            var obj = EnumMixedHolderMethods.EnumMixedHolderCodec.Decode(r);
            var w = new JsonWriter();
            EnumMixedHolderMethods.EnumMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumMixedHolder.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EnumMixedHolder.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumMixedHolder unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EnumMixedHolder.gron");
            var r = new GronReader(data);
            var obj = EnumMixedHolderMethods.EnumMixedHolderCodec.Decode(r);
            var w = new GronWriter();
            EnumMixedHolderMethods.EnumMixedHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EnumMixedHolder.gron")!);
            File.WriteAllBytes($"{outDir}/EnumMixedHolder.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EnumMixedHolder gron: {e.Message}"); }
    }

}
