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

public static class EmitTest_all_types__scalars {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelSingleString(ref passed, ref failed, vecDir, outDir);
        TestModelSingleBoolean(ref passed, ref failed, vecDir, outDir);
        TestModelSingleInt8(ref passed, ref failed, vecDir, outDir);
        TestModelSingleInt16(ref passed, ref failed, vecDir, outDir);
        TestModelSingleInt32(ref passed, ref failed, vecDir, outDir);
        TestModelSingleInt64(ref passed, ref failed, vecDir, outDir);
        TestModelSingleUint8(ref passed, ref failed, vecDir, outDir);
        TestModelSingleUint16(ref passed, ref failed, vecDir, outDir);
        TestModelSingleUint32(ref passed, ref failed, vecDir, outDir);
        TestModelSingleUint64(ref passed, ref failed, vecDir, outDir);
        TestModelSingleFloat32(ref passed, ref failed, vecDir, outDir);
        TestModelSingleFloat64(ref passed, ref failed, vecDir, outDir);
        TestModelSingleBytes(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelSingleString(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleString.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleStringMethods.SingleStringCodec.Decode(r);
            var w = new MsgPackWriter();
            SingleStringMethods.SingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleString.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleString.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleString mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleString.json");
            var r = new JsonReader(data);
            var obj = SingleStringMethods.SingleStringCodec.Decode(r);
            var w = new JsonWriter();
            SingleStringMethods.SingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleString.json")!);
            File.WriteAllBytes($"{outDir}/SingleString.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleString json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleString.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleStringMethods.SingleStringCodec.Decode(r);
            var w = new JsonWriter();
            SingleStringMethods.SingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleString.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleString.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleString unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleString.gron");
            var r = new GronReader(data);
            var obj = SingleStringMethods.SingleStringCodec.Decode(r);
            var w = new GronWriter();
            SingleStringMethods.SingleStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleString.gron")!);
            File.WriteAllBytes($"{outDir}/SingleString.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleString gron: {e.Message}"); }
    }

    static void TestModelSingleBoolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBoolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleBooleanMethods.SingleBooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            SingleBooleanMethods.SingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBoolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleBoolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBoolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBoolean.json");
            var r = new JsonReader(data);
            var obj = SingleBooleanMethods.SingleBooleanCodec.Decode(r);
            var w = new JsonWriter();
            SingleBooleanMethods.SingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBoolean.json")!);
            File.WriteAllBytes($"{outDir}/SingleBoolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBoolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBoolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleBooleanMethods.SingleBooleanCodec.Decode(r);
            var w = new JsonWriter();
            SingleBooleanMethods.SingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBoolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleBoolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBoolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBoolean.gron");
            var r = new GronReader(data);
            var obj = SingleBooleanMethods.SingleBooleanCodec.Decode(r);
            var w = new GronWriter();
            SingleBooleanMethods.SingleBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBoolean.gron")!);
            File.WriteAllBytes($"{outDir}/SingleBoolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBoolean gron: {e.Message}"); }
    }

    static void TestModelSingleInt8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt8.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleInt8Methods.SingleInt8Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleInt8Methods.SingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt8.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleInt8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt8.json");
            var r = new JsonReader(data);
            var obj = SingleInt8Methods.SingleInt8Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt8Methods.SingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt8.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt8.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleInt8Methods.SingleInt8Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt8Methods.SingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt8.gron");
            var r = new GronReader(data);
            var obj = SingleInt8Methods.SingleInt8Codec.Decode(r);
            var w = new GronWriter();
            SingleInt8Methods.SingleInt8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt8.gron")!);
            File.WriteAllBytes($"{outDir}/SingleInt8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt8 gron: {e.Message}"); }
    }

    static void TestModelSingleInt16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt16.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleInt16Methods.SingleInt16Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleInt16Methods.SingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt16.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleInt16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt16.json");
            var r = new JsonReader(data);
            var obj = SingleInt16Methods.SingleInt16Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt16Methods.SingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt16.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt16.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleInt16Methods.SingleInt16Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt16Methods.SingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt16.gron");
            var r = new GronReader(data);
            var obj = SingleInt16Methods.SingleInt16Codec.Decode(r);
            var w = new GronWriter();
            SingleInt16Methods.SingleInt16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt16.gron")!);
            File.WriteAllBytes($"{outDir}/SingleInt16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt16 gron: {e.Message}"); }
    }

    static void TestModelSingleInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleInt32Methods.SingleInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleInt32Methods.SingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt32.json");
            var r = new JsonReader(data);
            var obj = SingleInt32Methods.SingleInt32Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt32Methods.SingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt32.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleInt32Methods.SingleInt32Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt32Methods.SingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt32.gron");
            var r = new GronReader(data);
            var obj = SingleInt32Methods.SingleInt32Codec.Decode(r);
            var w = new GronWriter();
            SingleInt32Methods.SingleInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt32.gron")!);
            File.WriteAllBytes($"{outDir}/SingleInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt32 gron: {e.Message}"); }
    }

    static void TestModelSingleInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleInt64Methods.SingleInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleInt64Methods.SingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt64.json");
            var r = new JsonReader(data);
            var obj = SingleInt64Methods.SingleInt64Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt64Methods.SingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt64.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleInt64Methods.SingleInt64Codec.Decode(r);
            var w = new JsonWriter();
            SingleInt64Methods.SingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleInt64.gron");
            var r = new GronReader(data);
            var obj = SingleInt64Methods.SingleInt64Codec.Decode(r);
            var w = new GronWriter();
            SingleInt64Methods.SingleInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleInt64.gron")!);
            File.WriteAllBytes($"{outDir}/SingleInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleInt64 gron: {e.Message}"); }
    }

    static void TestModelSingleUint8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint8.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleUint8Methods.SingleUint8Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleUint8Methods.SingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint8.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleUint8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint8.json");
            var r = new JsonReader(data);
            var obj = SingleUint8Methods.SingleUint8Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint8Methods.SingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint8.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint8.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleUint8Methods.SingleUint8Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint8Methods.SingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint8.gron");
            var r = new GronReader(data);
            var obj = SingleUint8Methods.SingleUint8Codec.Decode(r);
            var w = new GronWriter();
            SingleUint8Methods.SingleUint8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint8.gron")!);
            File.WriteAllBytes($"{outDir}/SingleUint8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint8 gron: {e.Message}"); }
    }

    static void TestModelSingleUint16(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint16.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleUint16Methods.SingleUint16Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleUint16Methods.SingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint16.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleUint16.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint16 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint16.json");
            var r = new JsonReader(data);
            var obj = SingleUint16Methods.SingleUint16Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint16Methods.SingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint16.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint16.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint16 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint16.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleUint16Methods.SingleUint16Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint16Methods.SingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint16.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint16.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint16 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint16.gron");
            var r = new GronReader(data);
            var obj = SingleUint16Methods.SingleUint16Codec.Decode(r);
            var w = new GronWriter();
            SingleUint16Methods.SingleUint16Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint16.gron")!);
            File.WriteAllBytes($"{outDir}/SingleUint16.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint16 gron: {e.Message}"); }
    }

    static void TestModelSingleUint32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint32.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleUint32Methods.SingleUint32Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleUint32Methods.SingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint32.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleUint32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint32.json");
            var r = new JsonReader(data);
            var obj = SingleUint32Methods.SingleUint32Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint32Methods.SingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint32.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint32.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleUint32Methods.SingleUint32Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint32Methods.SingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint32.gron");
            var r = new GronReader(data);
            var obj = SingleUint32Methods.SingleUint32Codec.Decode(r);
            var w = new GronWriter();
            SingleUint32Methods.SingleUint32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint32.gron")!);
            File.WriteAllBytes($"{outDir}/SingleUint32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint32 gron: {e.Message}"); }
    }

    static void TestModelSingleUint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleUint64Methods.SingleUint64Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleUint64Methods.SingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleUint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint64.json");
            var r = new JsonReader(data);
            var obj = SingleUint64Methods.SingleUint64Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint64Methods.SingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint64.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleUint64Methods.SingleUint64Codec.Decode(r);
            var w = new JsonWriter();
            SingleUint64Methods.SingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleUint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleUint64.gron");
            var r = new GronReader(data);
            var obj = SingleUint64Methods.SingleUint64Codec.Decode(r);
            var w = new GronWriter();
            SingleUint64Methods.SingleUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleUint64.gron")!);
            File.WriteAllBytes($"{outDir}/SingleUint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleUint64 gron: {e.Message}"); }
    }

    static void TestModelSingleFloat32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat32.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleFloat32Methods.SingleFloat32Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleFloat32Methods.SingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat32.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleFloat32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat32.json");
            var r = new JsonReader(data);
            var obj = SingleFloat32Methods.SingleFloat32Codec.Decode(r);
            var w = new JsonWriter();
            SingleFloat32Methods.SingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat32.json")!);
            File.WriteAllBytes($"{outDir}/SingleFloat32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat32.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleFloat32Methods.SingleFloat32Codec.Decode(r);
            var w = new JsonWriter();
            SingleFloat32Methods.SingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleFloat32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat32.gron");
            var r = new GronReader(data);
            var obj = SingleFloat32Methods.SingleFloat32Codec.Decode(r);
            var w = new GronWriter();
            SingleFloat32Methods.SingleFloat32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat32.gron")!);
            File.WriteAllBytes($"{outDir}/SingleFloat32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat32 gron: {e.Message}"); }
    }

    static void TestModelSingleFloat64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat64.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleFloat64Methods.SingleFloat64Codec.Decode(r);
            var w = new MsgPackWriter();
            SingleFloat64Methods.SingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat64.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleFloat64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat64.json");
            var r = new JsonReader(data);
            var obj = SingleFloat64Methods.SingleFloat64Codec.Decode(r);
            var w = new JsonWriter();
            SingleFloat64Methods.SingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat64.json")!);
            File.WriteAllBytes($"{outDir}/SingleFloat64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat64.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleFloat64Methods.SingleFloat64Codec.Decode(r);
            var w = new JsonWriter();
            SingleFloat64Methods.SingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleFloat64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleFloat64.gron");
            var r = new GronReader(data);
            var obj = SingleFloat64Methods.SingleFloat64Codec.Decode(r);
            var w = new GronWriter();
            SingleFloat64Methods.SingleFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleFloat64.gron")!);
            File.WriteAllBytes($"{outDir}/SingleFloat64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleFloat64 gron: {e.Message}"); }
    }

    static void TestModelSingleBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = SingleBytesMethods.SingleBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            SingleBytesMethods.SingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/SingleBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBytes.json");
            var r = new JsonReader(data);
            var obj = SingleBytesMethods.SingleBytesCodec.Decode(r);
            var w = new JsonWriter();
            SingleBytesMethods.SingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBytes.json")!);
            File.WriteAllBytes($"{outDir}/SingleBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = SingleBytesMethods.SingleBytesCodec.Decode(r);
            var w = new JsonWriter();
            SingleBytesMethods.SingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/SingleBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/SingleBytes.gron");
            var r = new GronReader(data);
            var obj = SingleBytesMethods.SingleBytesCodec.Decode(r);
            var w = new GronWriter();
            SingleBytesMethods.SingleBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/SingleBytes.gron")!);
            File.WriteAllBytes($"{outDir}/SingleBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL SingleBytes gron: {e.Message}"); }
    }

}
