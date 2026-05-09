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

public static class EmitTest_all_types__edge {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelEdgeEmpty(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeOneOpt(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeBigNums(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeZeroVals(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeNullable(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeNegZero(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeNullByte(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeBoundary(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeStrLen(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeBytesLen(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeArrEmpty(ref passed, ref failed, vecDir, outDir);
        TestModelEdgeArrBoundary(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelEdgeEmpty(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeEmpty.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeEmptyMethods.EdgeEmptyCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeEmptyMethods.EdgeEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeEmpty.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeEmpty.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeEmpty mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeEmpty.json");
            var r = new JsonReader(data);
            var obj = EdgeEmptyMethods.EdgeEmptyCodec.Decode(r);
            var w = new JsonWriter();
            EdgeEmptyMethods.EdgeEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeEmpty.json")!);
            File.WriteAllBytes($"{outDir}/EdgeEmpty.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeEmpty json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeEmpty.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeEmptyMethods.EdgeEmptyCodec.Decode(r);
            var w = new JsonWriter();
            EdgeEmptyMethods.EdgeEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeEmpty.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeEmpty.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeEmpty unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeEmpty.gron");
            var r = new GronReader(data);
            var obj = EdgeEmptyMethods.EdgeEmptyCodec.Decode(r);
            var w = new GronWriter();
            EdgeEmptyMethods.EdgeEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeEmpty.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeEmpty.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeEmpty gron: {e.Message}"); }
    }

    static void TestModelEdgeOneOpt(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeOneOpt.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeOneOptMethods.EdgeOneOptCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeOneOptMethods.EdgeOneOptCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeOneOpt.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeOneOpt.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeOneOpt mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeOneOpt.json");
            var r = new JsonReader(data);
            var obj = EdgeOneOptMethods.EdgeOneOptCodec.Decode(r);
            var w = new JsonWriter();
            EdgeOneOptMethods.EdgeOneOptCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeOneOpt.json")!);
            File.WriteAllBytes($"{outDir}/EdgeOneOpt.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeOneOpt json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeOneOpt.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeOneOptMethods.EdgeOneOptCodec.Decode(r);
            var w = new JsonWriter();
            EdgeOneOptMethods.EdgeOneOptCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeOneOpt.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeOneOpt.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeOneOpt unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeOneOpt.gron");
            var r = new GronReader(data);
            var obj = EdgeOneOptMethods.EdgeOneOptCodec.Decode(r);
            var w = new GronWriter();
            EdgeOneOptMethods.EdgeOneOptCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeOneOpt.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeOneOpt.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeOneOpt gron: {e.Message}"); }
    }

    static void TestModelEdgeBigNums(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBigNums.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeBigNumsMethods.EdgeBigNumsCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeBigNumsMethods.EdgeBigNumsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBigNums.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeBigNums.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBigNums mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBigNums.json");
            var r = new JsonReader(data);
            var obj = EdgeBigNumsMethods.EdgeBigNumsCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBigNumsMethods.EdgeBigNumsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBigNums.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBigNums.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBigNums json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBigNums.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeBigNumsMethods.EdgeBigNumsCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBigNumsMethods.EdgeBigNumsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBigNums.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBigNums.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBigNums unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBigNums.gron");
            var r = new GronReader(data);
            var obj = EdgeBigNumsMethods.EdgeBigNumsCodec.Decode(r);
            var w = new GronWriter();
            EdgeBigNumsMethods.EdgeBigNumsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBigNums.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeBigNums.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBigNums gron: {e.Message}"); }
    }

    static void TestModelEdgeZeroVals(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeZeroVals.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeZeroValsMethods.EdgeZeroValsCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeZeroValsMethods.EdgeZeroValsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeZeroVals.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeZeroVals.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeZeroVals mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeZeroVals.json");
            var r = new JsonReader(data);
            var obj = EdgeZeroValsMethods.EdgeZeroValsCodec.Decode(r);
            var w = new JsonWriter();
            EdgeZeroValsMethods.EdgeZeroValsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeZeroVals.json")!);
            File.WriteAllBytes($"{outDir}/EdgeZeroVals.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeZeroVals json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeZeroVals.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeZeroValsMethods.EdgeZeroValsCodec.Decode(r);
            var w = new JsonWriter();
            EdgeZeroValsMethods.EdgeZeroValsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeZeroVals.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeZeroVals.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeZeroVals unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeZeroVals.gron");
            var r = new GronReader(data);
            var obj = EdgeZeroValsMethods.EdgeZeroValsCodec.Decode(r);
            var w = new GronWriter();
            EdgeZeroValsMethods.EdgeZeroValsCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeZeroVals.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeZeroVals.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeZeroVals gron: {e.Message}"); }
    }

    static void TestModelEdgeNullable(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullable.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeNullableMethods.EdgeNullableCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeNullableMethods.EdgeNullableCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullable.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeNullable.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullable mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullable.json");
            var r = new JsonReader(data);
            var obj = EdgeNullableMethods.EdgeNullableCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNullableMethods.EdgeNullableCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullable.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNullable.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullable json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullable.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeNullableMethods.EdgeNullableCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNullableMethods.EdgeNullableCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullable.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNullable.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullable unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullable.gron");
            var r = new GronReader(data);
            var obj = EdgeNullableMethods.EdgeNullableCodec.Decode(r);
            var w = new GronWriter();
            EdgeNullableMethods.EdgeNullableCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullable.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeNullable.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullable gron: {e.Message}"); }
    }

    static void TestModelEdgeNegZero(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNegZero.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeNegZeroMethods.EdgeNegZeroCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeNegZeroMethods.EdgeNegZeroCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNegZero.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeNegZero.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNegZero mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNegZero.json");
            var r = new JsonReader(data);
            var obj = EdgeNegZeroMethods.EdgeNegZeroCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNegZeroMethods.EdgeNegZeroCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNegZero.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNegZero.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNegZero json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNegZero.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeNegZeroMethods.EdgeNegZeroCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNegZeroMethods.EdgeNegZeroCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNegZero.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNegZero.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNegZero unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNegZero.gron");
            var r = new GronReader(data);
            var obj = EdgeNegZeroMethods.EdgeNegZeroCodec.Decode(r);
            var w = new GronWriter();
            EdgeNegZeroMethods.EdgeNegZeroCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNegZero.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeNegZero.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNegZero gron: {e.Message}"); }
    }

    static void TestModelEdgeNullByte(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullByte.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeNullByteMethods.EdgeNullByteCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeNullByteMethods.EdgeNullByteCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullByte.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeNullByte.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullByte mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullByte.json");
            var r = new JsonReader(data);
            var obj = EdgeNullByteMethods.EdgeNullByteCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNullByteMethods.EdgeNullByteCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullByte.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNullByte.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullByte json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullByte.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeNullByteMethods.EdgeNullByteCodec.Decode(r);
            var w = new JsonWriter();
            EdgeNullByteMethods.EdgeNullByteCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullByte.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeNullByte.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullByte unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeNullByte.gron");
            var r = new GronReader(data);
            var obj = EdgeNullByteMethods.EdgeNullByteCodec.Decode(r);
            var w = new GronWriter();
            EdgeNullByteMethods.EdgeNullByteCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeNullByte.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeNullByte.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeNullByte gron: {e.Message}"); }
    }

    static void TestModelEdgeBoundary(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBoundary.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeBoundaryMethods.EdgeBoundaryCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeBoundaryMethods.EdgeBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBoundary.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeBoundary.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBoundary mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBoundary.json");
            var r = new JsonReader(data);
            var obj = EdgeBoundaryMethods.EdgeBoundaryCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBoundaryMethods.EdgeBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBoundary.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBoundary.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBoundary json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBoundary.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeBoundaryMethods.EdgeBoundaryCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBoundaryMethods.EdgeBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBoundary.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBoundary.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBoundary unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBoundary.gron");
            var r = new GronReader(data);
            var obj = EdgeBoundaryMethods.EdgeBoundaryCodec.Decode(r);
            var w = new GronWriter();
            EdgeBoundaryMethods.EdgeBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBoundary.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeBoundary.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBoundary gron: {e.Message}"); }
    }

    static void TestModelEdgeStrLen(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeStrLen.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeStrLenMethods.EdgeStrLenCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeStrLenMethods.EdgeStrLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeStrLen.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeStrLen.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeStrLen mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeStrLen.json");
            var r = new JsonReader(data);
            var obj = EdgeStrLenMethods.EdgeStrLenCodec.Decode(r);
            var w = new JsonWriter();
            EdgeStrLenMethods.EdgeStrLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeStrLen.json")!);
            File.WriteAllBytes($"{outDir}/EdgeStrLen.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeStrLen json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeStrLen.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeStrLenMethods.EdgeStrLenCodec.Decode(r);
            var w = new JsonWriter();
            EdgeStrLenMethods.EdgeStrLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeStrLen.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeStrLen.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeStrLen unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeStrLen.gron");
            var r = new GronReader(data);
            var obj = EdgeStrLenMethods.EdgeStrLenCodec.Decode(r);
            var w = new GronWriter();
            EdgeStrLenMethods.EdgeStrLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeStrLen.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeStrLen.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeStrLen gron: {e.Message}"); }
    }

    static void TestModelEdgeBytesLen(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBytesLen.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeBytesLenMethods.EdgeBytesLenCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeBytesLenMethods.EdgeBytesLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBytesLen.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeBytesLen.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBytesLen mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBytesLen.json");
            var r = new JsonReader(data);
            var obj = EdgeBytesLenMethods.EdgeBytesLenCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBytesLenMethods.EdgeBytesLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBytesLen.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBytesLen.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBytesLen json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBytesLen.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeBytesLenMethods.EdgeBytesLenCodec.Decode(r);
            var w = new JsonWriter();
            EdgeBytesLenMethods.EdgeBytesLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBytesLen.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeBytesLen.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBytesLen unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeBytesLen.gron");
            var r = new GronReader(data);
            var obj = EdgeBytesLenMethods.EdgeBytesLenCodec.Decode(r);
            var w = new GronWriter();
            EdgeBytesLenMethods.EdgeBytesLenCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeBytesLen.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeBytesLen.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeBytesLen gron: {e.Message}"); }
    }

    static void TestModelEdgeArrEmpty(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrEmpty.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeArrEmptyMethods.EdgeArrEmptyCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeArrEmptyMethods.EdgeArrEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrEmpty.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeArrEmpty.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrEmpty mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrEmpty.json");
            var r = new JsonReader(data);
            var obj = EdgeArrEmptyMethods.EdgeArrEmptyCodec.Decode(r);
            var w = new JsonWriter();
            EdgeArrEmptyMethods.EdgeArrEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrEmpty.json")!);
            File.WriteAllBytes($"{outDir}/EdgeArrEmpty.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrEmpty json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrEmpty.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeArrEmptyMethods.EdgeArrEmptyCodec.Decode(r);
            var w = new JsonWriter();
            EdgeArrEmptyMethods.EdgeArrEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrEmpty.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeArrEmpty.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrEmpty unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrEmpty.gron");
            var r = new GronReader(data);
            var obj = EdgeArrEmptyMethods.EdgeArrEmptyCodec.Decode(r);
            var w = new GronWriter();
            EdgeArrEmptyMethods.EdgeArrEmptyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrEmpty.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeArrEmpty.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrEmpty gron: {e.Message}"); }
    }

    static void TestModelEdgeArrBoundary(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrBoundary.msgpack");
            var r = new MsgPackReader(data);
            var obj = EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Decode(r);
            var w = new MsgPackWriter();
            EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrBoundary.msgpack")!);
            File.WriteAllBytes($"{outDir}/EdgeArrBoundary.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrBoundary mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrBoundary.json");
            var r = new JsonReader(data);
            var obj = EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Decode(r);
            var w = new JsonWriter();
            EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrBoundary.json")!);
            File.WriteAllBytes($"{outDir}/EdgeArrBoundary.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrBoundary json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrBoundary.unformatted.json");
            var r = new JsonReader(data);
            var obj = EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Decode(r);
            var w = new JsonWriter();
            EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrBoundary.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/EdgeArrBoundary.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrBoundary unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/EdgeArrBoundary.gron");
            var r = new GronReader(data);
            var obj = EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Decode(r);
            var w = new GronWriter();
            EdgeArrBoundaryMethods.EdgeArrBoundaryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/EdgeArrBoundary.gron")!);
            File.WriteAllBytes($"{outDir}/EdgeArrBoundary.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL EdgeArrBoundary gron: {e.Message}"); }
    }

}
