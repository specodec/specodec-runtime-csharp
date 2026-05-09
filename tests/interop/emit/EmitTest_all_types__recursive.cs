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

public static class EmitTest_all_types__recursive {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelRecList(ref passed, ref failed, vecDir, outDir);
        TestModelRecTree(ref passed, ref failed, vecDir, outDir);
        TestModelRecChain(ref passed, ref failed, vecDir, outDir);
        TestModelRecWrap(ref passed, ref failed, vecDir, outDir);
        TestModelRecWide(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelRecList(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecList.msgpack");
            var r = new MsgPackReader(data);
            var obj = RecListMethods.RecListCodec.Decode(r);
            var w = new MsgPackWriter();
            RecListMethods.RecListCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecList.msgpack")!);
            File.WriteAllBytes($"{outDir}/RecList.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecList mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecList.json");
            var r = new JsonReader(data);
            var obj = RecListMethods.RecListCodec.Decode(r);
            var w = new JsonWriter();
            RecListMethods.RecListCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecList.json")!);
            File.WriteAllBytes($"{outDir}/RecList.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecList json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecList.unformatted.json");
            var r = new JsonReader(data);
            var obj = RecListMethods.RecListCodec.Decode(r);
            var w = new JsonWriter();
            RecListMethods.RecListCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecList.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/RecList.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecList unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecList.gron");
            var r = new GronReader(data);
            var obj = RecListMethods.RecListCodec.Decode(r);
            var w = new GronWriter();
            RecListMethods.RecListCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecList.gron")!);
            File.WriteAllBytes($"{outDir}/RecList.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecList gron: {e.Message}"); }
    }

    static void TestModelRecTree(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecTree.msgpack");
            var r = new MsgPackReader(data);
            var obj = RecTreeMethods.RecTreeCodec.Decode(r);
            var w = new MsgPackWriter();
            RecTreeMethods.RecTreeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecTree.msgpack")!);
            File.WriteAllBytes($"{outDir}/RecTree.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecTree mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecTree.json");
            var r = new JsonReader(data);
            var obj = RecTreeMethods.RecTreeCodec.Decode(r);
            var w = new JsonWriter();
            RecTreeMethods.RecTreeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecTree.json")!);
            File.WriteAllBytes($"{outDir}/RecTree.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecTree json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecTree.unformatted.json");
            var r = new JsonReader(data);
            var obj = RecTreeMethods.RecTreeCodec.Decode(r);
            var w = new JsonWriter();
            RecTreeMethods.RecTreeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecTree.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/RecTree.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecTree unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecTree.gron");
            var r = new GronReader(data);
            var obj = RecTreeMethods.RecTreeCodec.Decode(r);
            var w = new GronWriter();
            RecTreeMethods.RecTreeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecTree.gron")!);
            File.WriteAllBytes($"{outDir}/RecTree.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecTree gron: {e.Message}"); }
    }

    static void TestModelRecChain(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecChain.msgpack");
            var r = new MsgPackReader(data);
            var obj = RecChainMethods.RecChainCodec.Decode(r);
            var w = new MsgPackWriter();
            RecChainMethods.RecChainCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecChain.msgpack")!);
            File.WriteAllBytes($"{outDir}/RecChain.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecChain mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecChain.json");
            var r = new JsonReader(data);
            var obj = RecChainMethods.RecChainCodec.Decode(r);
            var w = new JsonWriter();
            RecChainMethods.RecChainCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecChain.json")!);
            File.WriteAllBytes($"{outDir}/RecChain.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecChain json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecChain.unformatted.json");
            var r = new JsonReader(data);
            var obj = RecChainMethods.RecChainCodec.Decode(r);
            var w = new JsonWriter();
            RecChainMethods.RecChainCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecChain.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/RecChain.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecChain unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecChain.gron");
            var r = new GronReader(data);
            var obj = RecChainMethods.RecChainCodec.Decode(r);
            var w = new GronWriter();
            RecChainMethods.RecChainCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecChain.gron")!);
            File.WriteAllBytes($"{outDir}/RecChain.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecChain gron: {e.Message}"); }
    }

    static void TestModelRecWrap(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWrap.msgpack");
            var r = new MsgPackReader(data);
            var obj = RecWrapMethods.RecWrapCodec.Decode(r);
            var w = new MsgPackWriter();
            RecWrapMethods.RecWrapCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWrap.msgpack")!);
            File.WriteAllBytes($"{outDir}/RecWrap.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWrap mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWrap.json");
            var r = new JsonReader(data);
            var obj = RecWrapMethods.RecWrapCodec.Decode(r);
            var w = new JsonWriter();
            RecWrapMethods.RecWrapCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWrap.json")!);
            File.WriteAllBytes($"{outDir}/RecWrap.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWrap json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWrap.unformatted.json");
            var r = new JsonReader(data);
            var obj = RecWrapMethods.RecWrapCodec.Decode(r);
            var w = new JsonWriter();
            RecWrapMethods.RecWrapCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWrap.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/RecWrap.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWrap unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWrap.gron");
            var r = new GronReader(data);
            var obj = RecWrapMethods.RecWrapCodec.Decode(r);
            var w = new GronWriter();
            RecWrapMethods.RecWrapCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWrap.gron")!);
            File.WriteAllBytes($"{outDir}/RecWrap.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWrap gron: {e.Message}"); }
    }

    static void TestModelRecWide(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWide.msgpack");
            var r = new MsgPackReader(data);
            var obj = RecWideMethods.RecWideCodec.Decode(r);
            var w = new MsgPackWriter();
            RecWideMethods.RecWideCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWide.msgpack")!);
            File.WriteAllBytes($"{outDir}/RecWide.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWide mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWide.json");
            var r = new JsonReader(data);
            var obj = RecWideMethods.RecWideCodec.Decode(r);
            var w = new JsonWriter();
            RecWideMethods.RecWideCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWide.json")!);
            File.WriteAllBytes($"{outDir}/RecWide.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWide json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWide.unformatted.json");
            var r = new JsonReader(data);
            var obj = RecWideMethods.RecWideCodec.Decode(r);
            var w = new JsonWriter();
            RecWideMethods.RecWideCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWide.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/RecWide.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWide unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/RecWide.gron");
            var r = new GronReader(data);
            var obj = RecWideMethods.RecWideCodec.Decode(r);
            var w = new GronWriter();
            RecWideMethods.RecWideCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/RecWide.gron")!);
            File.WriteAllBytes($"{outDir}/RecWide.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL RecWide gron: {e.Message}"); }
    }

}
