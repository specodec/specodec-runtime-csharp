using System.Collections.Generic;
using System.Text;

namespace Specodec;

public class GronWriter : SpecWriter
{
    private readonly List<string> _lines = new();
    private readonly List<string> _segments = new() { "json" };
    private readonly List<NestInfo> _nesting = new();

    private class NestInfo
    {
        public int Depth { get; }
        public int ArrayIndex { get; set; } = -1;
        public NestInfo(int depth, int arrayIndex = -1) { Depth = depth; ArrayIndex = arrayIndex; }
    }

    private string BuildPath()
    {
        var r = _segments[0];
        for (var i = 1; i < _segments.Count; i++)
        {
            if (_segments[i].StartsWith('[')) r += _segments[i];
            else r += "." + _segments[i];
        }
        return r;
    }

    private static string Escape(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            switch ((int)c)
            {
                case 0x22: sb.Append("\\\""); break;
                case 0x5C: sb.Append("\\\\"); break;
                case 0x08: sb.Append("\\b"); break;
                case 0x0C: sb.Append("\\f"); break;
                case 0x0A: sb.Append("\\n"); break;
                case 0x0D: sb.Append("\\r"); break;
                case 0x09: sb.Append("\\t"); break;
                case >= 0 and <= 0x1F: sb.Append($"\\u{((int)c).ToString("x4")}"); break;
                default: sb.Append(c); break;
            }
        }
        return sb.ToString();
    }

    private void Emit(string raw)
    {
        _lines.Add($"{BuildPath()} = {raw};");
    }

    public void WriteString(string value) => Emit($"\"{Escape(value)}\"");
    public void WriteBool(bool value) => Emit(value ? "true" : "false");
    public void WriteInt32(int value) => Emit(value.ToString());
    public void WriteInt64(long value) => Emit($"\"{value}\"");
    public void WriteUint32(uint value) => Emit(value.ToString());
    public void WriteUint64(ulong value) => Emit($"\"{value}\"");

    public void WriteFloat32(float value)
    {
        if (float.IsNaN(value))
            Emit("\"NaN\"");
        else if (float.IsInfinity(value))
            Emit(value > 0 ? "\"Infinity\"" : "\"-Infinity\"");
        else
            Emit(FloatFmt.FormatFloat32(value));
    }

    public void WriteFloat64(double value)
    {
        if (double.IsNaN(value))
            Emit("\"NaN\"");
        else if (double.IsInfinity(value))
            Emit(value > 0 ? "\"Infinity\"" : "\"-Infinity\"");
        else
            Emit(FloatFmt.FormatFloat64(value));
    }

    public void WriteNull() => Emit("null");
    public void WriteBytes(byte[] value) => Emit($"\"{Convert.ToBase64String(value)}\"");
    public void WriteEnum(string value) => Emit($"\"{Escape(value)}\"");

    public void BeginObject(int fieldCount)
    {
        _lines.Add($"{BuildPath()} = {{}};");
        _nesting.Add(new NestInfo(_segments.Count));
    }

    public void WriteField(string name)
    {
        var top = _nesting[^1];
        if (_segments.Count > top.Depth) _segments[^1] = name;
        else _segments.Add(name);
    }

    public void EndObject()
    {
        var info = _nesting[^1];
        _nesting.RemoveAt(_nesting.Count - 1);
        while (_segments.Count > info.Depth) _segments.RemoveAt(_segments.Count - 1);
    }

    public void BeginArray(int elementCount)
    {
        _lines.Add($"{BuildPath()} = [];");
        _nesting.Add(new NestInfo(_segments.Count, -1));
    }

    public void NextElement()
    {
        var info = _nesting[^1];
        info.ArrayIndex++;
        var seg = $"[{info.ArrayIndex}]";
        if (_segments.Count > info.Depth) _segments[^1] = seg;
        else _segments.Add(seg);
    }

    public void EndArray()
    {
        var info = _nesting[^1];
        _nesting.RemoveAt(_nesting.Count - 1);
        while (_segments.Count > info.Depth) _segments.RemoveAt(_segments.Count - 1);
    }

    public byte[] ToBytes() => Encoding.UTF8.GetBytes(string.Join("\n", _lines) + "\n");
}
