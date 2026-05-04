using Specodec;
using Alltypes;
using System;
using System.IO;

var vecDir = Environment.GetEnvironmentVariable("VEC_DIR") ?? throw new Exception("VEC_DIR not set");
var outDir = Environment.GetEnvironmentVariable("OUT_DIR") ?? throw new Exception("OUT_DIR not set");

int passed = 0;
int failed = 0;


    void TestScalarInt8_min(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int8_min.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int8_min.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int8_min.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int8_min mp: {e.Message}"); }
    }

    void TestScalarInt8_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int8_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int8_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int8_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int8_max mp: {e.Message}"); }
    }

    void TestScalarInt16_min(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int16_min.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int16_min.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int16_min.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int16_min mp: {e.Message}"); }
    }

    void TestScalarInt16_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int16_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int16_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int16_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int16_max mp: {e.Message}"); }
    }

    void TestScalarInt32_min(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int32_min.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int32_min.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int32_min.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int32_min mp: {e.Message}"); }
    }

    void TestScalarInt32_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int32_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt32();
            var w = new MsgPackWriter();
            w.WriteInt32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int32_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int32_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int32_max mp: {e.Message}"); }
    }

    void TestScalarInt64_min(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int64_min.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt64();
            var w = new MsgPackWriter();
            w.WriteInt64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int64_min.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int64_min.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int64_min mp: {e.Message}"); }
    }

    void TestScalarInt64_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/int64_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadInt64();
            var w = new MsgPackWriter();
            w.WriteInt64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/int64_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/int64_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL int64_max mp: {e.Message}"); }
    }

    void TestScalarUint8_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/uint8_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadUint32();
            var w = new MsgPackWriter();
            w.WriteUint32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/uint8_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/uint8_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL uint8_max mp: {e.Message}"); }
    }

    void TestScalarUint16_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/uint16_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadUint32();
            var w = new MsgPackWriter();
            w.WriteUint32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/uint16_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/uint16_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL uint16_max mp: {e.Message}"); }
    }

    void TestScalarUint32_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/uint32_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadUint32();
            var w = new MsgPackWriter();
            w.WriteUint32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/uint32_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/uint32_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL uint32_max mp: {e.Message}"); }
    }

    void TestScalarUint64_max(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/uint64_max.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadUint64();
            var w = new MsgPackWriter();
            w.WriteUint64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/uint64_max.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/uint64_max.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL uint64_max mp: {e.Message}"); }
    }

    void TestScalarFloat32_1_5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float32_1.5.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat32();
            var w = new MsgPackWriter();
            w.WriteFloat32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float32_1.5.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float32_1.5.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float32_1.5 mp: {e.Message}"); }
    }

    void TestScalarFloat32_neg_zero(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float32_neg_zero.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat32();
            var w = new MsgPackWriter();
            w.WriteFloat32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float32_neg_zero.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float32_neg_zero.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float32_neg_zero mp: {e.Message}"); }
    }

    void TestScalarFloat32_inf(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float32_inf.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat32();
            var w = new MsgPackWriter();
            w.WriteFloat32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float32_inf.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float32_inf.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float32_inf mp: {e.Message}"); }
    }

    void TestScalarFloat32_neg_inf(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float32_neg_inf.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat32();
            var w = new MsgPackWriter();
            w.WriteFloat32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float32_neg_inf.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float32_neg_inf.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float32_neg_inf mp: {e.Message}"); }
    }

    void TestScalarFloat32_nan(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float32_nan.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat32();
            var w = new MsgPackWriter();
            w.WriteFloat32(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float32_nan.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float32_nan.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float32_nan mp: {e.Message}"); }
    }

    void TestScalarFloat64_pi(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float64_pi.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat64();
            var w = new MsgPackWriter();
            w.WriteFloat64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float64_pi.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float64_pi.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float64_pi mp: {e.Message}"); }
    }

    void TestScalarFloat64_neg_zero(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float64_neg_zero.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat64();
            var w = new MsgPackWriter();
            w.WriteFloat64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float64_neg_zero.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float64_neg_zero.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float64_neg_zero mp: {e.Message}"); }
    }

    void TestScalarFloat64_inf(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float64_inf.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat64();
            var w = new MsgPackWriter();
            w.WriteFloat64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float64_inf.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float64_inf.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float64_inf mp: {e.Message}"); }
    }

    void TestScalarFloat64_neg_inf(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float64_neg_inf.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat64();
            var w = new MsgPackWriter();
            w.WriteFloat64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float64_neg_inf.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float64_neg_inf.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float64_neg_inf mp: {e.Message}"); }
    }

    void TestScalarFloat64_nan(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/float64_nan.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadFloat64();
            var w = new MsgPackWriter();
            w.WriteFloat64(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/float64_nan.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/float64_nan.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL float64_nan mp: {e.Message}"); }
    }

    void TestScalarStr_empty(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_empty.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_empty.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_empty.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_empty mp: {e.Message}"); }
    }

    void TestScalarStr_ascii(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_ascii.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_ascii.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_ascii.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_ascii mp: {e.Message}"); }
    }

    void TestScalarStr_null_byte(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_null_byte.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_null_byte.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_null_byte.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_null_byte mp: {e.Message}"); }
    }

    void TestScalarStr_escape(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_escape.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_escape.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_escape.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_escape mp: {e.Message}"); }
    }

    void TestScalarStr_unicode(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_unicode.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_unicode.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_unicode.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_unicode mp: {e.Message}"); }
    }

    void TestScalarStr_31(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_31.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_31.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_31.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_31 mp: {e.Message}"); }
    }

    void TestScalarStr_32(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_32.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_32.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_32.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_32 mp: {e.Message}"); }
    }

    void TestScalarStr_255(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_255.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_255.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_255.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_255 mp: {e.Message}"); }
    }

    void TestScalarStr_256(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/str_256.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadString();
            var w = new MsgPackWriter();
            w.WriteString(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/str_256.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/str_256.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL str_256 mp: {e.Message}"); }
    }

    void TestScalarBytes_empty(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_empty.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_empty.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_empty.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_empty mp: {e.Message}"); }
    }

    void TestScalarBytes_small(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_small.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_small.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_small.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_small mp: {e.Message}"); }
    }

    void TestScalarBytes_31(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_31.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_31.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_31.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_31 mp: {e.Message}"); }
    }

    void TestScalarBytes_32(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_32.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_32.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_32.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_32 mp: {e.Message}"); }
    }

    void TestScalarBytes_255(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_255.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_255.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_255.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_255 mp: {e.Message}"); }
    }

    void TestScalarBytes_256(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_256.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_256.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_256.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_256 mp: {e.Message}"); }
    }

    void TestScalarBytes_zeros(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_zeros.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_zeros.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_zeros.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_zeros mp: {e.Message}"); }
    }

    void TestScalarBytes_ff(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bytes_ff.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBytes();
            var w = new MsgPackWriter();
            w.WriteBytes(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bytes_ff.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bytes_ff.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bytes_ff mp: {e.Message}"); }
    }

    void TestScalarBool_true(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bool_true.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBool();
            var w = new MsgPackWriter();
            w.WriteBool(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bool_true.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bool_true.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bool_true mp: {e.Message}"); }
    }

    void TestScalarBool_false(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/scalars/bool_false.mp");
            var r = new MsgPackReader(data);
            var value = r.ReadBool();
            var w = new MsgPackWriter();
            w.WriteBool(value);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/scalars/bool_false.mp")!);
            File.WriteAllBytes($"{outDir}/scalars/bool_false.mp", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL bool_false mp: {e.Message}"); }
    }


    void TestModelOptInner(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptInner.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptInnerMethods.OptInnerCodec.Decode(r);
            var w = new MsgPackWriter();
            OptInnerMethods.OptInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptInner.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptInner.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptInner mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptInner.json");
            var r = new JsonReader(data);
            var obj = OptInnerMethods.OptInnerCodec.Decode(r);
            var w = new JsonWriter();
            OptInnerMethods.OptInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptInner.json")!);
            File.WriteAllBytes($"{outDir}/OptInner.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptInner json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptInner.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptInnerMethods.OptInnerCodec.Decode(r);
            var w = new JsonWriter();
            OptInnerMethods.OptInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptInner.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptInner.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptInner unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptInner.gron");
            var r = new GronReader(data);
            var obj = OptInnerMethods.OptInnerCodec.Decode(r);
            var w = new GronWriter();
            OptInnerMethods.OptInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptInner.gron")!);
            File.WriteAllBytes($"{outDir}/OptInner.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptInner gron: {e.Message}"); }
    }

    void TestModelSingleString(ref int passed, ref int failed) {
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

    void TestModelSingleBoolean(ref int passed, ref int failed) {
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

    void TestModelSingleInt8(ref int passed, ref int failed) {
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

    void TestModelSingleInt16(ref int passed, ref int failed) {
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

    void TestModelSingleInt32(ref int passed, ref int failed) {
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

    void TestModelSingleInt64(ref int passed, ref int failed) {
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

    void TestModelSingleUint8(ref int passed, ref int failed) {
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

    void TestModelSingleUint16(ref int passed, ref int failed) {
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

    void TestModelSingleUint32(ref int passed, ref int failed) {
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

    void TestModelSingleUint64(ref int passed, ref int failed) {
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

    void TestModelSingleFloat32(ref int passed, ref int failed) {
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

    void TestModelSingleFloat64(ref int passed, ref int failed) {
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

    void TestModelSingleBytes(ref int passed, ref int failed) {
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

    void TestModelOptSingleString(ref int passed, ref int failed) {
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

    void TestModelOptSingleBoolean(ref int passed, ref int failed) {
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

    void TestModelOptSingleInt8(ref int passed, ref int failed) {
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

    void TestModelOptSingleInt16(ref int passed, ref int failed) {
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

    void TestModelOptSingleInt32(ref int passed, ref int failed) {
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

    void TestModelOptSingleInt64(ref int passed, ref int failed) {
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

    void TestModelOptSingleUint8(ref int passed, ref int failed) {
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

    void TestModelOptSingleUint16(ref int passed, ref int failed) {
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

    void TestModelOptSingleUint32(ref int passed, ref int failed) {
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

    void TestModelOptSingleUint64(ref int passed, ref int failed) {
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

    void TestModelOptSingleFloat32(ref int passed, ref int failed) {
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

    void TestModelOptSingleFloat64(ref int passed, ref int failed) {
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

    void TestModelOptSingleBytes(ref int passed, ref int failed) {
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

    void TestModelPairString(ref int passed, ref int failed) {
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

    void TestModelPairBoolean(ref int passed, ref int failed) {
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

    void TestModelPairInt8(ref int passed, ref int failed) {
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

    void TestModelPairInt16(ref int passed, ref int failed) {
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

    void TestModelPairInt32(ref int passed, ref int failed) {
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

    void TestModelPairInt64(ref int passed, ref int failed) {
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

    void TestModelPairUint8(ref int passed, ref int failed) {
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

    void TestModelPairUint16(ref int passed, ref int failed) {
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

    void TestModelPairUint32(ref int passed, ref int failed) {
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

    void TestModelPairUint64(ref int passed, ref int failed) {
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

    void TestModelPairFloat32(ref int passed, ref int failed) {
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

    void TestModelPairFloat64(ref int passed, ref int failed) {
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

    void TestModelPairBytes(ref int passed, ref int failed) {
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

    void TestModelDualStringInt32(ref int passed, ref int failed) {
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

    void TestModelDualStringBoolean(ref int passed, ref int failed) {
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

    void TestModelDualStringFloat64(ref int passed, ref int failed) {
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

    void TestModelDualStringBytes(ref int passed, ref int failed) {
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

    void TestModelDualInt32Boolean(ref int passed, ref int failed) {
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

    void TestModelDualInt32Float64(ref int passed, ref int failed) {
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

    void TestModelDualInt32Int64(ref int passed, ref int failed) {
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

    void TestModelDualInt32Uint32(ref int passed, ref int failed) {
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

    void TestModelDualInt64Uint64(ref int passed, ref int failed) {
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

    void TestModelDualFloat32Float64(ref int passed, ref int failed) {
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

    void TestModelDualFloat64Boolean(ref int passed, ref int failed) {
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

    void TestModelDualFloat64Bytes(ref int passed, ref int failed) {
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

    void TestModelDualUint32Uint64(ref int passed, ref int failed) {
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

    void TestModelDualBooleanBytes(ref int passed, ref int failed) {
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

    void TestModelDualInt8Uint8(ref int passed, ref int failed) {
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

    void TestModelDualInt16Uint16(ref int passed, ref int failed) {
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

    void TestModelDualStringInt64(ref int passed, ref int failed) {
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

    void TestModelDualStringUint64(ref int passed, ref int failed) {
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

    void TestModelDualInt32Bytes(ref int passed, ref int failed) {
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

    void TestModelDualFloat64Int32(ref int passed, ref int failed) {
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

    void TestModelDualBooleanInt32(ref int passed, ref int failed) {
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

    void TestModelDualBytesInt64(ref int passed, ref int failed) {
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

    void TestModelDualInt8Float32(ref int passed, ref int failed) {
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

    void TestModelDualUint8Int16(ref int passed, ref int failed) {
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

    void TestModelDualInt64Float64(ref int passed, ref int failed) {
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

    void TestModelDualUint64String(ref int passed, ref int failed) {
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

    void TestModelTriple01(ref int passed, ref int failed) {
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

    void TestModelTriple02(ref int passed, ref int failed) {
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

    void TestModelTriple03(ref int passed, ref int failed) {
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

    void TestModelTriple04(ref int passed, ref int failed) {
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

    void TestModelTriple05(ref int passed, ref int failed) {
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

    void TestModelTriple06(ref int passed, ref int failed) {
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

    void TestModelTriple07(ref int passed, ref int failed) {
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

    void TestModelTriple08(ref int passed, ref int failed) {
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

    void TestModelTriple09(ref int passed, ref int failed) {
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

    void TestModelTriple10(ref int passed, ref int failed) {
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

    void TestModelTriple11(ref int passed, ref int failed) {
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

    void TestModelTriple12(ref int passed, ref int failed) {
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

    void TestModelTriple13(ref int passed, ref int failed) {
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

    void TestModelTriple14(ref int passed, ref int failed) {
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

    void TestModelTriple15(ref int passed, ref int failed) {
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

    void TestModelFive01(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new MsgPackWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.json");
            var r = new JsonReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new JsonWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.json")!);
            File.WriteAllBytes($"{outDir}/Five01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new JsonWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five01.gron");
            var r = new GronReader(data);
            var obj = Five01Methods.Five01Codec.Decode(r);
            var w = new GronWriter();
            Five01Methods.Five01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five01.gron")!);
            File.WriteAllBytes($"{outDir}/Five01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five01 gron: {e.Message}"); }
    }

    void TestModelFive02(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new MsgPackWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.json");
            var r = new JsonReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new JsonWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.json")!);
            File.WriteAllBytes($"{outDir}/Five02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new JsonWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five02.gron");
            var r = new GronReader(data);
            var obj = Five02Methods.Five02Codec.Decode(r);
            var w = new GronWriter();
            Five02Methods.Five02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five02.gron")!);
            File.WriteAllBytes($"{outDir}/Five02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five02 gron: {e.Message}"); }
    }

    void TestModelFive03(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new MsgPackWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.json");
            var r = new JsonReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new JsonWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.json")!);
            File.WriteAllBytes($"{outDir}/Five03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new JsonWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five03.gron");
            var r = new GronReader(data);
            var obj = Five03Methods.Five03Codec.Decode(r);
            var w = new GronWriter();
            Five03Methods.Five03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five03.gron")!);
            File.WriteAllBytes($"{outDir}/Five03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five03 gron: {e.Message}"); }
    }

    void TestModelFive04(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new MsgPackWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.json");
            var r = new JsonReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new JsonWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.json")!);
            File.WriteAllBytes($"{outDir}/Five04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new JsonWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five04.gron");
            var r = new GronReader(data);
            var obj = Five04Methods.Five04Codec.Decode(r);
            var w = new GronWriter();
            Five04Methods.Five04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five04.gron")!);
            File.WriteAllBytes($"{outDir}/Five04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five04 gron: {e.Message}"); }
    }

    void TestModelFive05(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new MsgPackWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.json");
            var r = new JsonReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new JsonWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.json")!);
            File.WriteAllBytes($"{outDir}/Five05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new JsonWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five05.gron");
            var r = new GronReader(data);
            var obj = Five05Methods.Five05Codec.Decode(r);
            var w = new GronWriter();
            Five05Methods.Five05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five05.gron")!);
            File.WriteAllBytes($"{outDir}/Five05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five05 gron: {e.Message}"); }
    }

    void TestModelFive06(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new MsgPackWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five06.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.json");
            var r = new JsonReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new JsonWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.json")!);
            File.WriteAllBytes($"{outDir}/Five06.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new JsonWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five06.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five06.gron");
            var r = new GronReader(data);
            var obj = Five06Methods.Five06Codec.Decode(r);
            var w = new GronWriter();
            Five06Methods.Five06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five06.gron")!);
            File.WriteAllBytes($"{outDir}/Five06.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five06 gron: {e.Message}"); }
    }

    void TestModelFive07(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new MsgPackWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five07.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.json");
            var r = new JsonReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new JsonWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.json")!);
            File.WriteAllBytes($"{outDir}/Five07.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new JsonWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five07.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five07.gron");
            var r = new GronReader(data);
            var obj = Five07Methods.Five07Codec.Decode(r);
            var w = new GronWriter();
            Five07Methods.Five07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five07.gron")!);
            File.WriteAllBytes($"{outDir}/Five07.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five07 gron: {e.Message}"); }
    }

    void TestModelFive08(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new MsgPackWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five08.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.json");
            var r = new JsonReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new JsonWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.json")!);
            File.WriteAllBytes($"{outDir}/Five08.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new JsonWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five08.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five08.gron");
            var r = new GronReader(data);
            var obj = Five08Methods.Five08Codec.Decode(r);
            var w = new GronWriter();
            Five08Methods.Five08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five08.gron")!);
            File.WriteAllBytes($"{outDir}/Five08.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five08 gron: {e.Message}"); }
    }

    void TestModelFive09(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new MsgPackWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five09.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.json");
            var r = new JsonReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new JsonWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.json")!);
            File.WriteAllBytes($"{outDir}/Five09.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new JsonWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five09.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five09.gron");
            var r = new GronReader(data);
            var obj = Five09Methods.Five09Codec.Decode(r);
            var w = new GronWriter();
            Five09Methods.Five09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five09.gron")!);
            File.WriteAllBytes($"{outDir}/Five09.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five09 gron: {e.Message}"); }
    }

    void TestModelFive10(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.msgpack");
            var r = new MsgPackReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new MsgPackWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.msgpack")!);
            File.WriteAllBytes($"{outDir}/Five10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.json");
            var r = new JsonReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new JsonWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.json")!);
            File.WriteAllBytes($"{outDir}/Five10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.unformatted.json");
            var r = new JsonReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new JsonWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Five10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Five10.gron");
            var r = new GronReader(data);
            var obj = Five10Methods.Five10Codec.Decode(r);
            var w = new GronWriter();
            Five10Methods.Five10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Five10.gron")!);
            File.WriteAllBytes($"{outDir}/Five10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Five10 gron: {e.Message}"); }
    }

    void TestModelTen01(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.json");
            var r = new JsonReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new JsonWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.json")!);
            File.WriteAllBytes($"{outDir}/Ten01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new JsonWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten01.gron");
            var r = new GronReader(data);
            var obj = Ten01Methods.Ten01Codec.Decode(r);
            var w = new GronWriter();
            Ten01Methods.Ten01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten01.gron")!);
            File.WriteAllBytes($"{outDir}/Ten01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten01 gron: {e.Message}"); }
    }

    void TestModelTen02(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.json");
            var r = new JsonReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new JsonWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.json")!);
            File.WriteAllBytes($"{outDir}/Ten02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new JsonWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten02.gron");
            var r = new GronReader(data);
            var obj = Ten02Methods.Ten02Codec.Decode(r);
            var w = new GronWriter();
            Ten02Methods.Ten02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten02.gron")!);
            File.WriteAllBytes($"{outDir}/Ten02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten02 gron: {e.Message}"); }
    }

    void TestModelTen03(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.json");
            var r = new JsonReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new JsonWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.json")!);
            File.WriteAllBytes($"{outDir}/Ten03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new JsonWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten03.gron");
            var r = new GronReader(data);
            var obj = Ten03Methods.Ten03Codec.Decode(r);
            var w = new GronWriter();
            Ten03Methods.Ten03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten03.gron")!);
            File.WriteAllBytes($"{outDir}/Ten03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten03 gron: {e.Message}"); }
    }

    void TestModelTen04(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.json");
            var r = new JsonReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new JsonWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.json")!);
            File.WriteAllBytes($"{outDir}/Ten04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new JsonWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten04.gron");
            var r = new GronReader(data);
            var obj = Ten04Methods.Ten04Codec.Decode(r);
            var w = new GronWriter();
            Ten04Methods.Ten04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten04.gron")!);
            File.WriteAllBytes($"{outDir}/Ten04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten04 gron: {e.Message}"); }
    }

    void TestModelTen05(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new MsgPackWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ten05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.json");
            var r = new JsonReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new JsonWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.json")!);
            File.WriteAllBytes($"{outDir}/Ten05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new JsonWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ten05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ten05.gron");
            var r = new GronReader(data);
            var obj = Ten05Methods.Ten05Codec.Decode(r);
            var w = new GronWriter();
            Ten05Methods.Ten05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ten05.gron")!);
            File.WriteAllBytes($"{outDir}/Ten05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ten05 gron: {e.Message}"); }
    }

    void TestModelArrString(ref int passed, ref int failed) {
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

    void TestModelArrInt32(ref int passed, ref int failed) {
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

    void TestModelArrBoolean(ref int passed, ref int failed) {
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

    void TestModelArrFloat64(ref int passed, ref int failed) {
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

    void TestModelArrBytes(ref int passed, ref int failed) {
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

    void TestModelArrInt64(ref int passed, ref int failed) {
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

    void TestModelArrUint64(ref int passed, ref int failed) {
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

    void TestModelMultiArr1(ref int passed, ref int failed) {
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

    void TestModelMultiArr2(ref int passed, ref int failed) {
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

    void TestModelMultiArr3(ref int passed, ref int failed) {
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

    void TestModelMultiArr4(ref int passed, ref int failed) {
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

    void TestModelMultiArr5(ref int passed, ref int failed) {
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

    void TestModelOptCombo1(ref int passed, ref int failed) {
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

    void TestModelOptCombo2(ref int passed, ref int failed) {
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

    void TestModelOptCombo3(ref int passed, ref int failed) {
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

    void TestModelOptCombo4(ref int passed, ref int failed) {
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

    void TestModelOptCombo5(ref int passed, ref int failed) {
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

    void TestModelOptCombo6(ref int passed, ref int failed) {
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

    void TestModelOptCombo7(ref int passed, ref int failed) {
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

    void TestModelOptCombo8(ref int passed, ref int failed) {
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

    void TestModelOptCombo9(ref int passed, ref int failed) {
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

    void TestModelOptCombo10(ref int passed, ref int failed) {
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

    void TestModelNestInner(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestInner.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestInnerMethods.NestInnerCodec.Decode(r);
            var w = new MsgPackWriter();
            NestInnerMethods.NestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestInner.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestInner.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestInner mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestInner.json");
            var r = new JsonReader(data);
            var obj = NestInnerMethods.NestInnerCodec.Decode(r);
            var w = new JsonWriter();
            NestInnerMethods.NestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestInner.json")!);
            File.WriteAllBytes($"{outDir}/NestInner.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestInner json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestInner.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestInnerMethods.NestInnerCodec.Decode(r);
            var w = new JsonWriter();
            NestInnerMethods.NestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestInner.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestInner.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestInner unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestInner.gron");
            var r = new GronReader(data);
            var obj = NestInnerMethods.NestInnerCodec.Decode(r);
            var w = new GronWriter();
            NestInnerMethods.NestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestInner.gron")!);
            File.WriteAllBytes($"{outDir}/NestInner.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestInner gron: {e.Message}"); }
    }

    void TestModelNestCoord(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestCoord.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestCoordMethods.NestCoordCodec.Decode(r);
            var w = new MsgPackWriter();
            NestCoordMethods.NestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestCoord.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestCoord.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestCoord mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestCoord.json");
            var r = new JsonReader(data);
            var obj = NestCoordMethods.NestCoordCodec.Decode(r);
            var w = new JsonWriter();
            NestCoordMethods.NestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestCoord.json")!);
            File.WriteAllBytes($"{outDir}/NestCoord.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestCoord json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestCoord.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestCoordMethods.NestCoordCodec.Decode(r);
            var w = new JsonWriter();
            NestCoordMethods.NestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestCoord.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestCoord.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestCoord unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestCoord.gron");
            var r = new GronReader(data);
            var obj = NestCoordMethods.NestCoordCodec.Decode(r);
            var w = new GronWriter();
            NestCoordMethods.NestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestCoord.gron")!);
            File.WriteAllBytes($"{outDir}/NestCoord.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestCoord gron: {e.Message}"); }
    }

    void TestModelNestIdVal(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestIdVal.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestIdValMethods.NestIdValCodec.Decode(r);
            var w = new MsgPackWriter();
            NestIdValMethods.NestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestIdVal.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestIdVal.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestIdVal mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestIdVal.json");
            var r = new JsonReader(data);
            var obj = NestIdValMethods.NestIdValCodec.Decode(r);
            var w = new JsonWriter();
            NestIdValMethods.NestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestIdVal.json")!);
            File.WriteAllBytes($"{outDir}/NestIdVal.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestIdVal json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestIdVal.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestIdValMethods.NestIdValCodec.Decode(r);
            var w = new JsonWriter();
            NestIdValMethods.NestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestIdVal.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestIdVal.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestIdVal unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestIdVal.gron");
            var r = new GronReader(data);
            var obj = NestIdValMethods.NestIdValCodec.Decode(r);
            var w = new GronWriter();
            NestIdValMethods.NestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestIdVal.gron")!);
            File.WriteAllBytes($"{outDir}/NestIdVal.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestIdVal gron: {e.Message}"); }
    }

    void TestModelNestLabel(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestLabel.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestLabelMethods.NestLabelCodec.Decode(r);
            var w = new MsgPackWriter();
            NestLabelMethods.NestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestLabel.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestLabel.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestLabel mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestLabel.json");
            var r = new JsonReader(data);
            var obj = NestLabelMethods.NestLabelCodec.Decode(r);
            var w = new JsonWriter();
            NestLabelMethods.NestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestLabel.json")!);
            File.WriteAllBytes($"{outDir}/NestLabel.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestLabel json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestLabel.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestLabelMethods.NestLabelCodec.Decode(r);
            var w = new JsonWriter();
            NestLabelMethods.NestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestLabel.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestLabel.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestLabel unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestLabel.gron");
            var r = new GronReader(data);
            var obj = NestLabelMethods.NestLabelCodec.Decode(r);
            var w = new GronWriter();
            NestLabelMethods.NestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestLabel.gron")!);
            File.WriteAllBytes($"{outDir}/NestLabel.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestLabel gron: {e.Message}"); }
    }

    void TestModelNestMoney(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestMoney.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestMoneyMethods.NestMoneyCodec.Decode(r);
            var w = new MsgPackWriter();
            NestMoneyMethods.NestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestMoney.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestMoney.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestMoney mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestMoney.json");
            var r = new JsonReader(data);
            var obj = NestMoneyMethods.NestMoneyCodec.Decode(r);
            var w = new JsonWriter();
            NestMoneyMethods.NestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestMoney.json")!);
            File.WriteAllBytes($"{outDir}/NestMoney.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestMoney json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestMoney.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestMoneyMethods.NestMoneyCodec.Decode(r);
            var w = new JsonWriter();
            NestMoneyMethods.NestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestMoney.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestMoney.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestMoney unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestMoney.gron");
            var r = new GronReader(data);
            var obj = NestMoneyMethods.NestMoneyCodec.Decode(r);
            var w = new GronWriter();
            NestMoneyMethods.NestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestMoney.gron")!);
            File.WriteAllBytes($"{outDir}/NestMoney.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestMoney gron: {e.Message}"); }
    }

    void TestModelNestRange32(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestRange32.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestRange32Methods.NestRange32Codec.Decode(r);
            var w = new MsgPackWriter();
            NestRange32Methods.NestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestRange32.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestRange32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestRange32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestRange32.json");
            var r = new JsonReader(data);
            var obj = NestRange32Methods.NestRange32Codec.Decode(r);
            var w = new JsonWriter();
            NestRange32Methods.NestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestRange32.json")!);
            File.WriteAllBytes($"{outDir}/NestRange32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestRange32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestRange32.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestRange32Methods.NestRange32Codec.Decode(r);
            var w = new JsonWriter();
            NestRange32Methods.NestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestRange32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestRange32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestRange32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestRange32.gron");
            var r = new GronReader(data);
            var obj = NestRange32Methods.NestRange32Codec.Decode(r);
            var w = new GronWriter();
            NestRange32Methods.NestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestRange32.gron")!);
            File.WriteAllBytes($"{outDir}/NestRange32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestRange32 gron: {e.Message}"); }
    }

    void TestModelNestAddr(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestAddr.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestAddrMethods.NestAddrCodec.Decode(r);
            var w = new MsgPackWriter();
            NestAddrMethods.NestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestAddr.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestAddr.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestAddr mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestAddr.json");
            var r = new JsonReader(data);
            var obj = NestAddrMethods.NestAddrCodec.Decode(r);
            var w = new JsonWriter();
            NestAddrMethods.NestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestAddr.json")!);
            File.WriteAllBytes($"{outDir}/NestAddr.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestAddr json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestAddr.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestAddrMethods.NestAddrCodec.Decode(r);
            var w = new JsonWriter();
            NestAddrMethods.NestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestAddr.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestAddr.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestAddr unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestAddr.gron");
            var r = new GronReader(data);
            var obj = NestAddrMethods.NestAddrCodec.Decode(r);
            var w = new GronWriter();
            NestAddrMethods.NestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestAddr.gron")!);
            File.WriteAllBytes($"{outDir}/NestAddr.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestAddr gron: {e.Message}"); }
    }

    void TestModelNestPoint3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestPoint3.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestPoint3Methods.NestPoint3Codec.Decode(r);
            var w = new MsgPackWriter();
            NestPoint3Methods.NestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestPoint3.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestPoint3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestPoint3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestPoint3.json");
            var r = new JsonReader(data);
            var obj = NestPoint3Methods.NestPoint3Codec.Decode(r);
            var w = new JsonWriter();
            NestPoint3Methods.NestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestPoint3.json")!);
            File.WriteAllBytes($"{outDir}/NestPoint3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestPoint3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestPoint3.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestPoint3Methods.NestPoint3Codec.Decode(r);
            var w = new JsonWriter();
            NestPoint3Methods.NestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestPoint3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestPoint3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestPoint3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestPoint3.gron");
            var r = new GronReader(data);
            var obj = NestPoint3Methods.NestPoint3Codec.Decode(r);
            var w = new GronWriter();
            NestPoint3Methods.NestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestPoint3.gron")!);
            File.WriteAllBytes($"{outDir}/NestPoint3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestPoint3 gron: {e.Message}"); }
    }

    void TestModelOptNestInner(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestInner.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestInnerMethods.OptNestInnerCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestInnerMethods.OptNestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestInner.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestInner.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestInner mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestInner.json");
            var r = new JsonReader(data);
            var obj = OptNestInnerMethods.OptNestInnerCodec.Decode(r);
            var w = new JsonWriter();
            OptNestInnerMethods.OptNestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestInner.json")!);
            File.WriteAllBytes($"{outDir}/OptNestInner.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestInner json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestInner.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestInnerMethods.OptNestInnerCodec.Decode(r);
            var w = new JsonWriter();
            OptNestInnerMethods.OptNestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestInner.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestInner.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestInner unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestInner.gron");
            var r = new GronReader(data);
            var obj = OptNestInnerMethods.OptNestInnerCodec.Decode(r);
            var w = new GronWriter();
            OptNestInnerMethods.OptNestInnerCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestInner.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestInner.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestInner gron: {e.Message}"); }
    }

    void TestModelOptNestCoord(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestCoord.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestCoordMethods.OptNestCoordCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestCoordMethods.OptNestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestCoord.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestCoord.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestCoord mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestCoord.json");
            var r = new JsonReader(data);
            var obj = OptNestCoordMethods.OptNestCoordCodec.Decode(r);
            var w = new JsonWriter();
            OptNestCoordMethods.OptNestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestCoord.json")!);
            File.WriteAllBytes($"{outDir}/OptNestCoord.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestCoord json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestCoord.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestCoordMethods.OptNestCoordCodec.Decode(r);
            var w = new JsonWriter();
            OptNestCoordMethods.OptNestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestCoord.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestCoord.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestCoord unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestCoord.gron");
            var r = new GronReader(data);
            var obj = OptNestCoordMethods.OptNestCoordCodec.Decode(r);
            var w = new GronWriter();
            OptNestCoordMethods.OptNestCoordCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestCoord.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestCoord.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestCoord gron: {e.Message}"); }
    }

    void TestModelOptNestIdVal(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestIdVal.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestIdValMethods.OptNestIdValCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestIdValMethods.OptNestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestIdVal.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestIdVal.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestIdVal mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestIdVal.json");
            var r = new JsonReader(data);
            var obj = OptNestIdValMethods.OptNestIdValCodec.Decode(r);
            var w = new JsonWriter();
            OptNestIdValMethods.OptNestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestIdVal.json")!);
            File.WriteAllBytes($"{outDir}/OptNestIdVal.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestIdVal json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestIdVal.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestIdValMethods.OptNestIdValCodec.Decode(r);
            var w = new JsonWriter();
            OptNestIdValMethods.OptNestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestIdVal.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestIdVal.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestIdVal unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestIdVal.gron");
            var r = new GronReader(data);
            var obj = OptNestIdValMethods.OptNestIdValCodec.Decode(r);
            var w = new GronWriter();
            OptNestIdValMethods.OptNestIdValCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestIdVal.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestIdVal.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestIdVal gron: {e.Message}"); }
    }

    void TestModelOptNestLabel(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestLabel.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestLabelMethods.OptNestLabelCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestLabelMethods.OptNestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestLabel.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestLabel.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestLabel mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestLabel.json");
            var r = new JsonReader(data);
            var obj = OptNestLabelMethods.OptNestLabelCodec.Decode(r);
            var w = new JsonWriter();
            OptNestLabelMethods.OptNestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestLabel.json")!);
            File.WriteAllBytes($"{outDir}/OptNestLabel.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestLabel json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestLabel.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestLabelMethods.OptNestLabelCodec.Decode(r);
            var w = new JsonWriter();
            OptNestLabelMethods.OptNestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestLabel.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestLabel.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestLabel unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestLabel.gron");
            var r = new GronReader(data);
            var obj = OptNestLabelMethods.OptNestLabelCodec.Decode(r);
            var w = new GronWriter();
            OptNestLabelMethods.OptNestLabelCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestLabel.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestLabel.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestLabel gron: {e.Message}"); }
    }

    void TestModelOptNestMoney(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestMoney.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestMoneyMethods.OptNestMoneyCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestMoneyMethods.OptNestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestMoney.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestMoney.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestMoney mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestMoney.json");
            var r = new JsonReader(data);
            var obj = OptNestMoneyMethods.OptNestMoneyCodec.Decode(r);
            var w = new JsonWriter();
            OptNestMoneyMethods.OptNestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestMoney.json")!);
            File.WriteAllBytes($"{outDir}/OptNestMoney.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestMoney json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestMoney.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestMoneyMethods.OptNestMoneyCodec.Decode(r);
            var w = new JsonWriter();
            OptNestMoneyMethods.OptNestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestMoney.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestMoney.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestMoney unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestMoney.gron");
            var r = new GronReader(data);
            var obj = OptNestMoneyMethods.OptNestMoneyCodec.Decode(r);
            var w = new GronWriter();
            OptNestMoneyMethods.OptNestMoneyCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestMoney.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestMoney.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestMoney gron: {e.Message}"); }
    }

    void TestModelOptNestRange32(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestRange32.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestRange32Methods.OptNestRange32Codec.Decode(r);
            var w = new MsgPackWriter();
            OptNestRange32Methods.OptNestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestRange32.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestRange32.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestRange32 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestRange32.json");
            var r = new JsonReader(data);
            var obj = OptNestRange32Methods.OptNestRange32Codec.Decode(r);
            var w = new JsonWriter();
            OptNestRange32Methods.OptNestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestRange32.json")!);
            File.WriteAllBytes($"{outDir}/OptNestRange32.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestRange32 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestRange32.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestRange32Methods.OptNestRange32Codec.Decode(r);
            var w = new JsonWriter();
            OptNestRange32Methods.OptNestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestRange32.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestRange32.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestRange32 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestRange32.gron");
            var r = new GronReader(data);
            var obj = OptNestRange32Methods.OptNestRange32Codec.Decode(r);
            var w = new GronWriter();
            OptNestRange32Methods.OptNestRange32Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestRange32.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestRange32.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestRange32 gron: {e.Message}"); }
    }

    void TestModelOptNestAddr(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestAddr.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestAddrMethods.OptNestAddrCodec.Decode(r);
            var w = new MsgPackWriter();
            OptNestAddrMethods.OptNestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestAddr.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestAddr.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestAddr mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestAddr.json");
            var r = new JsonReader(data);
            var obj = OptNestAddrMethods.OptNestAddrCodec.Decode(r);
            var w = new JsonWriter();
            OptNestAddrMethods.OptNestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestAddr.json")!);
            File.WriteAllBytes($"{outDir}/OptNestAddr.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestAddr json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestAddr.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestAddrMethods.OptNestAddrCodec.Decode(r);
            var w = new JsonWriter();
            OptNestAddrMethods.OptNestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestAddr.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestAddr.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestAddr unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestAddr.gron");
            var r = new GronReader(data);
            var obj = OptNestAddrMethods.OptNestAddrCodec.Decode(r);
            var w = new GronWriter();
            OptNestAddrMethods.OptNestAddrCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestAddr.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestAddr.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestAddr gron: {e.Message}"); }
    }

    void TestModelOptNestPoint3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestPoint3.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptNestPoint3Methods.OptNestPoint3Codec.Decode(r);
            var w = new MsgPackWriter();
            OptNestPoint3Methods.OptNestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestPoint3.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptNestPoint3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestPoint3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestPoint3.json");
            var r = new JsonReader(data);
            var obj = OptNestPoint3Methods.OptNestPoint3Codec.Decode(r);
            var w = new JsonWriter();
            OptNestPoint3Methods.OptNestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestPoint3.json")!);
            File.WriteAllBytes($"{outDir}/OptNestPoint3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestPoint3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestPoint3.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptNestPoint3Methods.OptNestPoint3Codec.Decode(r);
            var w = new JsonWriter();
            OptNestPoint3Methods.OptNestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestPoint3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptNestPoint3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestPoint3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptNestPoint3.gron");
            var r = new GronReader(data);
            var obj = OptNestPoint3Methods.OptNestPoint3Codec.Decode(r);
            var w = new GronWriter();
            OptNestPoint3Methods.OptNestPoint3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptNestPoint3.gron")!);
            File.WriteAllBytes($"{outDir}/OptNestPoint3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptNestPoint3 gron: {e.Message}"); }
    }

    void TestModelModelArr1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.json");
            var r = new JsonReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr1.gron");
            var r = new GronReader(data);
            var obj = ModelArr1Methods.ModelArr1Codec.Decode(r);
            var w = new GronWriter();
            ModelArr1Methods.ModelArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr1.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr1 gron: {e.Message}"); }
    }

    void TestModelModelArr2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.json");
            var r = new JsonReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr2.gron");
            var r = new GronReader(data);
            var obj = ModelArr2Methods.ModelArr2Codec.Decode(r);
            var w = new GronWriter();
            ModelArr2Methods.ModelArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr2.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr2 gron: {e.Message}"); }
    }

    void TestModelModelArr3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.json");
            var r = new JsonReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr3.gron");
            var r = new GronReader(data);
            var obj = ModelArr3Methods.ModelArr3Codec.Decode(r);
            var w = new GronWriter();
            ModelArr3Methods.ModelArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr3.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr3 gron: {e.Message}"); }
    }

    void TestModelModelArr4(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.json");
            var r = new JsonReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr4.gron");
            var r = new GronReader(data);
            var obj = ModelArr4Methods.ModelArr4Codec.Decode(r);
            var w = new GronWriter();
            ModelArr4Methods.ModelArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr4.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr4 gron: {e.Message}"); }
    }

    void TestModelModelArr5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.msgpack");
            var r = new MsgPackReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new MsgPackWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.msgpack")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.json");
            var r = new JsonReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.unformatted.json");
            var r = new JsonReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new JsonWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ModelArr5.gron");
            var r = new GronReader(data);
            var obj = ModelArr5Methods.ModelArr5Codec.Decode(r);
            var w = new GronWriter();
            ModelArr5Methods.ModelArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ModelArr5.gron")!);
            File.WriteAllBytes($"{outDir}/ModelArr5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ModelArr5 gron: {e.Message}"); }
    }

    void TestModelMix01(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix01.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.json");
            var r = new JsonReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new JsonWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.json")!);
            File.WriteAllBytes($"{outDir}/Mix01.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new JsonWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix01.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix01.gron");
            var r = new GronReader(data);
            var obj = Mix01Methods.Mix01Codec.Decode(r);
            var w = new GronWriter();
            Mix01Methods.Mix01Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix01.gron")!);
            File.WriteAllBytes($"{outDir}/Mix01.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix01 gron: {e.Message}"); }
    }

    void TestModelMix02(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix02.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.json");
            var r = new JsonReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new JsonWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.json")!);
            File.WriteAllBytes($"{outDir}/Mix02.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new JsonWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix02.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix02.gron");
            var r = new GronReader(data);
            var obj = Mix02Methods.Mix02Codec.Decode(r);
            var w = new GronWriter();
            Mix02Methods.Mix02Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix02.gron")!);
            File.WriteAllBytes($"{outDir}/Mix02.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix02 gron: {e.Message}"); }
    }

    void TestModelMix03(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix03.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.json");
            var r = new JsonReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new JsonWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.json")!);
            File.WriteAllBytes($"{outDir}/Mix03.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new JsonWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix03.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix03.gron");
            var r = new GronReader(data);
            var obj = Mix03Methods.Mix03Codec.Decode(r);
            var w = new GronWriter();
            Mix03Methods.Mix03Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix03.gron")!);
            File.WriteAllBytes($"{outDir}/Mix03.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix03 gron: {e.Message}"); }
    }

    void TestModelMix04(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix04.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.json");
            var r = new JsonReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new JsonWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.json")!);
            File.WriteAllBytes($"{outDir}/Mix04.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new JsonWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix04.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix04.gron");
            var r = new GronReader(data);
            var obj = Mix04Methods.Mix04Codec.Decode(r);
            var w = new GronWriter();
            Mix04Methods.Mix04Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix04.gron")!);
            File.WriteAllBytes($"{outDir}/Mix04.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix04 gron: {e.Message}"); }
    }

    void TestModelMix05(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix05.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.json");
            var r = new JsonReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new JsonWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.json")!);
            File.WriteAllBytes($"{outDir}/Mix05.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new JsonWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix05.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix05.gron");
            var r = new GronReader(data);
            var obj = Mix05Methods.Mix05Codec.Decode(r);
            var w = new GronWriter();
            Mix05Methods.Mix05Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix05.gron")!);
            File.WriteAllBytes($"{outDir}/Mix05.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix05 gron: {e.Message}"); }
    }

    void TestModelMix06(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix06.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.json");
            var r = new JsonReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new JsonWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.json")!);
            File.WriteAllBytes($"{outDir}/Mix06.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new JsonWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix06.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix06.gron");
            var r = new GronReader(data);
            var obj = Mix06Methods.Mix06Codec.Decode(r);
            var w = new GronWriter();
            Mix06Methods.Mix06Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix06.gron")!);
            File.WriteAllBytes($"{outDir}/Mix06.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix06 gron: {e.Message}"); }
    }

    void TestModelMix07(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix07.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.json");
            var r = new JsonReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new JsonWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.json")!);
            File.WriteAllBytes($"{outDir}/Mix07.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new JsonWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix07.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix07.gron");
            var r = new GronReader(data);
            var obj = Mix07Methods.Mix07Codec.Decode(r);
            var w = new GronWriter();
            Mix07Methods.Mix07Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix07.gron")!);
            File.WriteAllBytes($"{outDir}/Mix07.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix07 gron: {e.Message}"); }
    }

    void TestModelMix08(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix08.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.json");
            var r = new JsonReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new JsonWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.json")!);
            File.WriteAllBytes($"{outDir}/Mix08.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new JsonWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix08.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix08.gron");
            var r = new GronReader(data);
            var obj = Mix08Methods.Mix08Codec.Decode(r);
            var w = new GronWriter();
            Mix08Methods.Mix08Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix08.gron")!);
            File.WriteAllBytes($"{outDir}/Mix08.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix08 gron: {e.Message}"); }
    }

    void TestModelMix09(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix09.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.json");
            var r = new JsonReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new JsonWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.json")!);
            File.WriteAllBytes($"{outDir}/Mix09.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new JsonWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix09.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix09.gron");
            var r = new GronReader(data);
            var obj = Mix09Methods.Mix09Codec.Decode(r);
            var w = new GronWriter();
            Mix09Methods.Mix09Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix09.gron")!);
            File.WriteAllBytes($"{outDir}/Mix09.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix09 gron: {e.Message}"); }
    }

    void TestModelMix10(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix10.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.json");
            var r = new JsonReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new JsonWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.json")!);
            File.WriteAllBytes($"{outDir}/Mix10.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new JsonWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix10.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix10.gron");
            var r = new GronReader(data);
            var obj = Mix10Methods.Mix10Codec.Decode(r);
            var w = new GronWriter();
            Mix10Methods.Mix10Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix10.gron")!);
            File.WriteAllBytes($"{outDir}/Mix10.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix10 gron: {e.Message}"); }
    }

    void TestModelMix11(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix11.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.json");
            var r = new JsonReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new JsonWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.json")!);
            File.WriteAllBytes($"{outDir}/Mix11.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new JsonWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix11.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix11.gron");
            var r = new GronReader(data);
            var obj = Mix11Methods.Mix11Codec.Decode(r);
            var w = new GronWriter();
            Mix11Methods.Mix11Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix11.gron")!);
            File.WriteAllBytes($"{outDir}/Mix11.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix11 gron: {e.Message}"); }
    }

    void TestModelMix12(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix12.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.json");
            var r = new JsonReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new JsonWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.json")!);
            File.WriteAllBytes($"{outDir}/Mix12.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new JsonWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix12.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix12.gron");
            var r = new GronReader(data);
            var obj = Mix12Methods.Mix12Codec.Decode(r);
            var w = new GronWriter();
            Mix12Methods.Mix12Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix12.gron")!);
            File.WriteAllBytes($"{outDir}/Mix12.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix12 gron: {e.Message}"); }
    }

    void TestModelMix13(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix13.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.json");
            var r = new JsonReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new JsonWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.json")!);
            File.WriteAllBytes($"{outDir}/Mix13.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new JsonWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix13.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix13.gron");
            var r = new GronReader(data);
            var obj = Mix13Methods.Mix13Codec.Decode(r);
            var w = new GronWriter();
            Mix13Methods.Mix13Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix13.gron")!);
            File.WriteAllBytes($"{outDir}/Mix13.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix13 gron: {e.Message}"); }
    }

    void TestModelMix14(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix14.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.json");
            var r = new JsonReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new JsonWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.json")!);
            File.WriteAllBytes($"{outDir}/Mix14.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new JsonWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix14.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix14.gron");
            var r = new GronReader(data);
            var obj = Mix14Methods.Mix14Codec.Decode(r);
            var w = new GronWriter();
            Mix14Methods.Mix14Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix14.gron")!);
            File.WriteAllBytes($"{outDir}/Mix14.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix14 gron: {e.Message}"); }
    }

    void TestModelMix15(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.msgpack");
            var r = new MsgPackReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new MsgPackWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.msgpack")!);
            File.WriteAllBytes($"{outDir}/Mix15.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.json");
            var r = new JsonReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new JsonWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.json")!);
            File.WriteAllBytes($"{outDir}/Mix15.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.unformatted.json");
            var r = new JsonReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new JsonWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Mix15.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Mix15.gron");
            var r = new GronReader(data);
            var obj = Mix15Methods.Mix15Codec.Decode(r);
            var w = new GronWriter();
            Mix15Methods.Mix15Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Mix15.gron")!);
            File.WriteAllBytes($"{outDir}/Mix15.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Mix15 gron: {e.Message}"); }
    }

    void TestModelAllOpt1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.json");
            var r = new JsonReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt1.gron");
            var r = new GronReader(data);
            var obj = AllOpt1Methods.AllOpt1Codec.Decode(r);
            var w = new GronWriter();
            AllOpt1Methods.AllOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt1.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt1 gron: {e.Message}"); }
    }

    void TestModelAllOpt2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.json");
            var r = new JsonReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt2.gron");
            var r = new GronReader(data);
            var obj = AllOpt2Methods.AllOpt2Codec.Decode(r);
            var w = new GronWriter();
            AllOpt2Methods.AllOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt2.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt2 gron: {e.Message}"); }
    }

    void TestModelAllOpt3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.json");
            var r = new JsonReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt3.gron");
            var r = new GronReader(data);
            var obj = AllOpt3Methods.AllOpt3Codec.Decode(r);
            var w = new GronWriter();
            AllOpt3Methods.AllOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt3.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt3 gron: {e.Message}"); }
    }

    void TestModelAllOpt4(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.json");
            var r = new JsonReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt4.gron");
            var r = new GronReader(data);
            var obj = AllOpt4Methods.AllOpt4Codec.Decode(r);
            var w = new GronWriter();
            AllOpt4Methods.AllOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt4.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt4 gron: {e.Message}"); }
    }

    void TestModelAllOpt5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.msgpack");
            var r = new MsgPackReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new MsgPackWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.msgpack")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.json");
            var r = new JsonReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.unformatted.json");
            var r = new JsonReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new JsonWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/AllOpt5.gron");
            var r = new GronReader(data);
            var obj = AllOpt5Methods.AllOpt5Codec.Decode(r);
            var w = new GronWriter();
            AllOpt5Methods.AllOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/AllOpt5.gron")!);
            File.WriteAllBytes($"{outDir}/AllOpt5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL AllOpt5 gron: {e.Message}"); }
    }

    void TestModelRecList(ref int passed, ref int failed) {
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

    void TestModelRecTree(ref int passed, ref int failed) {
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

    void TestModelRecChain(ref int passed, ref int failed) {
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

    void TestModelRecWrap(ref int passed, ref int failed) {
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

    void TestModelRecWide(ref int passed, ref int failed) {
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

    void TestModelWide20(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide20.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.json");
            var r = new JsonReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new JsonWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.json")!);
            File.WriteAllBytes($"{outDir}/Wide20.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new JsonWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide20.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide20.gron");
            var r = new GronReader(data);
            var obj = Wide20Methods.Wide20Codec.Decode(r);
            var w = new GronWriter();
            Wide20Methods.Wide20Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide20.gron")!);
            File.WriteAllBytes($"{outDir}/Wide20.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide20 gron: {e.Message}"); }
    }

    void TestModelWide25(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide25.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.json");
            var r = new JsonReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new JsonWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.json")!);
            File.WriteAllBytes($"{outDir}/Wide25.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new JsonWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide25.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide25.gron");
            var r = new GronReader(data);
            var obj = Wide25Methods.Wide25Codec.Decode(r);
            var w = new GronWriter();
            Wide25Methods.Wide25Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide25.gron")!);
            File.WriteAllBytes($"{outDir}/Wide25.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide25 gron: {e.Message}"); }
    }

    void TestModelWide30(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide30.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.json");
            var r = new JsonReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new JsonWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.json")!);
            File.WriteAllBytes($"{outDir}/Wide30.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new JsonWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide30.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide30.gron");
            var r = new GronReader(data);
            var obj = Wide30Methods.Wide30Codec.Decode(r);
            var w = new GronWriter();
            Wide30Methods.Wide30Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide30.gron")!);
            File.WriteAllBytes($"{outDir}/Wide30.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide30 gron: {e.Message}"); }
    }

    void TestModelWide35(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide35.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.json");
            var r = new JsonReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new JsonWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.json")!);
            File.WriteAllBytes($"{outDir}/Wide35.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new JsonWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide35.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide35.gron");
            var r = new GronReader(data);
            var obj = Wide35Methods.Wide35Codec.Decode(r);
            var w = new GronWriter();
            Wide35Methods.Wide35Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide35.gron")!);
            File.WriteAllBytes($"{outDir}/Wide35.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide35 gron: {e.Message}"); }
    }

    void TestModelWide40(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.msgpack");
            var r = new MsgPackReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new MsgPackWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.msgpack")!);
            File.WriteAllBytes($"{outDir}/Wide40.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.json");
            var r = new JsonReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new JsonWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.json")!);
            File.WriteAllBytes($"{outDir}/Wide40.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.unformatted.json");
            var r = new JsonReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new JsonWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Wide40.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Wide40.gron");
            var r = new GronReader(data);
            var obj = Wide40Methods.Wide40Codec.Decode(r);
            var w = new GronWriter();
            Wide40Methods.Wide40Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Wide40.gron")!);
            File.WriteAllBytes($"{outDir}/Wide40.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Wide40 gron: {e.Message}"); }
    }

    void TestModelEdgeEmpty(ref int passed, ref int failed) {
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

    void TestModelEdgeOneOpt(ref int passed, ref int failed) {
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

    void TestModelEdgeBigNums(ref int passed, ref int failed) {
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

    void TestModelEdgeZeroVals(ref int passed, ref int failed) {
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

    void TestModelEdgeNullable(ref int passed, ref int failed) {
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

    void TestModelEdgeNegZero(ref int passed, ref int failed) {
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

    void TestModelEdgeNullByte(ref int passed, ref int failed) {
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

    void TestModelEdgeBoundary(ref int passed, ref int failed) {
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

    void TestModelEdgeStrLen(ref int passed, ref int failed) {
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

    void TestModelEdgeBytesLen(ref int passed, ref int failed) {
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

    void TestModelEdgeArrEmpty(ref int passed, ref int failed) {
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

    void TestModelEdgeArrBoundary(ref int passed, ref int failed) {
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

    void TestModelOptArr1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.json");
            var r = new JsonReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new JsonWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.json")!);
            File.WriteAllBytes($"{outDir}/OptArr1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new JsonWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr1.gron");
            var r = new GronReader(data);
            var obj = OptArr1Methods.OptArr1Codec.Decode(r);
            var w = new GronWriter();
            OptArr1Methods.OptArr1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr1.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr1 gron: {e.Message}"); }
    }

    void TestModelOptArr2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.json");
            var r = new JsonReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new JsonWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.json")!);
            File.WriteAllBytes($"{outDir}/OptArr2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new JsonWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr2.gron");
            var r = new GronReader(data);
            var obj = OptArr2Methods.OptArr2Codec.Decode(r);
            var w = new GronWriter();
            OptArr2Methods.OptArr2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr2.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr2 gron: {e.Message}"); }
    }

    void TestModelOptArr3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.json");
            var r = new JsonReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new JsonWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.json")!);
            File.WriteAllBytes($"{outDir}/OptArr3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new JsonWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr3.gron");
            var r = new GronReader(data);
            var obj = OptArr3Methods.OptArr3Codec.Decode(r);
            var w = new GronWriter();
            OptArr3Methods.OptArr3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr3.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr3 gron: {e.Message}"); }
    }

    void TestModelOptArr4(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.json");
            var r = new JsonReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new JsonWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.json")!);
            File.WriteAllBytes($"{outDir}/OptArr4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new JsonWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr4.gron");
            var r = new GronReader(data);
            var obj = OptArr4Methods.OptArr4Codec.Decode(r);
            var w = new GronWriter();
            OptArr4Methods.OptArr4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr4.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr4 gron: {e.Message}"); }
    }

    void TestModelOptArr5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new MsgPackWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptArr5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.json");
            var r = new JsonReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new JsonWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.json")!);
            File.WriteAllBytes($"{outDir}/OptArr5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new JsonWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptArr5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptArr5.gron");
            var r = new GronReader(data);
            var obj = OptArr5Methods.OptArr5Codec.Decode(r);
            var w = new GronWriter();
            OptArr5Methods.OptArr5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptArr5.gron")!);
            File.WriteAllBytes($"{outDir}/OptArr5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptArr5 gron: {e.Message}"); }
    }

    void TestModelNestOpt1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.json");
            var r = new JsonReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt1.gron");
            var r = new GronReader(data);
            var obj = NestOpt1Methods.NestOpt1Codec.Decode(r);
            var w = new GronWriter();
            NestOpt1Methods.NestOpt1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt1.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt1 gron: {e.Message}"); }
    }

    void TestModelNestOpt2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.json");
            var r = new JsonReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt2.gron");
            var r = new GronReader(data);
            var obj = NestOpt2Methods.NestOpt2Codec.Decode(r);
            var w = new GronWriter();
            NestOpt2Methods.NestOpt2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt2.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt2 gron: {e.Message}"); }
    }

    void TestModelNestOpt3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.json");
            var r = new JsonReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt3.gron");
            var r = new GronReader(data);
            var obj = NestOpt3Methods.NestOpt3Codec.Decode(r);
            var w = new GronWriter();
            NestOpt3Methods.NestOpt3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt3.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt3 gron: {e.Message}"); }
    }

    void TestModelNestOpt4(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.json");
            var r = new JsonReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt4.gron");
            var r = new GronReader(data);
            var obj = NestOpt4Methods.NestOpt4Codec.Decode(r);
            var w = new GronWriter();
            NestOpt4Methods.NestOpt4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt4.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt4 gron: {e.Message}"); }
    }

    void TestModelNestOpt5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.json");
            var r = new JsonReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new JsonWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOpt5.gron");
            var r = new GronReader(data);
            var obj = NestOpt5Methods.NestOpt5Codec.Decode(r);
            var w = new GronWriter();
            NestOpt5Methods.NestOpt5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOpt5.gron")!);
            File.WriteAllBytes($"{outDir}/NestOpt5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOpt5 gron: {e.Message}"); }
    }

    void TestModelNestOptInner1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.json");
            var r = new JsonReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner1.gron");
            var r = new GronReader(data);
            var obj = NestOptInner1Methods.NestOptInner1Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner1Methods.NestOptInner1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner1.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner1 gron: {e.Message}"); }
    }

    void TestModelNestOptInner2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.json");
            var r = new JsonReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner2.gron");
            var r = new GronReader(data);
            var obj = NestOptInner2Methods.NestOptInner2Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner2Methods.NestOptInner2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner2.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner2 gron: {e.Message}"); }
    }

    void TestModelNestOptInner3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new MsgPackWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.json");
            var r = new JsonReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new JsonWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestOptInner3.gron");
            var r = new GronReader(data);
            var obj = NestOptInner3Methods.NestOptInner3Codec.Decode(r);
            var w = new GronWriter();
            NestOptInner3Methods.NestOptInner3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestOptInner3.gron")!);
            File.WriteAllBytes($"{outDir}/NestOptInner3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestOptInner3 gron: {e.Message}"); }
    }

    void TestModelDeepNest1(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.json");
            var r = new JsonReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest1.gron");
            var r = new GronReader(data);
            var obj = DeepNest1Methods.DeepNest1Codec.Decode(r);
            var w = new GronWriter();
            DeepNest1Methods.DeepNest1Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest1.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest1.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest1 gron: {e.Message}"); }
    }

    void TestModelDeepNest2(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.json");
            var r = new JsonReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest2.gron");
            var r = new GronReader(data);
            var obj = DeepNest2Methods.DeepNest2Codec.Decode(r);
            var w = new GronWriter();
            DeepNest2Methods.DeepNest2Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest2.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest2.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest2 gron: {e.Message}"); }
    }

    void TestModelDeepNest3(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.json");
            var r = new JsonReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest3.gron");
            var r = new GronReader(data);
            var obj = DeepNest3Methods.DeepNest3Codec.Decode(r);
            var w = new GronWriter();
            DeepNest3Methods.DeepNest3Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest3.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest3.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest3 gron: {e.Message}"); }
    }

    void TestModelDeepNest4(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.json");
            var r = new JsonReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest4.gron");
            var r = new GronReader(data);
            var obj = DeepNest4Methods.DeepNest4Codec.Decode(r);
            var w = new GronWriter();
            DeepNest4Methods.DeepNest4Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest4.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest4.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest4 gron: {e.Message}"); }
    }

    void TestModelDeepNest5(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.json");
            var r = new JsonReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest5.gron");
            var r = new GronReader(data);
            var obj = DeepNest5Methods.DeepNest5Codec.Decode(r);
            var w = new GronWriter();
            DeepNest5Methods.DeepNest5Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest5.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest5.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest5 gron: {e.Message}"); }
    }

    void TestModelDeepNest6(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.json");
            var r = new JsonReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest6.gron");
            var r = new GronReader(data);
            var obj = DeepNest6Methods.DeepNest6Codec.Decode(r);
            var w = new GronWriter();
            DeepNest6Methods.DeepNest6Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest6.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest6.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest6 gron: {e.Message}"); }
    }

    void TestModelDeepNest7(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.msgpack");
            var r = new MsgPackReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new MsgPackWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.msgpack")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.json");
            var r = new JsonReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.unformatted.json");
            var r = new JsonReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new JsonWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/DeepNest7.gron");
            var r = new GronReader(data);
            var obj = DeepNest7Methods.DeepNest7Codec.Decode(r);
            var w = new GronWriter();
            DeepNest7Methods.DeepNest7Codec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/DeepNest7.gron")!);
            File.WriteAllBytes($"{outDir}/DeepNest7.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL DeepNest7 gron: {e.Message}"); }
    }

    void TestModelTimestampEntry(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.msgpack");
            var r = new MsgPackReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new MsgPackWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.msgpack")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.json");
            var r = new JsonReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new JsonWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.json")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.unformatted.json");
            var r = new JsonReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new JsonWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/TimestampEntry.gron");
            var r = new GronReader(data);
            var obj = TimestampEntryMethods.TimestampEntryCodec.Decode(r);
            var w = new GronWriter();
            TimestampEntryMethods.TimestampEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/TimestampEntry.gron")!);
            File.WriteAllBytes($"{outDir}/TimestampEntry.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL TimestampEntry gron: {e.Message}"); }
    }

    void TestModelConfigEntry(ref int passed, ref int failed) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.msgpack");
            var r = new MsgPackReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new MsgPackWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.msgpack")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.json");
            var r = new JsonReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new JsonWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.json")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.unformatted.json");
            var r = new JsonReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new JsonWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ConfigEntry.gron");
            var r = new GronReader(data);
            var obj = ConfigEntryMethods.ConfigEntryCodec.Decode(r);
            var w = new GronWriter();
            ConfigEntryMethods.ConfigEntryCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ConfigEntry.gron")!);
            File.WriteAllBytes($"{outDir}/ConfigEntry.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ConfigEntry gron: {e.Message}"); }
    }


// Scalar tests
        TestScalarInt8_min(ref passed, ref failed);
        TestScalarInt8_max(ref passed, ref failed);
        TestScalarInt16_min(ref passed, ref failed);
        TestScalarInt16_max(ref passed, ref failed);
        TestScalarInt32_min(ref passed, ref failed);
        TestScalarInt32_max(ref passed, ref failed);
        TestScalarInt64_min(ref passed, ref failed);
        TestScalarInt64_max(ref passed, ref failed);
        TestScalarUint8_max(ref passed, ref failed);
        TestScalarUint16_max(ref passed, ref failed);
        TestScalarUint32_max(ref passed, ref failed);
        TestScalarUint64_max(ref passed, ref failed);
        TestScalarFloat32_1_5(ref passed, ref failed);
        TestScalarFloat32_neg_zero(ref passed, ref failed);
        TestScalarFloat32_inf(ref passed, ref failed);
        TestScalarFloat32_neg_inf(ref passed, ref failed);
        TestScalarFloat32_nan(ref passed, ref failed);
        TestScalarFloat64_pi(ref passed, ref failed);
        TestScalarFloat64_neg_zero(ref passed, ref failed);
        TestScalarFloat64_inf(ref passed, ref failed);
        TestScalarFloat64_neg_inf(ref passed, ref failed);
        TestScalarFloat64_nan(ref passed, ref failed);
        TestScalarStr_empty(ref passed, ref failed);
        TestScalarStr_ascii(ref passed, ref failed);
        TestScalarStr_null_byte(ref passed, ref failed);
        TestScalarStr_escape(ref passed, ref failed);
        TestScalarStr_unicode(ref passed, ref failed);
        TestScalarStr_31(ref passed, ref failed);
        TestScalarStr_32(ref passed, ref failed);
        TestScalarStr_255(ref passed, ref failed);
        TestScalarStr_256(ref passed, ref failed);
        TestScalarBytes_empty(ref passed, ref failed);
        TestScalarBytes_small(ref passed, ref failed);
        TestScalarBytes_31(ref passed, ref failed);
        TestScalarBytes_32(ref passed, ref failed);
        TestScalarBytes_255(ref passed, ref failed);
        TestScalarBytes_256(ref passed, ref failed);
        TestScalarBytes_zeros(ref passed, ref failed);
        TestScalarBytes_ff(ref passed, ref failed);
        TestScalarBool_true(ref passed, ref failed);
        TestScalarBool_false(ref passed, ref failed);

// Model tests
        TestModelOptInner(ref passed, ref failed);
        TestModelSingleString(ref passed, ref failed);
        TestModelSingleBoolean(ref passed, ref failed);
        TestModelSingleInt8(ref passed, ref failed);
        TestModelSingleInt16(ref passed, ref failed);
        TestModelSingleInt32(ref passed, ref failed);
        TestModelSingleInt64(ref passed, ref failed);
        TestModelSingleUint8(ref passed, ref failed);
        TestModelSingleUint16(ref passed, ref failed);
        TestModelSingleUint32(ref passed, ref failed);
        TestModelSingleUint64(ref passed, ref failed);
        TestModelSingleFloat32(ref passed, ref failed);
        TestModelSingleFloat64(ref passed, ref failed);
        TestModelSingleBytes(ref passed, ref failed);
        TestModelOptSingleString(ref passed, ref failed);
        TestModelOptSingleBoolean(ref passed, ref failed);
        TestModelOptSingleInt8(ref passed, ref failed);
        TestModelOptSingleInt16(ref passed, ref failed);
        TestModelOptSingleInt32(ref passed, ref failed);
        TestModelOptSingleInt64(ref passed, ref failed);
        TestModelOptSingleUint8(ref passed, ref failed);
        TestModelOptSingleUint16(ref passed, ref failed);
        TestModelOptSingleUint32(ref passed, ref failed);
        TestModelOptSingleUint64(ref passed, ref failed);
        TestModelOptSingleFloat32(ref passed, ref failed);
        TestModelOptSingleFloat64(ref passed, ref failed);
        TestModelOptSingleBytes(ref passed, ref failed);
        TestModelPairString(ref passed, ref failed);
        TestModelPairBoolean(ref passed, ref failed);
        TestModelPairInt8(ref passed, ref failed);
        TestModelPairInt16(ref passed, ref failed);
        TestModelPairInt32(ref passed, ref failed);
        TestModelPairInt64(ref passed, ref failed);
        TestModelPairUint8(ref passed, ref failed);
        TestModelPairUint16(ref passed, ref failed);
        TestModelPairUint32(ref passed, ref failed);
        TestModelPairUint64(ref passed, ref failed);
        TestModelPairFloat32(ref passed, ref failed);
        TestModelPairFloat64(ref passed, ref failed);
        TestModelPairBytes(ref passed, ref failed);
        TestModelDualStringInt32(ref passed, ref failed);
        TestModelDualStringBoolean(ref passed, ref failed);
        TestModelDualStringFloat64(ref passed, ref failed);
        TestModelDualStringBytes(ref passed, ref failed);
        TestModelDualInt32Boolean(ref passed, ref failed);
        TestModelDualInt32Float64(ref passed, ref failed);
        TestModelDualInt32Int64(ref passed, ref failed);
        TestModelDualInt32Uint32(ref passed, ref failed);
        TestModelDualInt64Uint64(ref passed, ref failed);
        TestModelDualFloat32Float64(ref passed, ref failed);
        TestModelDualFloat64Boolean(ref passed, ref failed);
        TestModelDualFloat64Bytes(ref passed, ref failed);
        TestModelDualUint32Uint64(ref passed, ref failed);
        TestModelDualBooleanBytes(ref passed, ref failed);
        TestModelDualInt8Uint8(ref passed, ref failed);
        TestModelDualInt16Uint16(ref passed, ref failed);
        TestModelDualStringInt64(ref passed, ref failed);
        TestModelDualStringUint64(ref passed, ref failed);
        TestModelDualInt32Bytes(ref passed, ref failed);
        TestModelDualFloat64Int32(ref passed, ref failed);
        TestModelDualBooleanInt32(ref passed, ref failed);
        TestModelDualBytesInt64(ref passed, ref failed);
        TestModelDualInt8Float32(ref passed, ref failed);
        TestModelDualUint8Int16(ref passed, ref failed);
        TestModelDualInt64Float64(ref passed, ref failed);
        TestModelDualUint64String(ref passed, ref failed);
        TestModelTriple01(ref passed, ref failed);
        TestModelTriple02(ref passed, ref failed);
        TestModelTriple03(ref passed, ref failed);
        TestModelTriple04(ref passed, ref failed);
        TestModelTriple05(ref passed, ref failed);
        TestModelTriple06(ref passed, ref failed);
        TestModelTriple07(ref passed, ref failed);
        TestModelTriple08(ref passed, ref failed);
        TestModelTriple09(ref passed, ref failed);
        TestModelTriple10(ref passed, ref failed);
        TestModelTriple11(ref passed, ref failed);
        TestModelTriple12(ref passed, ref failed);
        TestModelTriple13(ref passed, ref failed);
        TestModelTriple14(ref passed, ref failed);
        TestModelTriple15(ref passed, ref failed);
        TestModelFive01(ref passed, ref failed);
        TestModelFive02(ref passed, ref failed);
        TestModelFive03(ref passed, ref failed);
        TestModelFive04(ref passed, ref failed);
        TestModelFive05(ref passed, ref failed);
        TestModelFive06(ref passed, ref failed);
        TestModelFive07(ref passed, ref failed);
        TestModelFive08(ref passed, ref failed);
        TestModelFive09(ref passed, ref failed);
        TestModelFive10(ref passed, ref failed);
        TestModelTen01(ref passed, ref failed);
        TestModelTen02(ref passed, ref failed);
        TestModelTen03(ref passed, ref failed);
        TestModelTen04(ref passed, ref failed);
        TestModelTen05(ref passed, ref failed);
        TestModelArrString(ref passed, ref failed);
        TestModelArrInt32(ref passed, ref failed);
        TestModelArrBoolean(ref passed, ref failed);
        TestModelArrFloat64(ref passed, ref failed);
        TestModelArrBytes(ref passed, ref failed);
        TestModelArrInt64(ref passed, ref failed);
        TestModelArrUint64(ref passed, ref failed);
        TestModelMultiArr1(ref passed, ref failed);
        TestModelMultiArr2(ref passed, ref failed);
        TestModelMultiArr3(ref passed, ref failed);
        TestModelMultiArr4(ref passed, ref failed);
        TestModelMultiArr5(ref passed, ref failed);
        TestModelOptCombo1(ref passed, ref failed);
        TestModelOptCombo2(ref passed, ref failed);
        TestModelOptCombo3(ref passed, ref failed);
        TestModelOptCombo4(ref passed, ref failed);
        TestModelOptCombo5(ref passed, ref failed);
        TestModelOptCombo6(ref passed, ref failed);
        TestModelOptCombo7(ref passed, ref failed);
        TestModelOptCombo8(ref passed, ref failed);
        TestModelOptCombo9(ref passed, ref failed);
        TestModelOptCombo10(ref passed, ref failed);
        TestModelNestInner(ref passed, ref failed);
        TestModelNestCoord(ref passed, ref failed);
        TestModelNestIdVal(ref passed, ref failed);
        TestModelNestLabel(ref passed, ref failed);
        TestModelNestMoney(ref passed, ref failed);
        TestModelNestRange32(ref passed, ref failed);
        TestModelNestAddr(ref passed, ref failed);
        TestModelNestPoint3(ref passed, ref failed);
        TestModelOptNestInner(ref passed, ref failed);
        TestModelOptNestCoord(ref passed, ref failed);
        TestModelOptNestIdVal(ref passed, ref failed);
        TestModelOptNestLabel(ref passed, ref failed);
        TestModelOptNestMoney(ref passed, ref failed);
        TestModelOptNestRange32(ref passed, ref failed);
        TestModelOptNestAddr(ref passed, ref failed);
        TestModelOptNestPoint3(ref passed, ref failed);
        TestModelModelArr1(ref passed, ref failed);
        TestModelModelArr2(ref passed, ref failed);
        TestModelModelArr3(ref passed, ref failed);
        TestModelModelArr4(ref passed, ref failed);
        TestModelModelArr5(ref passed, ref failed);
        TestModelMix01(ref passed, ref failed);
        TestModelMix02(ref passed, ref failed);
        TestModelMix03(ref passed, ref failed);
        TestModelMix04(ref passed, ref failed);
        TestModelMix05(ref passed, ref failed);
        TestModelMix06(ref passed, ref failed);
        TestModelMix07(ref passed, ref failed);
        TestModelMix08(ref passed, ref failed);
        TestModelMix09(ref passed, ref failed);
        TestModelMix10(ref passed, ref failed);
        TestModelMix11(ref passed, ref failed);
        TestModelMix12(ref passed, ref failed);
        TestModelMix13(ref passed, ref failed);
        TestModelMix14(ref passed, ref failed);
        TestModelMix15(ref passed, ref failed);
        TestModelAllOpt1(ref passed, ref failed);
        TestModelAllOpt2(ref passed, ref failed);
        TestModelAllOpt3(ref passed, ref failed);
        TestModelAllOpt4(ref passed, ref failed);
        TestModelAllOpt5(ref passed, ref failed);
        TestModelRecList(ref passed, ref failed);
        TestModelRecTree(ref passed, ref failed);
        TestModelRecChain(ref passed, ref failed);
        TestModelRecWrap(ref passed, ref failed);
        TestModelRecWide(ref passed, ref failed);
        TestModelWide20(ref passed, ref failed);
        TestModelWide25(ref passed, ref failed);
        TestModelWide30(ref passed, ref failed);
        TestModelWide35(ref passed, ref failed);
        TestModelWide40(ref passed, ref failed);
        TestModelEdgeEmpty(ref passed, ref failed);
        TestModelEdgeOneOpt(ref passed, ref failed);
        TestModelEdgeBigNums(ref passed, ref failed);
        TestModelEdgeZeroVals(ref passed, ref failed);
        TestModelEdgeNullable(ref passed, ref failed);
        TestModelEdgeNegZero(ref passed, ref failed);
        TestModelEdgeNullByte(ref passed, ref failed);
        TestModelEdgeBoundary(ref passed, ref failed);
        TestModelEdgeStrLen(ref passed, ref failed);
        TestModelEdgeBytesLen(ref passed, ref failed);
        TestModelEdgeArrEmpty(ref passed, ref failed);
        TestModelEdgeArrBoundary(ref passed, ref failed);
        TestModelOptArr1(ref passed, ref failed);
        TestModelOptArr2(ref passed, ref failed);
        TestModelOptArr3(ref passed, ref failed);
        TestModelOptArr4(ref passed, ref failed);
        TestModelOptArr5(ref passed, ref failed);
        TestModelNestOpt1(ref passed, ref failed);
        TestModelNestOpt2(ref passed, ref failed);
        TestModelNestOpt3(ref passed, ref failed);
        TestModelNestOpt4(ref passed, ref failed);
        TestModelNestOpt5(ref passed, ref failed);
        TestModelNestOptInner1(ref passed, ref failed);
        TestModelNestOptInner2(ref passed, ref failed);
        TestModelNestOptInner3(ref passed, ref failed);
        TestModelDeepNest1(ref passed, ref failed);
        TestModelDeepNest2(ref passed, ref failed);
        TestModelDeepNest3(ref passed, ref failed);
        TestModelDeepNest4(ref passed, ref failed);
        TestModelDeepNest5(ref passed, ref failed);
        TestModelDeepNest6(ref passed, ref failed);
        TestModelDeepNest7(ref passed, ref failed);
        TestModelTimestampEntry(ref passed, ref failed);
        TestModelConfigEntry(ref passed, ref failed);


Console.WriteLine($"emit-csharp: {passed} passed, {failed} failed");
if (failed > 0) Environment.Exit(1);
