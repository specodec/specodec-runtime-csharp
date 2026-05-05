using AllTypes.nested.deep;
using AllTypes.nested;
using AllTypes;
using Specodec;
using System;
using System.IO;

public static class EmitTest_all_types_nested_deep {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelDeepModel(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelDeepModel(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepModel.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepModelMethods.DeepModelCodec.Decode(r);
            var w = new MsgPackWriter();
            DeepModelMethods.DeepModelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepModel.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepModel.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepModel mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepModel.json");
            var r = new JsonReader(data);
            var obj = DeepModelMethods.DeepModelCodec.Decode(r);
            var w = new JsonWriter();
            DeepModelMethods.DeepModelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepModel.json")!);
            File.WriteAllBytes($"{outDir}/DeepModel.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepModel json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepModel.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepModelMethods.DeepModelCodec.Decode(r);
            var w = new JsonWriter();
            DeepModelMethods.DeepModelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepModel.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepModel.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepModel unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepModel.gron");
            var r = new GronReader(data);
            var obj = DeepModelMethods.DeepModelCodec.Decode(r);
            var w = new GronWriter();
            DeepModelMethods.DeepModelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepModel.gron")!);
            File.WriteAllBytes($"{outDir}/DeepModel.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepModel gron: {e.Message}"); }
    }

}
