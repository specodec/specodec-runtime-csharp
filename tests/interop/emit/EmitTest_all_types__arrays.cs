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

public static class EmitTest_all_types__arrays {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelArrString(ref passed, ref failed, vecDir, outDir);
        TestModelArrInt32(ref passed, ref failed, vecDir, outDir);
        TestModelArrBoolean(ref passed, ref failed, vecDir, outDir);
        TestModelArrFloat64(ref passed, ref failed, vecDir, outDir);
        TestModelArrBytes(ref passed, ref failed, vecDir, outDir);
        TestModelArrInt64(ref passed, ref failed, vecDir, outDir);
        TestModelArrUint64(ref passed, ref failed, vecDir, outDir);
        TestModelMultiArr1(ref passed, ref failed, vecDir, outDir);
        TestModelMultiArr2(ref passed, ref failed, vecDir, outDir);
        TestModelMultiArr3(ref passed, ref failed, vecDir, outDir);
        TestModelMultiArr4(ref passed, ref failed, vecDir, outDir);
        TestModelMultiArr5(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo1(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo2(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo3(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo4(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo5(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo6(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo7(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo8(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo9(ref passed, ref failed, vecDir, outDir);
        TestModelOptCombo10(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelArrString(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrString.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrStringMethods.ArrStringCodec.Decode(r);
            var w = new MsgPackWriter();
            ArrStringMethods.ArrStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrString.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrString.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrString mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrString.json");
            var r = new JsonReader(data);
            var obj = ArrStringMethods.ArrStringCodec.Decode(r);
            var w = new JsonWriter();
            ArrStringMethods.ArrStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrString.json")!);
            File.WriteAllBytes($"{outDir}/ArrString.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrString json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrString.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrStringMethods.ArrStringCodec.Decode(r);
            var w = new JsonWriter();
            ArrStringMethods.ArrStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrString.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrString.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrString unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrString.gron");
            var r = new GronReader(data);
            var obj = ArrStringMethods.ArrStringCodec.Decode(r);
            var w = new GronWriter();
            ArrStringMethods.ArrStringCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrString.gron")!);
            File.WriteAllBytes($"{outDir}/ArrString.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrString gron: {e.Message}"); }
    }

    static void TestModelArrInt32(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt32.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrInt32Methods.ArrInt32Codec.Decode(r);
            var w = new MsgPackWriter();
            ArrInt32Methods.ArrInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt32.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrInt32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt32.json");
            var r = new JsonReader(data);
            var obj = ArrInt32Methods.ArrInt32Codec.Decode(r);
            var w = new JsonWriter();
            ArrInt32Methods.ArrInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt32.json")!);
            File.WriteAllBytes($"{outDir}/ArrInt32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt32.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrInt32Methods.ArrInt32Codec.Decode(r);
            var w = new JsonWriter();
            ArrInt32Methods.ArrInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrInt32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt32.gron");
            var r = new GronReader(data);
            var obj = ArrInt32Methods.ArrInt32Codec.Decode(r);
            var w = new GronWriter();
            ArrInt32Methods.ArrInt32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt32.gron")!);
            File.WriteAllBytes($"{outDir}/ArrInt32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt32 gron: {e.Message}"); }
    }

    static void TestModelArrBoolean(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBoolean.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrBooleanMethods.ArrBooleanCodec.Decode(r);
            var w = new MsgPackWriter();
            ArrBooleanMethods.ArrBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBoolean.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrBoolean.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBoolean mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBoolean.json");
            var r = new JsonReader(data);
            var obj = ArrBooleanMethods.ArrBooleanCodec.Decode(r);
            var w = new JsonWriter();
            ArrBooleanMethods.ArrBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBoolean.json")!);
            File.WriteAllBytes($"{outDir}/ArrBoolean.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBoolean json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBoolean.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrBooleanMethods.ArrBooleanCodec.Decode(r);
            var w = new JsonWriter();
            ArrBooleanMethods.ArrBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBoolean.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrBoolean.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBoolean unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBoolean.gron");
            var r = new GronReader(data);
            var obj = ArrBooleanMethods.ArrBooleanCodec.Decode(r);
            var w = new GronWriter();
            ArrBooleanMethods.ArrBooleanCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBoolean.gron")!);
            File.WriteAllBytes($"{outDir}/ArrBoolean.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBoolean gron: {e.Message}"); }
    }

    static void TestModelArrFloat64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrFloat64.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrFloat64Methods.ArrFloat64Codec.Decode(r);
            var w = new MsgPackWriter();
            ArrFloat64Methods.ArrFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrFloat64.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrFloat64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrFloat64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrFloat64.json");
            var r = new JsonReader(data);
            var obj = ArrFloat64Methods.ArrFloat64Codec.Decode(r);
            var w = new JsonWriter();
            ArrFloat64Methods.ArrFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrFloat64.json")!);
            File.WriteAllBytes($"{outDir}/ArrFloat64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrFloat64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrFloat64.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrFloat64Methods.ArrFloat64Codec.Decode(r);
            var w = new JsonWriter();
            ArrFloat64Methods.ArrFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrFloat64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrFloat64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrFloat64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrFloat64.gron");
            var r = new GronReader(data);
            var obj = ArrFloat64Methods.ArrFloat64Codec.Decode(r);
            var w = new GronWriter();
            ArrFloat64Methods.ArrFloat64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrFloat64.gron")!);
            File.WriteAllBytes($"{outDir}/ArrFloat64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrFloat64 gron: {e.Message}"); }
    }

    static void TestModelArrBytes(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBytes.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrBytesMethods.ArrBytesCodec.Decode(r);
            var w = new MsgPackWriter();
            ArrBytesMethods.ArrBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBytes.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrBytes.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBytes mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBytes.json");
            var r = new JsonReader(data);
            var obj = ArrBytesMethods.ArrBytesCodec.Decode(r);
            var w = new JsonWriter();
            ArrBytesMethods.ArrBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBytes.json")!);
            File.WriteAllBytes($"{outDir}/ArrBytes.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBytes json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBytes.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrBytesMethods.ArrBytesCodec.Decode(r);
            var w = new JsonWriter();
            ArrBytesMethods.ArrBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBytes.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrBytes.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBytes unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrBytes.gron");
            var r = new GronReader(data);
            var obj = ArrBytesMethods.ArrBytesCodec.Decode(r);
            var w = new GronWriter();
            ArrBytesMethods.ArrBytesCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrBytes.gron")!);
            File.WriteAllBytes($"{outDir}/ArrBytes.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrBytes gron: {e.Message}"); }
    }

    static void TestModelArrInt64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt64.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrInt64Methods.ArrInt64Codec.Decode(r);
            var w = new MsgPackWriter();
            ArrInt64Methods.ArrInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt64.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrInt64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt64.json");
            var r = new JsonReader(data);
            var obj = ArrInt64Methods.ArrInt64Codec.Decode(r);
            var w = new JsonWriter();
            ArrInt64Methods.ArrInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt64.json")!);
            File.WriteAllBytes($"{outDir}/ArrInt64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt64.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrInt64Methods.ArrInt64Codec.Decode(r);
            var w = new JsonWriter();
            ArrInt64Methods.ArrInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrInt64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrInt64.gron");
            var r = new GronReader(data);
            var obj = ArrInt64Methods.ArrInt64Codec.Decode(r);
            var w = new GronWriter();
            ArrInt64Methods.ArrInt64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrInt64.gron")!);
            File.WriteAllBytes($"{outDir}/ArrInt64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrInt64 gron: {e.Message}"); }
    }

    static void TestModelArrUint64(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrUint64.msgpack");
            var r = new MsgPackReader(data);
            var obj = ArrUint64Methods.ArrUint64Codec.Decode(r);
            var w = new MsgPackWriter();
            ArrUint64Methods.ArrUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrUint64.msgpack")!);
            File.WriteAllBytes($"{outDir}/ArrUint64.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrUint64 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrUint64.json");
            var r = new JsonReader(data);
            var obj = ArrUint64Methods.ArrUint64Codec.Decode(r);
            var w = new JsonWriter();
            ArrUint64Methods.ArrUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrUint64.json")!);
            File.WriteAllBytes($"{outDir}/ArrUint64.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrUint64 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrUint64.unformatted.json");
            var r = new JsonReader(data);
            var obj = ArrUint64Methods.ArrUint64Codec.Decode(r);
            var w = new JsonWriter();
            ArrUint64Methods.ArrUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrUint64.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ArrUint64.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrUint64 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ArrUint64.gron");
            var r = new GronReader(data);
            var obj = ArrUint64Methods.ArrUint64Codec.Decode(r);
            var w = new GronWriter();
            ArrUint64Methods.ArrUint64Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ArrUint64.gron")!);
            File.WriteAllBytes($"{outDir}/ArrUint64.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ArrUint64 gron: {e.Message}"); }
    }

    static void TestModelMultiArr1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr1.msgpack");
            var r = new MsgPackReader(data);
            var obj = MultiArr1Methods.MultiArr1Codec.Decode(r);
            var w = new MsgPackWriter();
            MultiArr1Methods.MultiArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr1.msgpack")!);
            File.WriteAllBytes($"{outDir}/MultiArr1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr1.json");
            var r = new JsonReader(data);
            var obj = MultiArr1Methods.MultiArr1Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr1Methods.MultiArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr1.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr1.unformatted.json");
            var r = new JsonReader(data);
            var obj = MultiArr1Methods.MultiArr1Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr1Methods.MultiArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr1.gron");
            var r = new GronReader(data);
            var obj = MultiArr1Methods.MultiArr1Codec.Decode(r);
            var w = new GronWriter();
            MultiArr1Methods.MultiArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr1.gron")!);
            File.WriteAllBytes($"{outDir}/MultiArr1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr1 gron: {e.Message}"); }
    }

    static void TestModelMultiArr2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr2.msgpack");
            var r = new MsgPackReader(data);
            var obj = MultiArr2Methods.MultiArr2Codec.Decode(r);
            var w = new MsgPackWriter();
            MultiArr2Methods.MultiArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr2.msgpack")!);
            File.WriteAllBytes($"{outDir}/MultiArr2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr2.json");
            var r = new JsonReader(data);
            var obj = MultiArr2Methods.MultiArr2Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr2Methods.MultiArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr2.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr2.unformatted.json");
            var r = new JsonReader(data);
            var obj = MultiArr2Methods.MultiArr2Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr2Methods.MultiArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr2.gron");
            var r = new GronReader(data);
            var obj = MultiArr2Methods.MultiArr2Codec.Decode(r);
            var w = new GronWriter();
            MultiArr2Methods.MultiArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr2.gron")!);
            File.WriteAllBytes($"{outDir}/MultiArr2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr2 gron: {e.Message}"); }
    }

    static void TestModelMultiArr3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr3.msgpack");
            var r = new MsgPackReader(data);
            var obj = MultiArr3Methods.MultiArr3Codec.Decode(r);
            var w = new MsgPackWriter();
            MultiArr3Methods.MultiArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr3.msgpack")!);
            File.WriteAllBytes($"{outDir}/MultiArr3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr3.json");
            var r = new JsonReader(data);
            var obj = MultiArr3Methods.MultiArr3Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr3Methods.MultiArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr3.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr3.unformatted.json");
            var r = new JsonReader(data);
            var obj = MultiArr3Methods.MultiArr3Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr3Methods.MultiArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr3.gron");
            var r = new GronReader(data);
            var obj = MultiArr3Methods.MultiArr3Codec.Decode(r);
            var w = new GronWriter();
            MultiArr3Methods.MultiArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr3.gron")!);
            File.WriteAllBytes($"{outDir}/MultiArr3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr3 gron: {e.Message}"); }
    }

    static void TestModelMultiArr4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr4.msgpack");
            var r = new MsgPackReader(data);
            var obj = MultiArr4Methods.MultiArr4Codec.Decode(r);
            var w = new MsgPackWriter();
            MultiArr4Methods.MultiArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr4.msgpack")!);
            File.WriteAllBytes($"{outDir}/MultiArr4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr4.json");
            var r = new JsonReader(data);
            var obj = MultiArr4Methods.MultiArr4Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr4Methods.MultiArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr4.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr4.unformatted.json");
            var r = new JsonReader(data);
            var obj = MultiArr4Methods.MultiArr4Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr4Methods.MultiArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr4.gron");
            var r = new GronReader(data);
            var obj = MultiArr4Methods.MultiArr4Codec.Decode(r);
            var w = new GronWriter();
            MultiArr4Methods.MultiArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr4.gron")!);
            File.WriteAllBytes($"{outDir}/MultiArr4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr4 gron: {e.Message}"); }
    }

    static void TestModelMultiArr5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr5.msgpack");
            var r = new MsgPackReader(data);
            var obj = MultiArr5Methods.MultiArr5Codec.Decode(r);
            var w = new MsgPackWriter();
            MultiArr5Methods.MultiArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr5.msgpack")!);
            File.WriteAllBytes($"{outDir}/MultiArr5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr5.json");
            var r = new JsonReader(data);
            var obj = MultiArr5Methods.MultiArr5Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr5Methods.MultiArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr5.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr5.unformatted.json");
            var r = new JsonReader(data);
            var obj = MultiArr5Methods.MultiArr5Codec.Decode(r);
            var w = new JsonWriter();
            MultiArr5Methods.MultiArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MultiArr5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MultiArr5.gron");
            var r = new GronReader(data);
            var obj = MultiArr5Methods.MultiArr5Codec.Decode(r);
            var w = new GronWriter();
            MultiArr5Methods.MultiArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MultiArr5.gron")!);
            File.WriteAllBytes($"{outDir}/MultiArr5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MultiArr5 gron: {e.Message}"); }
    }

    static void TestModelOptCombo1(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo1.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo1Methods.OptCombo1Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo1Methods.OptCombo1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo1.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo1.json");
            var r = new JsonReader(data);
            var obj = OptCombo1Methods.OptCombo1Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo1Methods.OptCombo1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo1.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo1.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo1Methods.OptCombo1Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo1Methods.OptCombo1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo1.gron");
            var r = new GronReader(data);
            var obj = OptCombo1Methods.OptCombo1Codec.Decode(r);
            var w = new GronWriter();
            OptCombo1Methods.OptCombo1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo1.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo1 gron: {e.Message}"); }
    }

    static void TestModelOptCombo2(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo2.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo2Methods.OptCombo2Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo2Methods.OptCombo2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo2.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo2.json");
            var r = new JsonReader(data);
            var obj = OptCombo2Methods.OptCombo2Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo2Methods.OptCombo2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo2.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo2.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo2Methods.OptCombo2Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo2Methods.OptCombo2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo2.gron");
            var r = new GronReader(data);
            var obj = OptCombo2Methods.OptCombo2Codec.Decode(r);
            var w = new GronWriter();
            OptCombo2Methods.OptCombo2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo2.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo2 gron: {e.Message}"); }
    }

    static void TestModelOptCombo3(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo3.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo3Methods.OptCombo3Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo3Methods.OptCombo3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo3.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo3.json");
            var r = new JsonReader(data);
            var obj = OptCombo3Methods.OptCombo3Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo3Methods.OptCombo3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo3.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo3.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo3Methods.OptCombo3Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo3Methods.OptCombo3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo3.gron");
            var r = new GronReader(data);
            var obj = OptCombo3Methods.OptCombo3Codec.Decode(r);
            var w = new GronWriter();
            OptCombo3Methods.OptCombo3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo3.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo3 gron: {e.Message}"); }
    }

    static void TestModelOptCombo4(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo4.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo4Methods.OptCombo4Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo4Methods.OptCombo4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo4.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo4.json");
            var r = new JsonReader(data);
            var obj = OptCombo4Methods.OptCombo4Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo4Methods.OptCombo4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo4.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo4.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo4Methods.OptCombo4Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo4Methods.OptCombo4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo4.gron");
            var r = new GronReader(data);
            var obj = OptCombo4Methods.OptCombo4Codec.Decode(r);
            var w = new GronWriter();
            OptCombo4Methods.OptCombo4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo4.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo4 gron: {e.Message}"); }
    }

    static void TestModelOptCombo5(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo5.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo5Methods.OptCombo5Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo5Methods.OptCombo5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo5.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo5.json");
            var r = new JsonReader(data);
            var obj = OptCombo5Methods.OptCombo5Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo5Methods.OptCombo5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo5.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo5.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo5Methods.OptCombo5Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo5Methods.OptCombo5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo5.gron");
            var r = new GronReader(data);
            var obj = OptCombo5Methods.OptCombo5Codec.Decode(r);
            var w = new GronWriter();
            OptCombo5Methods.OptCombo5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo5.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo5 gron: {e.Message}"); }
    }

    static void TestModelOptCombo6(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo6.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo6Methods.OptCombo6Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo6Methods.OptCombo6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo6.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo6.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo6 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo6.json");
            var r = new JsonReader(data);
            var obj = OptCombo6Methods.OptCombo6Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo6Methods.OptCombo6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo6.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo6.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo6 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo6.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo6Methods.OptCombo6Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo6Methods.OptCombo6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo6.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo6.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo6 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo6.gron");
            var r = new GronReader(data);
            var obj = OptCombo6Methods.OptCombo6Codec.Decode(r);
            var w = new GronWriter();
            OptCombo6Methods.OptCombo6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo6.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo6.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo6 gron: {e.Message}"); }
    }

    static void TestModelOptCombo7(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo7.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo7Methods.OptCombo7Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo7Methods.OptCombo7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo7.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo7.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo7 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo7.json");
            var r = new JsonReader(data);
            var obj = OptCombo7Methods.OptCombo7Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo7Methods.OptCombo7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo7.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo7.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo7 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo7.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo7Methods.OptCombo7Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo7Methods.OptCombo7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo7.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo7.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo7 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo7.gron");
            var r = new GronReader(data);
            var obj = OptCombo7Methods.OptCombo7Codec.Decode(r);
            var w = new GronWriter();
            OptCombo7Methods.OptCombo7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo7.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo7.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo7 gron: {e.Message}"); }
    }

    static void TestModelOptCombo8(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo8.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo8Methods.OptCombo8Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo8Methods.OptCombo8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo8.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo8.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo8 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo8.json");
            var r = new JsonReader(data);
            var obj = OptCombo8Methods.OptCombo8Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo8Methods.OptCombo8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo8.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo8.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo8 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo8.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo8Methods.OptCombo8Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo8Methods.OptCombo8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo8.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo8.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo8 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo8.gron");
            var r = new GronReader(data);
            var obj = OptCombo8Methods.OptCombo8Codec.Decode(r);
            var w = new GronWriter();
            OptCombo8Methods.OptCombo8Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo8.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo8.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo8 gron: {e.Message}"); }
    }

    static void TestModelOptCombo9(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo9.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo9Methods.OptCombo9Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo9Methods.OptCombo9Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo9.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo9.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo9 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo9.json");
            var r = new JsonReader(data);
            var obj = OptCombo9Methods.OptCombo9Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo9Methods.OptCombo9Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo9.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo9.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo9 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo9.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo9Methods.OptCombo9Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo9Methods.OptCombo9Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo9.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo9.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo9 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo9.gron");
            var r = new GronReader(data);
            var obj = OptCombo9Methods.OptCombo9Codec.Decode(r);
            var w = new GronWriter();
            OptCombo9Methods.OptCombo9Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo9.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo9.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo9 gron: {e.Message}"); }
    }

    static void TestModelOptCombo10(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo10.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptCombo10Methods.OptCombo10Codec.Decode(r);
            var w = new MsgPackWriter();
            OptCombo10Methods.OptCombo10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo10.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptCombo10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo10.json");
            var r = new JsonReader(data);
            var obj = OptCombo10Methods.OptCombo10Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo10Methods.OptCombo10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo10.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo10.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptCombo10Methods.OptCombo10Codec.Decode(r);
            var w = new JsonWriter();
            OptCombo10Methods.OptCombo10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptCombo10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptCombo10.gron");
            var r = new GronReader(data);
            var obj = OptCombo10Methods.OptCombo10Codec.Decode(r);
            var w = new GronWriter();
            OptCombo10Methods.OptCombo10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptCombo10.gron")!);
            File.WriteAllBytes($"{outDir}/OptCombo10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptCombo10 gron: {e.Message}"); }
    }

}
