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

public static class EmitTest_all_types {
    public static void Run(ref int passed, ref int failed, string vecDir, string outDir) {
        TestModelOptInner(ref passed, ref failed, vecDir, outDir);
        TestModelShape_circle(ref passed, ref failed, vecDir, outDir);
        TestModelShape_rect(ref passed, ref failed, vecDir, outDir);
        TestModelIdent_name(ref passed, ref failed, vecDir, outDir);
        TestModelIdent_number(ref passed, ref failed, vecDir, outDir);
        TestModelResultMsg_ok(ref passed, ref failed, vecDir, outDir);
        TestModelResultMsg_err(ref passed, ref failed, vecDir, outDir);
        TestModelTagged_tag(ref passed, ref failed, vecDir, outDir);
        TestModelTagged_score(ref passed, ref failed, vecDir, outDir);
        TestModelTagged_active(ref passed, ref failed, vecDir, outDir);
        TestModelOptUnionHolder_shape(ref passed, ref failed, vecDir, outDir);
        TestModelOptUnionHolder_id(ref passed, ref failed, vecDir, outDir);
        TestModelMixedUnion_point(ref passed, ref failed, vecDir, outDir);
        TestModelMixedUnion_label(ref passed, ref failed, vecDir, outDir);
        TestModelMixedUnion_count(ref passed, ref failed, vecDir, outDir);
        TestModelNestedUnion_result(ref passed, ref failed, vecDir, outDir);
        TestModelNestedUnion_shape(ref passed, ref failed, vecDir, outDir);
        TestModelScalarUnion_s(ref passed, ref failed, vecDir, outDir);
        TestModelScalarUnion_i(ref passed, ref failed, vecDir, outDir);
        TestModelScalarUnion_f(ref passed, ref failed, vecDir, outDir);
        TestModelScalarUnion_b(ref passed, ref failed, vecDir, outDir);
    }

    static void TestModelOptInner(ref int passed, ref int failed, string vecDir, string outDir) {
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

    static void TestModelShape_circle(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_circle.msgpack");
            var r = new MsgPackReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new MsgPackWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_circle.msgpack")!);
            File.WriteAllBytes($"{outDir}/Shape_circle.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_circle mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_circle.json");
            var r = new JsonReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new JsonWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_circle.json")!);
            File.WriteAllBytes($"{outDir}/Shape_circle.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_circle json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_circle.unformatted.json");
            var r = new JsonReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new JsonWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_circle.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Shape_circle.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_circle unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_circle.gron");
            var r = new GronReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new GronWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_circle.gron")!);
            File.WriteAllBytes($"{outDir}/Shape_circle.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_circle gron: {e.Message}"); }
    }

    static void TestModelShape_rect(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_rect.msgpack");
            var r = new MsgPackReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new MsgPackWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_rect.msgpack")!);
            File.WriteAllBytes($"{outDir}/Shape_rect.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_rect mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_rect.json");
            var r = new JsonReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new JsonWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_rect.json")!);
            File.WriteAllBytes($"{outDir}/Shape_rect.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_rect json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_rect.unformatted.json");
            var r = new JsonReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new JsonWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_rect.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Shape_rect.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_rect unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Shape_rect.gron");
            var r = new GronReader(data);
            var obj = ShapeMethods.ShapeCodec.Decode(r);
            var w = new GronWriter();
            ShapeMethods.ShapeCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Shape_rect.gron")!);
            File.WriteAllBytes($"{outDir}/Shape_rect.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Shape_rect gron: {e.Message}"); }
    }

    static void TestModelIdent_name(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_name.msgpack");
            var r = new MsgPackReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new MsgPackWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_name.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ident_name.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_name mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_name.json");
            var r = new JsonReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new JsonWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_name.json")!);
            File.WriteAllBytes($"{outDir}/Ident_name.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_name json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_name.unformatted.json");
            var r = new JsonReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new JsonWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_name.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ident_name.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_name unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_name.gron");
            var r = new GronReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new GronWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_name.gron")!);
            File.WriteAllBytes($"{outDir}/Ident_name.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_name gron: {e.Message}"); }
    }

    static void TestModelIdent_number(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_number.msgpack");
            var r = new MsgPackReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new MsgPackWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_number.msgpack")!);
            File.WriteAllBytes($"{outDir}/Ident_number.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_number mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_number.json");
            var r = new JsonReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new JsonWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_number.json")!);
            File.WriteAllBytes($"{outDir}/Ident_number.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_number json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_number.unformatted.json");
            var r = new JsonReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new JsonWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_number.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Ident_number.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_number unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Ident_number.gron");
            var r = new GronReader(data);
            var obj = IdentMethods.IdentCodec.Decode(r);
            var w = new GronWriter();
            IdentMethods.IdentCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Ident_number.gron")!);
            File.WriteAllBytes($"{outDir}/Ident_number.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Ident_number gron: {e.Message}"); }
    }

    static void TestModelResultMsg_ok(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_ok.msgpack");
            var r = new MsgPackReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new MsgPackWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_ok.msgpack")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_ok.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_ok mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_ok.json");
            var r = new JsonReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new JsonWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_ok.json")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_ok.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_ok json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_ok.unformatted.json");
            var r = new JsonReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new JsonWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_ok.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_ok.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_ok unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_ok.gron");
            var r = new GronReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new GronWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_ok.gron")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_ok.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_ok gron: {e.Message}"); }
    }

    static void TestModelResultMsg_err(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_err.msgpack");
            var r = new MsgPackReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new MsgPackWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_err.msgpack")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_err.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_err mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_err.json");
            var r = new JsonReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new JsonWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_err.json")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_err.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_err json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_err.unformatted.json");
            var r = new JsonReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new JsonWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_err.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_err.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_err unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ResultMsg_err.gron");
            var r = new GronReader(data);
            var obj = ResultMsgMethods.ResultMsgCodec.Decode(r);
            var w = new GronWriter();
            ResultMsgMethods.ResultMsgCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ResultMsg_err.gron")!);
            File.WriteAllBytes($"{outDir}/ResultMsg_err.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ResultMsg_err gron: {e.Message}"); }
    }

    static void TestModelTagged_tag(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_tag.msgpack");
            var r = new MsgPackReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new MsgPackWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_tag.msgpack")!);
            File.WriteAllBytes($"{outDir}/Tagged_tag.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_tag mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_tag.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_tag.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_tag.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_tag json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_tag.unformatted.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_tag.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_tag.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_tag unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_tag.gron");
            var r = new GronReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new GronWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_tag.gron")!);
            File.WriteAllBytes($"{outDir}/Tagged_tag.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_tag gron: {e.Message}"); }
    }

    static void TestModelTagged_score(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_score.msgpack");
            var r = new MsgPackReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new MsgPackWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_score.msgpack")!);
            File.WriteAllBytes($"{outDir}/Tagged_score.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_score mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_score.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_score.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_score.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_score json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_score.unformatted.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_score.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_score.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_score unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_score.gron");
            var r = new GronReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new GronWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_score.gron")!);
            File.WriteAllBytes($"{outDir}/Tagged_score.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_score gron: {e.Message}"); }
    }

    static void TestModelTagged_active(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_active.msgpack");
            var r = new MsgPackReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new MsgPackWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_active.msgpack")!);
            File.WriteAllBytes($"{outDir}/Tagged_active.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_active mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_active.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_active.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_active.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_active json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_active.unformatted.json");
            var r = new JsonReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new JsonWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_active.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/Tagged_active.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_active unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/Tagged_active.gron");
            var r = new GronReader(data);
            var obj = TaggedMethods.TaggedCodec.Decode(r);
            var w = new GronWriter();
            TaggedMethods.TaggedCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/Tagged_active.gron")!);
            File.WriteAllBytes($"{outDir}/Tagged_active.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL Tagged_active gron: {e.Message}"); }
    }

    static void TestModelOptUnionHolder_shape(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_shape.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_shape.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_shape.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_shape mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_shape.json");
            var r = new JsonReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_shape.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_shape.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_shape json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_shape.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_shape.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_shape.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_shape unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_shape.gron");
            var r = new GronReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new GronWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_shape.gron")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_shape.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_shape gron: {e.Message}"); }
    }

    static void TestModelOptUnionHolder_id(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_id.msgpack");
            var r = new MsgPackReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new MsgPackWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_id.msgpack")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_id.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_id mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_id.json");
            var r = new JsonReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_id.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_id.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_id json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_id.unformatted.json");
            var r = new JsonReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new JsonWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_id.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_id.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_id unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/OptUnionHolder_id.gron");
            var r = new GronReader(data);
            var obj = OptUnionHolderMethods.OptUnionHolderCodec.Decode(r);
            var w = new GronWriter();
            OptUnionHolderMethods.OptUnionHolderCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/OptUnionHolder_id.gron")!);
            File.WriteAllBytes($"{outDir}/OptUnionHolder_id.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL OptUnionHolder_id gron: {e.Message}"); }
    }

    static void TestModelMixedUnion_point(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_point.msgpack");
            var r = new MsgPackReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_point.msgpack")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_point.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_point mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_point.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_point.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_point.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_point json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_point.unformatted.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_point.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_point.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_point unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_point.gron");
            var r = new GronReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new GronWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_point.gron")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_point.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_point gron: {e.Message}"); }
    }

    static void TestModelMixedUnion_label(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_label.msgpack");
            var r = new MsgPackReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_label.msgpack")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_label.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_label mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_label.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_label.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_label.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_label json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_label.unformatted.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_label.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_label.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_label unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_label.gron");
            var r = new GronReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new GronWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_label.gron")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_label.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_label gron: {e.Message}"); }
    }

    static void TestModelMixedUnion_count(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_count.msgpack");
            var r = new MsgPackReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_count.msgpack")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_count.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_count mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_count.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_count.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_count.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_count json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_count.unformatted.json");
            var r = new JsonReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new JsonWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_count.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_count.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_count unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/MixedUnion_count.gron");
            var r = new GronReader(data);
            var obj = MixedUnionMethods.MixedUnionCodec.Decode(r);
            var w = new GronWriter();
            MixedUnionMethods.MixedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/MixedUnion_count.gron")!);
            File.WriteAllBytes($"{outDir}/MixedUnion_count.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL MixedUnion_count gron: {e.Message}"); }
    }

    static void TestModelNestedUnion_result(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_result.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_result.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_result.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_result mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_result.json");
            var r = new JsonReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new JsonWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_result.json")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_result.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_result json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_result.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new JsonWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_result.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_result.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_result unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_result.gron");
            var r = new GronReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new GronWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_result.gron")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_result.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_result gron: {e.Message}"); }
    }

    static void TestModelNestedUnion_shape(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_shape.msgpack");
            var r = new MsgPackReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_shape.msgpack")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_shape.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_shape mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_shape.json");
            var r = new JsonReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new JsonWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_shape.json")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_shape.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_shape json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_shape.unformatted.json");
            var r = new JsonReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new JsonWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_shape.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_shape.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_shape unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/NestedUnion_shape.gron");
            var r = new GronReader(data);
            var obj = NestedUnionMethods.NestedUnionCodec.Decode(r);
            var w = new GronWriter();
            NestedUnionMethods.NestedUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/NestedUnion_shape.gron")!);
            File.WriteAllBytes($"{outDir}/NestedUnion_shape.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL NestedUnion_shape gron: {e.Message}"); }
    }

    static void TestModelScalarUnion_s(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_s.msgpack");
            var r = new MsgPackReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_s.msgpack")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_s.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_s mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_s.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_s.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_s.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_s json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_s.unformatted.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_s.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_s.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_s unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_s.gron");
            var r = new GronReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new GronWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_s.gron")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_s.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_s gron: {e.Message}"); }
    }

    static void TestModelScalarUnion_i(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_i.msgpack");
            var r = new MsgPackReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_i.msgpack")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_i.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_i mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_i.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_i.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_i.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_i json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_i.unformatted.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_i.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_i.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_i unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_i.gron");
            var r = new GronReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new GronWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_i.gron")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_i.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_i gron: {e.Message}"); }
    }

    static void TestModelScalarUnion_f(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_f.msgpack");
            var r = new MsgPackReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_f.msgpack")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_f.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_f mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_f.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_f.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_f.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_f json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_f.unformatted.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_f.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_f.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_f unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_f.gron");
            var r = new GronReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new GronWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_f.gron")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_f.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_f gron: {e.Message}"); }
    }

    static void TestModelScalarUnion_b(ref int passed, ref int failed, string vecDir, string outDir) {
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_b.msgpack");
            var r = new MsgPackReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new MsgPackWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_b.msgpack")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_b.msgpack", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_b mp: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_b.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_b.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_b.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_b json: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_b.unformatted.json");
            var r = new JsonReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new JsonWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_b.unformatted.json")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_b.unformatted.json", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_b unformatted: {e.Message}"); }
        try {
            var data = File.ReadAllBytes($"{vecDir}/ScalarUnion_b.gron");
            var r = new GronReader(data);
            var obj = ScalarUnionMethods.ScalarUnionCodec.Decode(r);
            var w = new GronWriter();
            ScalarUnionMethods.ScalarUnionCodec.Encode(w, obj);
            Directory.CreateDirectory(Path.GetDirectoryName($"{outDir}/ScalarUnion_b.gron")!);
            File.WriteAllBytes($"{outDir}/ScalarUnion_b.gron", w.ToBytes());
            passed++;
        } catch (Exception e) { failed++; Console.WriteLine($"FAIL ScalarUnion_b gron: {e.Message}"); }
    }

}
