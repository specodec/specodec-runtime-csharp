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

public static class EmitTest_all_types__pairs {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelPairString(ref passed, ref failed, vecDir, outDir);
        TestModelPairBoolean(ref passed, ref failed, vecDir, outDir);
        TestModelPairInt8(ref passed, ref failed, vecDir, outDir);
        TestModelPairInt16(ref passed, ref failed, vecDir, outDir);
        TestModelPairInt32(ref passed, ref failed, vecDir, outDir);
        TestModelPairInt64(ref passed, ref failed, vecDir, outDir);
        TestModelPairUint8(ref passed, ref failed, vecDir, outDir);
        TestModelPairUint16(ref passed, ref failed, vecDir, outDir);
        TestModelPairUint32(ref passed, ref failed, vecDir, outDir);
        TestModelPairUint64(ref passed, ref failed, vecDir, outDir);
        TestModelPairFloat32(ref passed, ref failed, vecDir, outDir);
        TestModelPairFloat64(ref passed, ref failed, vecDir, outDir);
        TestModelPairBytes(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringInt32(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringBoolean(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringFloat64(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringBytes(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt32Boolean(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt32Float64(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt32Int64(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt32Uint32(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt64Uint64(ref passed, ref failed, vecDir, outDir);
        TestModelDualFloat32Float64(ref passed, ref failed, vecDir, outDir);
        TestModelDualFloat64Boolean(ref passed, ref failed, vecDir, outDir);
        TestModelDualFloat64Bytes(ref passed, ref failed, vecDir, outDir);
        TestModelDualUint32Uint64(ref passed, ref failed, vecDir, outDir);
        TestModelDualBooleanBytes(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt8Uint8(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt16Uint16(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringInt64(ref passed, ref failed, vecDir, outDir);
        TestModelDualStringUint64(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt32Bytes(ref passed, ref failed, vecDir, outDir);
        TestModelDualFloat64Int32(ref passed, ref failed, vecDir, outDir);
        TestModelDualBooleanInt32(ref passed, ref failed, vecDir, outDir);
        TestModelDualBytesInt64(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt8Float32(ref passed, ref failed, vecDir, outDir);
        TestModelDualUint8Int16(ref passed, ref failed, vecDir, outDir);
        TestModelDualInt64Float64(ref passed, ref failed, vecDir, outDir);
        TestModelDualUint64String(ref passed, ref failed, vecDir, outDir);
        TestModelTriple01(ref passed, ref failed, vecDir, outDir);
        TestModelTriple02(ref passed, ref failed, vecDir, outDir);
        TestModelTriple03(ref passed, ref failed, vecDir, outDir);
        TestModelTriple04(ref passed, ref failed, vecDir, outDir);
        TestModelTriple05(ref passed, ref failed, vecDir, outDir);
        TestModelTriple06(ref passed, ref failed, vecDir, outDir);
        TestModelTriple07(ref passed, ref failed, vecDir, outDir);
        TestModelTriple08(ref passed, ref failed, vecDir, outDir);
        TestModelTriple09(ref passed, ref failed, vecDir, outDir);
        TestModelTriple10(ref passed, ref failed, vecDir, outDir);
        TestModelTriple11(ref passed, ref failed, vecDir, outDir);
        TestModelTriple12(ref passed, ref failed, vecDir, outDir);
        TestModelTriple13(ref passed, ref failed, vecDir, outDir);
        TestModelTriple14(ref passed, ref failed, vecDir, outDir);
        TestModelTriple15(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelPairString(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairString.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairStringMethods.PairStringCodec.Decode(r);
            var w = new MsgPackWriter();
            PairStringMethods.PairStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairString.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairString.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairString mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairString.json");
            var r = new JsonReader(data);
            var obj = PairStringMethods.PairStringCodec.Decode(r);
            var w = new JsonWriter();
            PairStringMethods.PairStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairString.json")!);
            File.WriteAllBytes($"{outDir}/PairString.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairString json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairString.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairStringMethods.PairStringCodec.Decode(r);
            var w = new JsonWriter();
            PairStringMethods.PairStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairString.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairString.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairString unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairString.gron");
            var r = new GronReader(data);
            var obj = PairStringMethods.PairStringCodec.Decode(r);
            var w = new GronWriter();
            PairStringMethods.PairStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairString.gron")!);
            File.WriteAllBytes($"{outDir}/PairString.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairString gron: {e.Message}"); }
    }

    static void TestModelPairBoolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBoolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairBooleanMethods.PairBooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            PairBooleanMethods.PairBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBoolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairBoolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBoolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBoolean.json");
            var r = new JsonReader(data);
            var obj = PairBooleanMethods.PairBooleanCodec.Decode(r);
            var w = new JsonWriter();
            PairBooleanMethods.PairBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBoolean.json")!);
            File.WriteAllBytes($"{outDir}/PairBoolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBoolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBoolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairBooleanMethods.PairBooleanCodec.Decode(r);
            var w = new JsonWriter();
            PairBooleanMethods.PairBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBoolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairBoolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBoolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBoolean.gron");
            var r = new GronReader(data);
            var obj = PairBooleanMethods.PairBooleanCodec.Decode(r);
            var w = new GronWriter();
            PairBooleanMethods.PairBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBoolean.gron")!);
            File.WriteAllBytes($"{outDir}/PairBoolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBoolean gron: {e.Message}"); }
    }

    static void TestModelPairInt8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt8.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairInt8Methods.PairInt8Codec.Decode(r);
            var w = new MsgPackWriter();
            PairInt8Methods.PairInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt8.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairInt8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt8.json");
            var r = new JsonReader(data);
            var obj = PairInt8Methods.PairInt8Codec.Decode(r);
            var w = new JsonWriter();
            PairInt8Methods.PairInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt8.json")!);
            File.WriteAllBytes($"{outDir}/PairInt8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt8.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairInt8Methods.PairInt8Codec.Decode(r);
            var w = new JsonWriter();
            PairInt8Methods.PairInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairInt8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt8.gron");
            var r = new GronReader(data);
            var obj = PairInt8Methods.PairInt8Codec.Decode(r);
            var w = new GronWriter();
            PairInt8Methods.PairInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt8.gron")!);
            File.WriteAllBytes($"{outDir}/PairInt8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt8 gron: {e.Message}"); }
    }

    static void TestModelPairInt16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt16.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairInt16Methods.PairInt16Codec.Decode(r);
            var w = new MsgPackWriter();
            PairInt16Methods.PairInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt16.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairInt16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt16.json");
            var r = new JsonReader(data);
            var obj = PairInt16Methods.PairInt16Codec.Decode(r);
            var w = new JsonWriter();
            PairInt16Methods.PairInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt16.json")!);
            File.WriteAllBytes($"{outDir}/PairInt16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt16.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairInt16Methods.PairInt16Codec.Decode(r);
            var w = new JsonWriter();
            PairInt16Methods.PairInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairInt16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt16.gron");
            var r = new GronReader(data);
            var obj = PairInt16Methods.PairInt16Codec.Decode(r);
            var w = new GronWriter();
            PairInt16Methods.PairInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt16.gron")!);
            File.WriteAllBytes($"{outDir}/PairInt16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt16 gron: {e.Message}"); }
    }

    static void TestModelPairInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairInt32Methods.PairInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            PairInt32Methods.PairInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt32.json");
            var r = new JsonReader(data);
            var obj = PairInt32Methods.PairInt32Codec.Decode(r);
            var w = new JsonWriter();
            PairInt32Methods.PairInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt32.json")!);
            File.WriteAllBytes($"{outDir}/PairInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairInt32Methods.PairInt32Codec.Decode(r);
            var w = new JsonWriter();
            PairInt32Methods.PairInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt32.gron");
            var r = new GronReader(data);
            var obj = PairInt32Methods.PairInt32Codec.Decode(r);
            var w = new GronWriter();
            PairInt32Methods.PairInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt32.gron")!);
            File.WriteAllBytes($"{outDir}/PairInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt32 gron: {e.Message}"); }
    }

    static void TestModelPairInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairInt64Methods.PairInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            PairInt64Methods.PairInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt64.json");
            var r = new JsonReader(data);
            var obj = PairInt64Methods.PairInt64Codec.Decode(r);
            var w = new JsonWriter();
            PairInt64Methods.PairInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt64.json")!);
            File.WriteAllBytes($"{outDir}/PairInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairInt64Methods.PairInt64Codec.Decode(r);
            var w = new JsonWriter();
            PairInt64Methods.PairInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairInt64.gron");
            var r = new GronReader(data);
            var obj = PairInt64Methods.PairInt64Codec.Decode(r);
            var w = new GronWriter();
            PairInt64Methods.PairInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairInt64.gron")!);
            File.WriteAllBytes($"{outDir}/PairInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairInt64 gron: {e.Message}"); }
    }

    static void TestModelPairUint8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint8.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairUint8Methods.PairUint8Codec.Decode(r);
            var w = new MsgPackWriter();
            PairUint8Methods.PairUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint8.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairUint8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint8.json");
            var r = new JsonReader(data);
            var obj = PairUint8Methods.PairUint8Codec.Decode(r);
            var w = new JsonWriter();
            PairUint8Methods.PairUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint8.json")!);
            File.WriteAllBytes($"{outDir}/PairUint8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint8.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairUint8Methods.PairUint8Codec.Decode(r);
            var w = new JsonWriter();
            PairUint8Methods.PairUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairUint8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint8.gron");
            var r = new GronReader(data);
            var obj = PairUint8Methods.PairUint8Codec.Decode(r);
            var w = new GronWriter();
            PairUint8Methods.PairUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint8.gron")!);
            File.WriteAllBytes($"{outDir}/PairUint8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint8 gron: {e.Message}"); }
    }

    static void TestModelPairUint16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint16.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairUint16Methods.PairUint16Codec.Decode(r);
            var w = new MsgPackWriter();
            PairUint16Methods.PairUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint16.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairUint16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint16.json");
            var r = new JsonReader(data);
            var obj = PairUint16Methods.PairUint16Codec.Decode(r);
            var w = new JsonWriter();
            PairUint16Methods.PairUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint16.json")!);
            File.WriteAllBytes($"{outDir}/PairUint16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint16.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairUint16Methods.PairUint16Codec.Decode(r);
            var w = new JsonWriter();
            PairUint16Methods.PairUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairUint16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint16.gron");
            var r = new GronReader(data);
            var obj = PairUint16Methods.PairUint16Codec.Decode(r);
            var w = new GronWriter();
            PairUint16Methods.PairUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint16.gron")!);
            File.WriteAllBytes($"{outDir}/PairUint16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint16 gron: {e.Message}"); }
    }

    static void TestModelPairUint32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint32.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairUint32Methods.PairUint32Codec.Decode(r);
            var w = new MsgPackWriter();
            PairUint32Methods.PairUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint32.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairUint32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint32.json");
            var r = new JsonReader(data);
            var obj = PairUint32Methods.PairUint32Codec.Decode(r);
            var w = new JsonWriter();
            PairUint32Methods.PairUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint32.json")!);
            File.WriteAllBytes($"{outDir}/PairUint32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint32.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairUint32Methods.PairUint32Codec.Decode(r);
            var w = new JsonWriter();
            PairUint32Methods.PairUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairUint32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint32.gron");
            var r = new GronReader(data);
            var obj = PairUint32Methods.PairUint32Codec.Decode(r);
            var w = new GronWriter();
            PairUint32Methods.PairUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint32.gron")!);
            File.WriteAllBytes($"{outDir}/PairUint32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint32 gron: {e.Message}"); }
    }

    static void TestModelPairUint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairUint64Methods.PairUint64Codec.Decode(r);
            var w = new MsgPackWriter();
            PairUint64Methods.PairUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairUint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint64.json");
            var r = new JsonReader(data);
            var obj = PairUint64Methods.PairUint64Codec.Decode(r);
            var w = new JsonWriter();
            PairUint64Methods.PairUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint64.json")!);
            File.WriteAllBytes($"{outDir}/PairUint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairUint64Methods.PairUint64Codec.Decode(r);
            var w = new JsonWriter();
            PairUint64Methods.PairUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairUint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairUint64.gron");
            var r = new GronReader(data);
            var obj = PairUint64Methods.PairUint64Codec.Decode(r);
            var w = new GronWriter();
            PairUint64Methods.PairUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairUint64.gron")!);
            File.WriteAllBytes($"{outDir}/PairUint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairUint64 gron: {e.Message}"); }
    }

    static void TestModelPairFloat32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat32.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairFloat32Methods.PairFloat32Codec.Decode(r);
            var w = new MsgPackWriter();
            PairFloat32Methods.PairFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat32.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairFloat32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat32.json");
            var r = new JsonReader(data);
            var obj = PairFloat32Methods.PairFloat32Codec.Decode(r);
            var w = new JsonWriter();
            PairFloat32Methods.PairFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat32.json")!);
            File.WriteAllBytes($"{outDir}/PairFloat32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat32.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairFloat32Methods.PairFloat32Codec.Decode(r);
            var w = new JsonWriter();
            PairFloat32Methods.PairFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairFloat32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat32.gron");
            var r = new GronReader(data);
            var obj = PairFloat32Methods.PairFloat32Codec.Decode(r);
            var w = new GronWriter();
            PairFloat32Methods.PairFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat32.gron")!);
            File.WriteAllBytes($"{outDir}/PairFloat32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat32 gron: {e.Message}"); }
    }

    static void TestModelPairFloat64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat64.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairFloat64Methods.PairFloat64Codec.Decode(r);
            var w = new MsgPackWriter();
            PairFloat64Methods.PairFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat64.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairFloat64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat64.json");
            var r = new JsonReader(data);
            var obj = PairFloat64Methods.PairFloat64Codec.Decode(r);
            var w = new JsonWriter();
            PairFloat64Methods.PairFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat64.json")!);
            File.WriteAllBytes($"{outDir}/PairFloat64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat64.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairFloat64Methods.PairFloat64Codec.Decode(r);
            var w = new JsonWriter();
            PairFloat64Methods.PairFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairFloat64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairFloat64.gron");
            var r = new GronReader(data);
            var obj = PairFloat64Methods.PairFloat64Codec.Decode(r);
            var w = new GronWriter();
            PairFloat64Methods.PairFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairFloat64.gron")!);
            File.WriteAllBytes($"{outDir}/PairFloat64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairFloat64 gron: {e.Message}"); }
    }

    static void TestModelPairBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = PairBytesMethods.PairBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            PairBytesMethods.PairBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/PairBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBytes.json");
            var r = new JsonReader(data);
            var obj = PairBytesMethods.PairBytesCodec.Decode(r);
            var w = new JsonWriter();
            PairBytesMethods.PairBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBytes.json")!);
            File.WriteAllBytes($"{outDir}/PairBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = PairBytesMethods.PairBytesCodec.Decode(r);
            var w = new JsonWriter();
            PairBytesMethods.PairBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/PairBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/PairBytes.gron");
            var r = new GronReader(data);
            var obj = PairBytesMethods.PairBytesCodec.Decode(r);
            var w = new GronWriter();
            PairBytesMethods.PairBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/PairBytes.gron")!);
            File.WriteAllBytes($"{outDir}/PairBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL PairBytes gron: {e.Message}"); }
    }

    static void TestModelDualStringInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringInt32Methods.DualStringInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            DualStringInt32Methods.DualStringInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt32.json");
            var r = new JsonReader(data);
            var obj = DualStringInt32Methods.DualStringInt32Codec.Decode(r);
            var w = new JsonWriter();
            DualStringInt32Methods.DualStringInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt32.json")!);
            File.WriteAllBytes($"{outDir}/DualStringInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringInt32Methods.DualStringInt32Codec.Decode(r);
            var w = new JsonWriter();
            DualStringInt32Methods.DualStringInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt32.gron");
            var r = new GronReader(data);
            var obj = DualStringInt32Methods.DualStringInt32Codec.Decode(r);
            var w = new GronWriter();
            DualStringInt32Methods.DualStringInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt32.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt32 gron: {e.Message}"); }
    }

    static void TestModelDualStringBoolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBoolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringBooleanMethods.DualStringBooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            DualStringBooleanMethods.DualStringBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBoolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringBoolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBoolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBoolean.json");
            var r = new JsonReader(data);
            var obj = DualStringBooleanMethods.DualStringBooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualStringBooleanMethods.DualStringBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBoolean.json")!);
            File.WriteAllBytes($"{outDir}/DualStringBoolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBoolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBoolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringBooleanMethods.DualStringBooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualStringBooleanMethods.DualStringBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBoolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringBoolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBoolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBoolean.gron");
            var r = new GronReader(data);
            var obj = DualStringBooleanMethods.DualStringBooleanCodec.Decode(r);
            var w = new GronWriter();
            DualStringBooleanMethods.DualStringBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBoolean.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringBoolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBoolean gron: {e.Message}"); }
    }

    static void TestModelDualStringFloat64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringFloat64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringFloat64Methods.DualStringFloat64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualStringFloat64Methods.DualStringFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringFloat64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringFloat64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringFloat64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringFloat64.json");
            var r = new JsonReader(data);
            var obj = DualStringFloat64Methods.DualStringFloat64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringFloat64Methods.DualStringFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringFloat64.json")!);
            File.WriteAllBytes($"{outDir}/DualStringFloat64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringFloat64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringFloat64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringFloat64Methods.DualStringFloat64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringFloat64Methods.DualStringFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringFloat64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringFloat64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringFloat64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringFloat64.gron");
            var r = new GronReader(data);
            var obj = DualStringFloat64Methods.DualStringFloat64Codec.Decode(r);
            var w = new GronWriter();
            DualStringFloat64Methods.DualStringFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringFloat64.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringFloat64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringFloat64 gron: {e.Message}"); }
    }

    static void TestModelDualStringBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringBytesMethods.DualStringBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            DualStringBytesMethods.DualStringBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBytes.json");
            var r = new JsonReader(data);
            var obj = DualStringBytesMethods.DualStringBytesCodec.Decode(r);
            var w = new JsonWriter();
            DualStringBytesMethods.DualStringBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBytes.json")!);
            File.WriteAllBytes($"{outDir}/DualStringBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringBytesMethods.DualStringBytesCodec.Decode(r);
            var w = new JsonWriter();
            DualStringBytesMethods.DualStringBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringBytes.gron");
            var r = new GronReader(data);
            var obj = DualStringBytesMethods.DualStringBytesCodec.Decode(r);
            var w = new GronWriter();
            DualStringBytesMethods.DualStringBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringBytes.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringBytes gron: {e.Message}"); }
    }

    static void TestModelDualInt32Boolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Boolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt32BooleanMethods.DualInt32BooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            DualInt32BooleanMethods.DualInt32BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Boolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt32Boolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Boolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Boolean.json");
            var r = new JsonReader(data);
            var obj = DualInt32BooleanMethods.DualInt32BooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualInt32BooleanMethods.DualInt32BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Boolean.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Boolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Boolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Boolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt32BooleanMethods.DualInt32BooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualInt32BooleanMethods.DualInt32BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Boolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Boolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Boolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Boolean.gron");
            var r = new GronReader(data);
            var obj = DualInt32BooleanMethods.DualInt32BooleanCodec.Decode(r);
            var w = new GronWriter();
            DualInt32BooleanMethods.DualInt32BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Boolean.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt32Boolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Boolean gron: {e.Message}"); }
    }

    static void TestModelDualInt32Float64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Float64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt32Float64Methods.DualInt32Float64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt32Float64Methods.DualInt32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Float64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt32Float64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Float64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Float64.json");
            var r = new JsonReader(data);
            var obj = DualInt32Float64Methods.DualInt32Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Float64Methods.DualInt32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Float64.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Float64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Float64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Float64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt32Float64Methods.DualInt32Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Float64Methods.DualInt32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Float64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Float64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Float64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Float64.gron");
            var r = new GronReader(data);
            var obj = DualInt32Float64Methods.DualInt32Float64Codec.Decode(r);
            var w = new GronWriter();
            DualInt32Float64Methods.DualInt32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Float64.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt32Float64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Float64 gron: {e.Message}"); }
    }

    static void TestModelDualInt32Int64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Int64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt32Int64Methods.DualInt32Int64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt32Int64Methods.DualInt32Int64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Int64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt32Int64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Int64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Int64.json");
            var r = new JsonReader(data);
            var obj = DualInt32Int64Methods.DualInt32Int64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Int64Methods.DualInt32Int64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Int64.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Int64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Int64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Int64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt32Int64Methods.DualInt32Int64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Int64Methods.DualInt32Int64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Int64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Int64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Int64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Int64.gron");
            var r = new GronReader(data);
            var obj = DualInt32Int64Methods.DualInt32Int64Codec.Decode(r);
            var w = new GronWriter();
            DualInt32Int64Methods.DualInt32Int64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Int64.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt32Int64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Int64 gron: {e.Message}"); }
    }

    static void TestModelDualInt32Uint32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Uint32.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt32Uint32Methods.DualInt32Uint32Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt32Uint32Methods.DualInt32Uint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Uint32.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt32Uint32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Uint32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Uint32.json");
            var r = new JsonReader(data);
            var obj = DualInt32Uint32Methods.DualInt32Uint32Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Uint32Methods.DualInt32Uint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Uint32.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Uint32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Uint32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Uint32.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt32Uint32Methods.DualInt32Uint32Codec.Decode(r);
            var w = new JsonWriter();
            DualInt32Uint32Methods.DualInt32Uint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Uint32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Uint32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Uint32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Uint32.gron");
            var r = new GronReader(data);
            var obj = DualInt32Uint32Methods.DualInt32Uint32Codec.Decode(r);
            var w = new GronWriter();
            DualInt32Uint32Methods.DualInt32Uint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Uint32.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt32Uint32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Uint32 gron: {e.Message}"); }
    }

    static void TestModelDualInt64Uint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Uint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt64Uint64Methods.DualInt64Uint64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt64Uint64Methods.DualInt64Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Uint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt64Uint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Uint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Uint64.json");
            var r = new JsonReader(data);
            var obj = DualInt64Uint64Methods.DualInt64Uint64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt64Uint64Methods.DualInt64Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Uint64.json")!);
            File.WriteAllBytes($"{outDir}/DualInt64Uint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Uint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Uint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt64Uint64Methods.DualInt64Uint64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt64Uint64Methods.DualInt64Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Uint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt64Uint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Uint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Uint64.gron");
            var r = new GronReader(data);
            var obj = DualInt64Uint64Methods.DualInt64Uint64Codec.Decode(r);
            var w = new GronWriter();
            DualInt64Uint64Methods.DualInt64Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Uint64.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt64Uint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Uint64 gron: {e.Message}"); }
    }

    static void TestModelDualFloat32Float64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat32Float64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualFloat32Float64Methods.DualFloat32Float64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualFloat32Float64Methods.DualFloat32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat32Float64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualFloat32Float64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat32Float64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat32Float64.json");
            var r = new JsonReader(data);
            var obj = DualFloat32Float64Methods.DualFloat32Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualFloat32Float64Methods.DualFloat32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat32Float64.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat32Float64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat32Float64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat32Float64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualFloat32Float64Methods.DualFloat32Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualFloat32Float64Methods.DualFloat32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat32Float64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat32Float64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat32Float64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat32Float64.gron");
            var r = new GronReader(data);
            var obj = DualFloat32Float64Methods.DualFloat32Float64Codec.Decode(r);
            var w = new GronWriter();
            DualFloat32Float64Methods.DualFloat32Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat32Float64.gron")!);
            File.WriteAllBytes($"{outDir}/DualFloat32Float64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat32Float64 gron: {e.Message}"); }
    }

    static void TestModelDualFloat64Boolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Boolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualFloat64BooleanMethods.DualFloat64BooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            DualFloat64BooleanMethods.DualFloat64BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Boolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Boolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Boolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Boolean.json");
            var r = new JsonReader(data);
            var obj = DualFloat64BooleanMethods.DualFloat64BooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualFloat64BooleanMethods.DualFloat64BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Boolean.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Boolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Boolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Boolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualFloat64BooleanMethods.DualFloat64BooleanCodec.Decode(r);
            var w = new JsonWriter();
            DualFloat64BooleanMethods.DualFloat64BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Boolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Boolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Boolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Boolean.gron");
            var r = new GronReader(data);
            var obj = DualFloat64BooleanMethods.DualFloat64BooleanCodec.Decode(r);
            var w = new GronWriter();
            DualFloat64BooleanMethods.DualFloat64BooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Boolean.gron")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Boolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Boolean gron: {e.Message}"); }
    }

    static void TestModelDualFloat64Bytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Bytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualFloat64BytesMethods.DualFloat64BytesCodec.Decode(r);
            var w = new MsgPackWriter();
            DualFloat64BytesMethods.DualFloat64BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Bytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Bytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Bytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Bytes.json");
            var r = new JsonReader(data);
            var obj = DualFloat64BytesMethods.DualFloat64BytesCodec.Decode(r);
            var w = new JsonWriter();
            DualFloat64BytesMethods.DualFloat64BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Bytes.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Bytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Bytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Bytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualFloat64BytesMethods.DualFloat64BytesCodec.Decode(r);
            var w = new JsonWriter();
            DualFloat64BytesMethods.DualFloat64BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Bytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Bytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Bytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Bytes.gron");
            var r = new GronReader(data);
            var obj = DualFloat64BytesMethods.DualFloat64BytesCodec.Decode(r);
            var w = new GronWriter();
            DualFloat64BytesMethods.DualFloat64BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Bytes.gron")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Bytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Bytes gron: {e.Message}"); }
    }

    static void TestModelDualUint32Uint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint32Uint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualUint32Uint64Methods.DualUint32Uint64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualUint32Uint64Methods.DualUint32Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint32Uint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualUint32Uint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint32Uint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint32Uint64.json");
            var r = new JsonReader(data);
            var obj = DualUint32Uint64Methods.DualUint32Uint64Codec.Decode(r);
            var w = new JsonWriter();
            DualUint32Uint64Methods.DualUint32Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint32Uint64.json")!);
            File.WriteAllBytes($"{outDir}/DualUint32Uint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint32Uint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint32Uint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualUint32Uint64Methods.DualUint32Uint64Codec.Decode(r);
            var w = new JsonWriter();
            DualUint32Uint64Methods.DualUint32Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint32Uint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualUint32Uint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint32Uint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint32Uint64.gron");
            var r = new GronReader(data);
            var obj = DualUint32Uint64Methods.DualUint32Uint64Codec.Decode(r);
            var w = new GronWriter();
            DualUint32Uint64Methods.DualUint32Uint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint32Uint64.gron")!);
            File.WriteAllBytes($"{outDir}/DualUint32Uint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint32Uint64 gron: {e.Message}"); }
    }

    static void TestModelDualBooleanBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualBooleanBytesMethods.DualBooleanBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            DualBooleanBytesMethods.DualBooleanBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualBooleanBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanBytes.json");
            var r = new JsonReader(data);
            var obj = DualBooleanBytesMethods.DualBooleanBytesCodec.Decode(r);
            var w = new JsonWriter();
            DualBooleanBytesMethods.DualBooleanBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanBytes.json")!);
            File.WriteAllBytes($"{outDir}/DualBooleanBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualBooleanBytesMethods.DualBooleanBytesCodec.Decode(r);
            var w = new JsonWriter();
            DualBooleanBytesMethods.DualBooleanBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualBooleanBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanBytes.gron");
            var r = new GronReader(data);
            var obj = DualBooleanBytesMethods.DualBooleanBytesCodec.Decode(r);
            var w = new GronWriter();
            DualBooleanBytesMethods.DualBooleanBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanBytes.gron")!);
            File.WriteAllBytes($"{outDir}/DualBooleanBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanBytes gron: {e.Message}"); }
    }

    static void TestModelDualInt8Uint8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Uint8.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt8Uint8Methods.DualInt8Uint8Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt8Uint8Methods.DualInt8Uint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Uint8.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt8Uint8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Uint8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Uint8.json");
            var r = new JsonReader(data);
            var obj = DualInt8Uint8Methods.DualInt8Uint8Codec.Decode(r);
            var w = new JsonWriter();
            DualInt8Uint8Methods.DualInt8Uint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Uint8.json")!);
            File.WriteAllBytes($"{outDir}/DualInt8Uint8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Uint8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Uint8.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt8Uint8Methods.DualInt8Uint8Codec.Decode(r);
            var w = new JsonWriter();
            DualInt8Uint8Methods.DualInt8Uint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Uint8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt8Uint8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Uint8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Uint8.gron");
            var r = new GronReader(data);
            var obj = DualInt8Uint8Methods.DualInt8Uint8Codec.Decode(r);
            var w = new GronWriter();
            DualInt8Uint8Methods.DualInt8Uint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Uint8.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt8Uint8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Uint8 gron: {e.Message}"); }
    }

    static void TestModelDualInt16Uint16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt16Uint16.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt16Uint16Methods.DualInt16Uint16Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt16Uint16Methods.DualInt16Uint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt16Uint16.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt16Uint16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt16Uint16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt16Uint16.json");
            var r = new JsonReader(data);
            var obj = DualInt16Uint16Methods.DualInt16Uint16Codec.Decode(r);
            var w = new JsonWriter();
            DualInt16Uint16Methods.DualInt16Uint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt16Uint16.json")!);
            File.WriteAllBytes($"{outDir}/DualInt16Uint16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt16Uint16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt16Uint16.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt16Uint16Methods.DualInt16Uint16Codec.Decode(r);
            var w = new JsonWriter();
            DualInt16Uint16Methods.DualInt16Uint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt16Uint16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt16Uint16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt16Uint16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt16Uint16.gron");
            var r = new GronReader(data);
            var obj = DualInt16Uint16Methods.DualInt16Uint16Codec.Decode(r);
            var w = new GronWriter();
            DualInt16Uint16Methods.DualInt16Uint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt16Uint16.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt16Uint16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt16Uint16 gron: {e.Message}"); }
    }

    static void TestModelDualStringInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringInt64Methods.DualStringInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualStringInt64Methods.DualStringInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt64.json");
            var r = new JsonReader(data);
            var obj = DualStringInt64Methods.DualStringInt64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringInt64Methods.DualStringInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt64.json")!);
            File.WriteAllBytes($"{outDir}/DualStringInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringInt64Methods.DualStringInt64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringInt64Methods.DualStringInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringInt64.gron");
            var r = new GronReader(data);
            var obj = DualStringInt64Methods.DualStringInt64Codec.Decode(r);
            var w = new GronWriter();
            DualStringInt64Methods.DualStringInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringInt64.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringInt64 gron: {e.Message}"); }
    }

    static void TestModelDualStringUint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringUint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualStringUint64Methods.DualStringUint64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualStringUint64Methods.DualStringUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringUint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualStringUint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringUint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringUint64.json");
            var r = new JsonReader(data);
            var obj = DualStringUint64Methods.DualStringUint64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringUint64Methods.DualStringUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringUint64.json")!);
            File.WriteAllBytes($"{outDir}/DualStringUint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringUint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringUint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualStringUint64Methods.DualStringUint64Codec.Decode(r);
            var w = new JsonWriter();
            DualStringUint64Methods.DualStringUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringUint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualStringUint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringUint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualStringUint64.gron");
            var r = new GronReader(data);
            var obj = DualStringUint64Methods.DualStringUint64Codec.Decode(r);
            var w = new GronWriter();
            DualStringUint64Methods.DualStringUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualStringUint64.gron")!);
            File.WriteAllBytes($"{outDir}/DualStringUint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualStringUint64 gron: {e.Message}"); }
    }

    static void TestModelDualInt32Bytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Bytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt32BytesMethods.DualInt32BytesCodec.Decode(r);
            var w = new MsgPackWriter();
            DualInt32BytesMethods.DualInt32BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Bytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt32Bytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Bytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Bytes.json");
            var r = new JsonReader(data);
            var obj = DualInt32BytesMethods.DualInt32BytesCodec.Decode(r);
            var w = new JsonWriter();
            DualInt32BytesMethods.DualInt32BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Bytes.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Bytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Bytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Bytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt32BytesMethods.DualInt32BytesCodec.Decode(r);
            var w = new JsonWriter();
            DualInt32BytesMethods.DualInt32BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Bytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt32Bytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Bytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt32Bytes.gron");
            var r = new GronReader(data);
            var obj = DualInt32BytesMethods.DualInt32BytesCodec.Decode(r);
            var w = new GronWriter();
            DualInt32BytesMethods.DualInt32BytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt32Bytes.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt32Bytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt32Bytes gron: {e.Message}"); }
    }

    static void TestModelDualFloat64Int32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Int32.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualFloat64Int32Methods.DualFloat64Int32Codec.Decode(r);
            var w = new MsgPackWriter();
            DualFloat64Int32Methods.DualFloat64Int32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Int32.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Int32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Int32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Int32.json");
            var r = new JsonReader(data);
            var obj = DualFloat64Int32Methods.DualFloat64Int32Codec.Decode(r);
            var w = new JsonWriter();
            DualFloat64Int32Methods.DualFloat64Int32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Int32.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Int32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Int32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Int32.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualFloat64Int32Methods.DualFloat64Int32Codec.Decode(r);
            var w = new JsonWriter();
            DualFloat64Int32Methods.DualFloat64Int32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Int32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Int32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Int32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualFloat64Int32.gron");
            var r = new GronReader(data);
            var obj = DualFloat64Int32Methods.DualFloat64Int32Codec.Decode(r);
            var w = new GronWriter();
            DualFloat64Int32Methods.DualFloat64Int32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualFloat64Int32.gron")!);
            File.WriteAllBytes($"{outDir}/DualFloat64Int32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualFloat64Int32 gron: {e.Message}"); }
    }

    static void TestModelDualBooleanInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualBooleanInt32Methods.DualBooleanInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            DualBooleanInt32Methods.DualBooleanInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualBooleanInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanInt32.json");
            var r = new JsonReader(data);
            var obj = DualBooleanInt32Methods.DualBooleanInt32Codec.Decode(r);
            var w = new JsonWriter();
            DualBooleanInt32Methods.DualBooleanInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanInt32.json")!);
            File.WriteAllBytes($"{outDir}/DualBooleanInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualBooleanInt32Methods.DualBooleanInt32Codec.Decode(r);
            var w = new JsonWriter();
            DualBooleanInt32Methods.DualBooleanInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualBooleanInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBooleanInt32.gron");
            var r = new GronReader(data);
            var obj = DualBooleanInt32Methods.DualBooleanInt32Codec.Decode(r);
            var w = new GronWriter();
            DualBooleanInt32Methods.DualBooleanInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBooleanInt32.gron")!);
            File.WriteAllBytes($"{outDir}/DualBooleanInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBooleanInt32 gron: {e.Message}"); }
    }

    static void TestModelDualBytesInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBytesInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualBytesInt64Methods.DualBytesInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualBytesInt64Methods.DualBytesInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBytesInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualBytesInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBytesInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBytesInt64.json");
            var r = new JsonReader(data);
            var obj = DualBytesInt64Methods.DualBytesInt64Codec.Decode(r);
            var w = new JsonWriter();
            DualBytesInt64Methods.DualBytesInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBytesInt64.json")!);
            File.WriteAllBytes($"{outDir}/DualBytesInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBytesInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBytesInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualBytesInt64Methods.DualBytesInt64Codec.Decode(r);
            var w = new JsonWriter();
            DualBytesInt64Methods.DualBytesInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBytesInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualBytesInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBytesInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualBytesInt64.gron");
            var r = new GronReader(data);
            var obj = DualBytesInt64Methods.DualBytesInt64Codec.Decode(r);
            var w = new GronWriter();
            DualBytesInt64Methods.DualBytesInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualBytesInt64.gron")!);
            File.WriteAllBytes($"{outDir}/DualBytesInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualBytesInt64 gron: {e.Message}"); }
    }

    static void TestModelDualInt8Float32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Float32.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt8Float32Methods.DualInt8Float32Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt8Float32Methods.DualInt8Float32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Float32.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt8Float32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Float32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Float32.json");
            var r = new JsonReader(data);
            var obj = DualInt8Float32Methods.DualInt8Float32Codec.Decode(r);
            var w = new JsonWriter();
            DualInt8Float32Methods.DualInt8Float32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Float32.json")!);
            File.WriteAllBytes($"{outDir}/DualInt8Float32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Float32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Float32.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt8Float32Methods.DualInt8Float32Codec.Decode(r);
            var w = new JsonWriter();
            DualInt8Float32Methods.DualInt8Float32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Float32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt8Float32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Float32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt8Float32.gron");
            var r = new GronReader(data);
            var obj = DualInt8Float32Methods.DualInt8Float32Codec.Decode(r);
            var w = new GronWriter();
            DualInt8Float32Methods.DualInt8Float32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt8Float32.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt8Float32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt8Float32 gron: {e.Message}"); }
    }

    static void TestModelDualUint8Int16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint8Int16.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualUint8Int16Methods.DualUint8Int16Codec.Decode(r);
            var w = new MsgPackWriter();
            DualUint8Int16Methods.DualUint8Int16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint8Int16.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualUint8Int16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint8Int16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint8Int16.json");
            var r = new JsonReader(data);
            var obj = DualUint8Int16Methods.DualUint8Int16Codec.Decode(r);
            var w = new JsonWriter();
            DualUint8Int16Methods.DualUint8Int16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint8Int16.json")!);
            File.WriteAllBytes($"{outDir}/DualUint8Int16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint8Int16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint8Int16.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualUint8Int16Methods.DualUint8Int16Codec.Decode(r);
            var w = new JsonWriter();
            DualUint8Int16Methods.DualUint8Int16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint8Int16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualUint8Int16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint8Int16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint8Int16.gron");
            var r = new GronReader(data);
            var obj = DualUint8Int16Methods.DualUint8Int16Codec.Decode(r);
            var w = new GronWriter();
            DualUint8Int16Methods.DualUint8Int16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint8Int16.gron")!);
            File.WriteAllBytes($"{outDir}/DualUint8Int16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint8Int16 gron: {e.Message}"); }
    }

    static void TestModelDualInt64Float64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Float64.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualInt64Float64Methods.DualInt64Float64Codec.Decode(r);
            var w = new MsgPackWriter();
            DualInt64Float64Methods.DualInt64Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Float64.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualInt64Float64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Float64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Float64.json");
            var r = new JsonReader(data);
            var obj = DualInt64Float64Methods.DualInt64Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt64Float64Methods.DualInt64Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Float64.json")!);
            File.WriteAllBytes($"{outDir}/DualInt64Float64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Float64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Float64.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualInt64Float64Methods.DualInt64Float64Codec.Decode(r);
            var w = new JsonWriter();
            DualInt64Float64Methods.DualInt64Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Float64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualInt64Float64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Float64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualInt64Float64.gron");
            var r = new GronReader(data);
            var obj = DualInt64Float64Methods.DualInt64Float64Codec.Decode(r);
            var w = new GronWriter();
            DualInt64Float64Methods.DualInt64Float64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualInt64Float64.gron")!);
            File.WriteAllBytes($"{outDir}/DualInt64Float64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualInt64Float64 gron: {e.Message}"); }
    }

    static void TestModelDualUint64String(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint64String.msgpack");
            var r = new MsgPackReader(data);
            var obj = DualUint64StringMethods.DualUint64StringCodec.Decode(r);
            var w = new MsgPackWriter();
            DualUint64StringMethods.DualUint64StringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint64String.msgpack")!);
            File.WriteAllBytes($"{outDir}/DualUint64String.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint64String mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint64String.json");
            var r = new JsonReader(data);
            var obj = DualUint64StringMethods.DualUint64StringCodec.Decode(r);
            var w = new JsonWriter();
            DualUint64StringMethods.DualUint64StringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint64String.json")!);
            File.WriteAllBytes($"{outDir}/DualUint64String.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint64String json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint64String.unformatted.json");
            var r = new JsonReader(data);
            var obj = DualUint64StringMethods.DualUint64StringCodec.Decode(r);
            var w = new JsonWriter();
            DualUint64StringMethods.DualUint64StringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint64String.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DualUint64String.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint64String unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DualUint64String.gron");
            var r = new GronReader(data);
            var obj = DualUint64StringMethods.DualUint64StringCodec.Decode(r);
            var w = new GronWriter();
            DualUint64StringMethods.DualUint64StringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DualUint64String.gron")!);
            File.WriteAllBytes($"{outDir}/DualUint64String.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DualUint64String gron: {e.Message}"); }
    }

    static void TestModelTriple01(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple01Methods.Triple01Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple01Methods.Triple01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple01.json");
            var r = new JsonReader(data);
            var obj = Triple01Methods.Triple01Codec.Decode(r);
            var w = new JsonWriter();
            Triple01Methods.Triple01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple01.json")!);
            File.WriteAllBytes($"{outDir}/Triple01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple01Methods.Triple01Codec.Decode(r);
            var w = new JsonWriter();
            Triple01Methods.Triple01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple01.gron");
            var r = new GronReader(data);
            var obj = Triple01Methods.Triple01Codec.Decode(r);
            var w = new GronWriter();
            Triple01Methods.Triple01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple01.gron")!);
            File.WriteAllBytes($"{outDir}/Triple01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple01 gron: {e.Message}"); }
    }

    static void TestModelTriple02(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple02Methods.Triple02Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple02Methods.Triple02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple02.json");
            var r = new JsonReader(data);
            var obj = Triple02Methods.Triple02Codec.Decode(r);
            var w = new JsonWriter();
            Triple02Methods.Triple02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple02.json")!);
            File.WriteAllBytes($"{outDir}/Triple02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple02Methods.Triple02Codec.Decode(r);
            var w = new JsonWriter();
            Triple02Methods.Triple02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple02.gron");
            var r = new GronReader(data);
            var obj = Triple02Methods.Triple02Codec.Decode(r);
            var w = new GronWriter();
            Triple02Methods.Triple02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple02.gron")!);
            File.WriteAllBytes($"{outDir}/Triple02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple02 gron: {e.Message}"); }
    }

    static void TestModelTriple03(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple03Methods.Triple03Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple03Methods.Triple03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple03.json");
            var r = new JsonReader(data);
            var obj = Triple03Methods.Triple03Codec.Decode(r);
            var w = new JsonWriter();
            Triple03Methods.Triple03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple03.json")!);
            File.WriteAllBytes($"{outDir}/Triple03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple03Methods.Triple03Codec.Decode(r);
            var w = new JsonWriter();
            Triple03Methods.Triple03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple03.gron");
            var r = new GronReader(data);
            var obj = Triple03Methods.Triple03Codec.Decode(r);
            var w = new GronWriter();
            Triple03Methods.Triple03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple03.gron")!);
            File.WriteAllBytes($"{outDir}/Triple03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple03 gron: {e.Message}"); }
    }

    static void TestModelTriple04(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple04Methods.Triple04Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple04Methods.Triple04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple04.json");
            var r = new JsonReader(data);
            var obj = Triple04Methods.Triple04Codec.Decode(r);
            var w = new JsonWriter();
            Triple04Methods.Triple04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple04.json")!);
            File.WriteAllBytes($"{outDir}/Triple04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple04Methods.Triple04Codec.Decode(r);
            var w = new JsonWriter();
            Triple04Methods.Triple04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple04.gron");
            var r = new GronReader(data);
            var obj = Triple04Methods.Triple04Codec.Decode(r);
            var w = new GronWriter();
            Triple04Methods.Triple04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple04.gron")!);
            File.WriteAllBytes($"{outDir}/Triple04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple04 gron: {e.Message}"); }
    }

    static void TestModelTriple05(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple05Methods.Triple05Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple05Methods.Triple05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple05.json");
            var r = new JsonReader(data);
            var obj = Triple05Methods.Triple05Codec.Decode(r);
            var w = new JsonWriter();
            Triple05Methods.Triple05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple05.json")!);
            File.WriteAllBytes($"{outDir}/Triple05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple05Methods.Triple05Codec.Decode(r);
            var w = new JsonWriter();
            Triple05Methods.Triple05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple05.gron");
            var r = new GronReader(data);
            var obj = Triple05Methods.Triple05Codec.Decode(r);
            var w = new GronWriter();
            Triple05Methods.Triple05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple05.gron")!);
            File.WriteAllBytes($"{outDir}/Triple05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple05 gron: {e.Message}"); }
    }

    static void TestModelTriple06(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple06.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple06Methods.Triple06Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple06Methods.Triple06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple06.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple06.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple06 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple06.json");
            var r = new JsonReader(data);
            var obj = Triple06Methods.Triple06Codec.Decode(r);
            var w = new JsonWriter();
            Triple06Methods.Triple06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple06.json")!);
            File.WriteAllBytes($"{outDir}/Triple06.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple06 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple06.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple06Methods.Triple06Codec.Decode(r);
            var w = new JsonWriter();
            Triple06Methods.Triple06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple06.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple06.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple06 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple06.gron");
            var r = new GronReader(data);
            var obj = Triple06Methods.Triple06Codec.Decode(r);
            var w = new GronWriter();
            Triple06Methods.Triple06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple06.gron")!);
            File.WriteAllBytes($"{outDir}/Triple06.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple06 gron: {e.Message}"); }
    }

    static void TestModelTriple07(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple07.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple07Methods.Triple07Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple07Methods.Triple07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple07.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple07.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple07 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple07.json");
            var r = new JsonReader(data);
            var obj = Triple07Methods.Triple07Codec.Decode(r);
            var w = new JsonWriter();
            Triple07Methods.Triple07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple07.json")!);
            File.WriteAllBytes($"{outDir}/Triple07.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple07 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple07.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple07Methods.Triple07Codec.Decode(r);
            var w = new JsonWriter();
            Triple07Methods.Triple07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple07.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple07.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple07 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple07.gron");
            var r = new GronReader(data);
            var obj = Triple07Methods.Triple07Codec.Decode(r);
            var w = new GronWriter();
            Triple07Methods.Triple07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple07.gron")!);
            File.WriteAllBytes($"{outDir}/Triple07.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple07 gron: {e.Message}"); }
    }

    static void TestModelTriple08(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple08.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple08Methods.Triple08Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple08Methods.Triple08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple08.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple08.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple08 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple08.json");
            var r = new JsonReader(data);
            var obj = Triple08Methods.Triple08Codec.Decode(r);
            var w = new JsonWriter();
            Triple08Methods.Triple08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple08.json")!);
            File.WriteAllBytes($"{outDir}/Triple08.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple08 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple08.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple08Methods.Triple08Codec.Decode(r);
            var w = new JsonWriter();
            Triple08Methods.Triple08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple08.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple08.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple08 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple08.gron");
            var r = new GronReader(data);
            var obj = Triple08Methods.Triple08Codec.Decode(r);
            var w = new GronWriter();
            Triple08Methods.Triple08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple08.gron")!);
            File.WriteAllBytes($"{outDir}/Triple08.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple08 gron: {e.Message}"); }
    }

    static void TestModelTriple09(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple09.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple09Methods.Triple09Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple09Methods.Triple09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple09.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple09.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple09 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple09.json");
            var r = new JsonReader(data);
            var obj = Triple09Methods.Triple09Codec.Decode(r);
            var w = new JsonWriter();
            Triple09Methods.Triple09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple09.json")!);
            File.WriteAllBytes($"{outDir}/Triple09.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple09 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple09.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple09Methods.Triple09Codec.Decode(r);
            var w = new JsonWriter();
            Triple09Methods.Triple09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple09.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple09.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple09 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple09.gron");
            var r = new GronReader(data);
            var obj = Triple09Methods.Triple09Codec.Decode(r);
            var w = new GronWriter();
            Triple09Methods.Triple09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple09.gron")!);
            File.WriteAllBytes($"{outDir}/Triple09.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple09 gron: {e.Message}"); }
    }

    static void TestModelTriple10(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple10.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple10Methods.Triple10Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple10Methods.Triple10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple10.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple10.json");
            var r = new JsonReader(data);
            var obj = Triple10Methods.Triple10Codec.Decode(r);
            var w = new JsonWriter();
            Triple10Methods.Triple10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple10.json")!);
            File.WriteAllBytes($"{outDir}/Triple10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple10.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple10Methods.Triple10Codec.Decode(r);
            var w = new JsonWriter();
            Triple10Methods.Triple10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple10.gron");
            var r = new GronReader(data);
            var obj = Triple10Methods.Triple10Codec.Decode(r);
            var w = new GronWriter();
            Triple10Methods.Triple10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple10.gron")!);
            File.WriteAllBytes($"{outDir}/Triple10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple10 gron: {e.Message}"); }
    }

    static void TestModelTriple11(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple11.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple11Methods.Triple11Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple11Methods.Triple11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple11.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple11.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple11 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple11.json");
            var r = new JsonReader(data);
            var obj = Triple11Methods.Triple11Codec.Decode(r);
            var w = new JsonWriter();
            Triple11Methods.Triple11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple11.json")!);
            File.WriteAllBytes($"{outDir}/Triple11.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple11 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple11.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple11Methods.Triple11Codec.Decode(r);
            var w = new JsonWriter();
            Triple11Methods.Triple11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple11.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple11.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple11 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple11.gron");
            var r = new GronReader(data);
            var obj = Triple11Methods.Triple11Codec.Decode(r);
            var w = new GronWriter();
            Triple11Methods.Triple11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple11.gron")!);
            File.WriteAllBytes($"{outDir}/Triple11.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple11 gron: {e.Message}"); }
    }

    static void TestModelTriple12(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple12.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple12Methods.Triple12Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple12Methods.Triple12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple12.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple12.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple12 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple12.json");
            var r = new JsonReader(data);
            var obj = Triple12Methods.Triple12Codec.Decode(r);
            var w = new JsonWriter();
            Triple12Methods.Triple12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple12.json")!);
            File.WriteAllBytes($"{outDir}/Triple12.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple12 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple12.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple12Methods.Triple12Codec.Decode(r);
            var w = new JsonWriter();
            Triple12Methods.Triple12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple12.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple12.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple12 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple12.gron");
            var r = new GronReader(data);
            var obj = Triple12Methods.Triple12Codec.Decode(r);
            var w = new GronWriter();
            Triple12Methods.Triple12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple12.gron")!);
            File.WriteAllBytes($"{outDir}/Triple12.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple12 gron: {e.Message}"); }
    }

    static void TestModelTriple13(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple13.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple13Methods.Triple13Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple13Methods.Triple13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple13.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple13.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple13 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple13.json");
            var r = new JsonReader(data);
            var obj = Triple13Methods.Triple13Codec.Decode(r);
            var w = new JsonWriter();
            Triple13Methods.Triple13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple13.json")!);
            File.WriteAllBytes($"{outDir}/Triple13.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple13 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple13.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple13Methods.Triple13Codec.Decode(r);
            var w = new JsonWriter();
            Triple13Methods.Triple13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple13.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple13.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple13 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple13.gron");
            var r = new GronReader(data);
            var obj = Triple13Methods.Triple13Codec.Decode(r);
            var w = new GronWriter();
            Triple13Methods.Triple13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple13.gron")!);
            File.WriteAllBytes($"{outDir}/Triple13.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple13 gron: {e.Message}"); }
    }

    static void TestModelTriple14(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple14.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple14Methods.Triple14Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple14Methods.Triple14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple14.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple14.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple14 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple14.json");
            var r = new JsonReader(data);
            var obj = Triple14Methods.Triple14Codec.Decode(r);
            var w = new JsonWriter();
            Triple14Methods.Triple14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple14.json")!);
            File.WriteAllBytes($"{outDir}/Triple14.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple14 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple14.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple14Methods.Triple14Codec.Decode(r);
            var w = new JsonWriter();
            Triple14Methods.Triple14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple14.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple14.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple14 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple14.gron");
            var r = new GronReader(data);
            var obj = Triple14Methods.Triple14Codec.Decode(r);
            var w = new GronWriter();
            Triple14Methods.Triple14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple14.gron")!);
            File.WriteAllBytes($"{outDir}/Triple14.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple14 gron: {e.Message}"); }
    }

    static void TestModelTriple15(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple15.msgpack");
            var r = new MsgPackReader(data);
            var obj = Triple15Methods.Triple15Codec.Decode(r);
            var w = new MsgPackWriter();
            Triple15Methods.Triple15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple15.msgpack")!);
            File.WriteAllBytes($"{outDir}/Triple15.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple15 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple15.json");
            var r = new JsonReader(data);
            var obj = Triple15Methods.Triple15Codec.Decode(r);
            var w = new JsonWriter();
            Triple15Methods.Triple15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple15.json")!);
            File.WriteAllBytes($"{outDir}/Triple15.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple15 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple15.unformatted.json");
            var r = new JsonReader(data);
            var obj = Triple15Methods.Triple15Codec.Decode(r);
            var w = new JsonWriter();
            Triple15Methods.Triple15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple15.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Triple15.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple15 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Triple15.gron");
            var r = new GronReader(data);
            var obj = Triple15Methods.Triple15Codec.Decode(r);
            var w = new GronWriter();
            Triple15Methods.Triple15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Triple15.gron")!);
            File.WriteAllBytes($"{outDir}/Triple15.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Triple15 gron: {e.Message}"); }
    }

}
