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

public static class EmitTest_all_types__opt {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelOptSingleString(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleBoolean(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleInt8(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleInt16(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleInt32(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleInt64(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleUint8(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleUint16(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleUint32(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleUint64(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleFloat32(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleFloat64(ref passed, ref failed, vecDir, outDir);
        TestModelOptSingleBytes(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelOptSingleString(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleString.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleStringMethods.OptSingleStringCodec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleStringMethods.OptSingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleString.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleString.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleString mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleString.json");
            var r = new JsonReader(data);
            var obj = OptSingleStringMethods.OptSingleStringCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleStringMethods.OptSingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleString.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleString.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleString json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleString.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleStringMethods.OptSingleStringCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleStringMethods.OptSingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleString.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleString.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleString unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleString.gron");
            var r = new GronReader(data);
            var obj = OptSingleStringMethods.OptSingleStringCodec.Decode(r);
            var w = new GronWriter();
            OptSingleStringMethods.OptSingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleString.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleString.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleString gron: {e.Message}"); }
    }

    static void TestModelOptSingleBoolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBoolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleBooleanMethods.OptSingleBooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleBooleanMethods.OptSingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBoolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleBoolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBoolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBoolean.json");
            var r = new JsonReader(data);
            var obj = OptSingleBooleanMethods.OptSingleBooleanCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleBooleanMethods.OptSingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBoolean.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleBoolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBoolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBoolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleBooleanMethods.OptSingleBooleanCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleBooleanMethods.OptSingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBoolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleBoolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBoolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBoolean.gron");
            var r = new GronReader(data);
            var obj = OptSingleBooleanMethods.OptSingleBooleanCodec.Decode(r);
            var w = new GronWriter();
            OptSingleBooleanMethods.OptSingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBoolean.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleBoolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBoolean gron: {e.Message}"); }
    }

    static void TestModelOptSingleInt8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt8.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleInt8Methods.OptSingleInt8Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleInt8Methods.OptSingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt8.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt8.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt8Methods.OptSingleInt8Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt8Methods.OptSingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt8.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt8.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt8Methods.OptSingleInt8Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt8Methods.OptSingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt8.gron");
            var r = new GronReader(data);
            var obj = OptSingleInt8Methods.OptSingleInt8Codec.Decode(r);
            var w = new GronWriter();
            OptSingleInt8Methods.OptSingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt8.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt8 gron: {e.Message}"); }
    }

    static void TestModelOptSingleInt16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt16.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleInt16Methods.OptSingleInt16Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleInt16Methods.OptSingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt16.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt16.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt16Methods.OptSingleInt16Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt16Methods.OptSingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt16.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt16.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt16Methods.OptSingleInt16Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt16Methods.OptSingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt16.gron");
            var r = new GronReader(data);
            var obj = OptSingleInt16Methods.OptSingleInt16Codec.Decode(r);
            var w = new GronWriter();
            OptSingleInt16Methods.OptSingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt16.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt16 gron: {e.Message}"); }
    }

    static void TestModelOptSingleInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleInt32Methods.OptSingleInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleInt32Methods.OptSingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt32.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt32Methods.OptSingleInt32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt32Methods.OptSingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt32.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt32Methods.OptSingleInt32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt32Methods.OptSingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt32.gron");
            var r = new GronReader(data);
            var obj = OptSingleInt32Methods.OptSingleInt32Codec.Decode(r);
            var w = new GronWriter();
            OptSingleInt32Methods.OptSingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt32.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt32 gron: {e.Message}"); }
    }

    static void TestModelOptSingleInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleInt64Methods.OptSingleInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleInt64Methods.OptSingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt64.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt64Methods.OptSingleInt64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt64Methods.OptSingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt64.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleInt64Methods.OptSingleInt64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleInt64Methods.OptSingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleInt64.gron");
            var r = new GronReader(data);
            var obj = OptSingleInt64Methods.OptSingleInt64Codec.Decode(r);
            var w = new GronWriter();
            OptSingleInt64Methods.OptSingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleInt64.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleInt64 gron: {e.Message}"); }
    }

    static void TestModelOptSingleUint8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint8.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleUint8Methods.OptSingleUint8Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleUint8Methods.OptSingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint8.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint8.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint8Methods.OptSingleUint8Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint8Methods.OptSingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint8.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint8.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint8Methods.OptSingleUint8Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint8Methods.OptSingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint8.gron");
            var r = new GronReader(data);
            var obj = OptSingleUint8Methods.OptSingleUint8Codec.Decode(r);
            var w = new GronWriter();
            OptSingleUint8Methods.OptSingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint8.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint8 gron: {e.Message}"); }
    }

    static void TestModelOptSingleUint16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint16.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleUint16Methods.OptSingleUint16Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleUint16Methods.OptSingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint16.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint16.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint16Methods.OptSingleUint16Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint16Methods.OptSingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint16.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint16.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint16Methods.OptSingleUint16Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint16Methods.OptSingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint16.gron");
            var r = new GronReader(data);
            var obj = OptSingleUint16Methods.OptSingleUint16Codec.Decode(r);
            var w = new GronWriter();
            OptSingleUint16Methods.OptSingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint16.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint16 gron: {e.Message}"); }
    }

    static void TestModelOptSingleUint32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint32.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleUint32Methods.OptSingleUint32Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleUint32Methods.OptSingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint32.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint32.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint32Methods.OptSingleUint32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint32Methods.OptSingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint32.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint32.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint32Methods.OptSingleUint32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint32Methods.OptSingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint32.gron");
            var r = new GronReader(data);
            var obj = OptSingleUint32Methods.OptSingleUint32Codec.Decode(r);
            var w = new GronWriter();
            OptSingleUint32Methods.OptSingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint32.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint32 gron: {e.Message}"); }
    }

    static void TestModelOptSingleUint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleUint64Methods.OptSingleUint64Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleUint64Methods.OptSingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint64.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint64Methods.OptSingleUint64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint64Methods.OptSingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint64.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleUint64Methods.OptSingleUint64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleUint64Methods.OptSingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleUint64.gron");
            var r = new GronReader(data);
            var obj = OptSingleUint64Methods.OptSingleUint64Codec.Decode(r);
            var w = new GronWriter();
            OptSingleUint64Methods.OptSingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleUint64.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleUint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleUint64 gron: {e.Message}"); }
    }

    static void TestModelOptSingleFloat32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat32.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleFloat32Methods.OptSingleFloat32Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleFloat32Methods.OptSingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat32.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat32.json");
            var r = new JsonReader(data);
            var obj = OptSingleFloat32Methods.OptSingleFloat32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleFloat32Methods.OptSingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat32.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat32.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleFloat32Methods.OptSingleFloat32Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleFloat32Methods.OptSingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat32.gron");
            var r = new GronReader(data);
            var obj = OptSingleFloat32Methods.OptSingleFloat32Codec.Decode(r);
            var w = new GronWriter();
            OptSingleFloat32Methods.OptSingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat32.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat32 gron: {e.Message}"); }
    }

    static void TestModelOptSingleFloat64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat64.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleFloat64Methods.OptSingleFloat64Codec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleFloat64Methods.OptSingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat64.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat64.json");
            var r = new JsonReader(data);
            var obj = OptSingleFloat64Methods.OptSingleFloat64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleFloat64Methods.OptSingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat64.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat64.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleFloat64Methods.OptSingleFloat64Codec.Decode(r);
            var w = new JsonWriter();
            OptSingleFloat64Methods.OptSingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleFloat64.gron");
            var r = new GronReader(data);
            var obj = OptSingleFloat64Methods.OptSingleFloat64Codec.Decode(r);
            var w = new GronWriter();
            OptSingleFloat64Methods.OptSingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleFloat64.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleFloat64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleFloat64 gron: {e.Message}"); }
    }

    static void TestModelOptSingleBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptSingleBytesMethods.OptSingleBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            OptSingleBytesMethods.OptSingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptSingleBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBytes.json");
            var r = new JsonReader(data);
            var obj = OptSingleBytesMethods.OptSingleBytesCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleBytesMethods.OptSingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBytes.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptSingleBytesMethods.OptSingleBytesCodec.Decode(r);
            var w = new JsonWriter();
            OptSingleBytesMethods.OptSingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptSingleBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptSingleBytes.gron");
            var r = new GronReader(data);
            var obj = OptSingleBytesMethods.OptSingleBytesCodec.Decode(r);
            var w = new GronWriter();
            OptSingleBytesMethods.OptSingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptSingleBytes.gron")!);
            File.WriteAllBytes($"{outDir}/OptSingleBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptSingleBytes gron: {e.Message}"); }
    }

}
