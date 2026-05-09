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

public static class EmitTest_all_types__nests {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelNestInner(ref passed, ref failed, vecDir, outDir);
        TestModelNestCoord(ref passed, ref failed, vecDir, outDir);
        TestModelNestIdVal(ref passed, ref failed, vecDir, outDir);
        TestModelNestLabel(ref passed, ref failed, vecDir, outDir);
        TestModelNestMoney(ref passed, ref failed, vecDir, outDir);
        TestModelNestRange32(ref passed, ref failed, vecDir, outDir);
        TestModelNestAddr(ref passed, ref failed, vecDir, outDir);
        TestModelNestPoint3(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestInner(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestCoord(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestIdVal(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestLabel(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestMoney(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestRange32(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestAddr(ref passed, ref failed, vecDir, outDir);
        TestModelOptNestPoint3(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelNestInner(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestCoord(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestIdVal(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestLabel(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestMoney(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestRange32(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestAddr(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelNestPoint3(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestInner(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestCoord(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestIdVal(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestLabel(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestMoney(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestRange32(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestAddr(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelOptNestPoint3(ref int passed, ref int failed, string vecDir, string outDir) {
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

}
