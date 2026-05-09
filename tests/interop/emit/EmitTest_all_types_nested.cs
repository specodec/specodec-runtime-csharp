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

public static class EmitTest_all_types_nested {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelNestedSimple(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelNestedSimple(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedSimple.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestedSimpleMethods.NestedSimpleCodec.Decode(r);
            var w = new MsgPackWriter();
            NestedSimpleMethods.NestedSimpleCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedSimple.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestedSimple.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedSimple mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedSimple.json");
            var r = new JsonReader(data);
            var obj = NestedSimpleMethods.NestedSimpleCodec.Decode(r);
            var w = new JsonWriter();
            NestedSimpleMethods.NestedSimpleCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedSimple.json")!);
            File.WriteAllBytes($"{outDir}/NestedSimple.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedSimple json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedSimple.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestedSimpleMethods.NestedSimpleCodec.Decode(r);
            var w = new JsonWriter();
            NestedSimpleMethods.NestedSimpleCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedSimple.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestedSimple.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedSimple unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedSimple.gron");
            var r = new GronReader(data);
            var obj = NestedSimpleMethods.NestedSimpleCodec.Decode(r);
            var w = new GronWriter();
            NestedSimpleMethods.NestedSimpleCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedSimple.gron")!);
            File.WriteAllBytes($"{outDir}/NestedSimple.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedSimple gron: {e.Message}"); }
    }

}
