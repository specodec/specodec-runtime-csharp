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

// Model tests (by namespace)
        EmitTest_all_types.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__scalars.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__opt.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__pairs.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__many.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__arrays.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__nests.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__mixed.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__recursive.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__wide.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__edge.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__extra.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types_nested.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types_nested_deep.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__enums.Run(ref passed, ref failed, vecDir, outDir);
        EmitTest_all_types__unions.Run(ref passed, ref failed, vecDir, outDir);


Console.WriteLine($"emit-csharp: {passed} passed, {failed} failed");
if (failed > 0) Environment.Exit(1);
