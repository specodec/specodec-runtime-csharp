using System.Collections.Generic;
using System.Text;

namespace Specodec;

public class GronReader : SpecReader
{
    private readonly List<(string Path, string Value)> _lines = new();
    private int _cursor;
    private readonly List<CtxInfo> _ctx = new();

    private record CtxInfo(string Prefix, string Type, int Index = -1);

    public GronReader(byte[] data)
    {
        var text = Encoding.UTF8.GetString(data);
        foreach (var raw in text.Split('\n'))
        {
            var line = raw.Trim();
            if (line.Length == 0) continue;
            var eq = line.IndexOf(" = ", StringComparison.Ordinal);
            if (eq < 0) continue;
            var path = line.Substring(0, eq);
            var value = line.Substring(eq + 3);
            if (value.EndsWith(';')) value = value.Substring(0, value.Length - 1);
            _lines.Add((path, value));
        }
    }

    private string Unescape(string s)
    {
        if (s.Length < 2 || s[0] != '"' || s[^1] != '"')
            throw new SCodecError("internal", "gron: expected quoted string");
        var sb = new StringBuilder();
        var i = 1;
        while (i < s.Length - 1)
        {
            if (s[i] == '\\')
            {
                i++;
                switch (s[i])
                {
                    case '"': sb.Append('"'); break;
                    case '\\': sb.Append('\\'); break;
                    case '/': sb.Append('/'); break;
                    case 'b': sb.Append('\b'); break;
                    case 'f': sb.Append('\f'); break;
                    case 'n': sb.Append('\n'); break;
                    case 'r': sb.Append('\r'); break;
                    case 't': sb.Append('\t'); break;
                    case 'u':
                        if (i + 5 > s.Length - 1)
                            throw new SCodecError("internal", "gron: incomplete unicode escape");
                        var cp = int.Parse(s.Substring(i + 1, 4), System.Globalization.NumberStyles.HexNumber);
                        i += 4;
                        if (cp >= 0xD800 && cp <= 0xDBFF)
                        {
                            if (i + 1 < s.Length - 1 && s[i + 1] == '\\' && s[i + 2] == 'u')
                            {
                                var low = int.Parse(s.Substring(i + 3, 4), System.Globalization.NumberStyles.HexNumber);
                                if (low >= 0xDC00 && low <= 0xDFFF)
                                {
                                    cp = 0x10000 + (cp - 0xD800) * 0x400 + (low - 0xDC00);
                                    i += 6;
                                }
                            }
                        }
                        sb.Append(char.ConvertFromUtf32(cp));
                        break;
                    default:
                        throw new SCodecError("internal", $"gron: invalid escape '\\{s[i]}'");
                }
            }
            else
            {
                sb.Append(s[i]);
            }
            i++;
        }
        return sb.ToString();
    }

    public string ReadString() => Unescape(_lines[_cursor++].Value);
    public bool ReadBool()
    {
        var v = _lines[_cursor++].Value;
        if (v == "true") return true;
        if (v == "false") return false;
        throw new SCodecError("internal", $"gron: expected bool, got '{v}'");
    }
    public int ReadInt32() => int.Parse(_lines[_cursor++].Value);
    public long ReadInt64() => long.Parse(Unescape(_lines[_cursor++].Value));
    public uint ReadUint32() => uint.Parse(_lines[_cursor++].Value);
    public ulong ReadUint64() => ulong.Parse(Unescape(_lines[_cursor++].Value));

    public float ReadFloat32()
    {
        var v = _lines[_cursor++].Value;
        if (v == "\"NaN\"") return float.NaN;
        if (v == "\"Infinity\"") return float.PositiveInfinity;
        if (v == "\"-Infinity\"") return float.NegativeInfinity;
        return float.Parse(v);
    }

    public double ReadFloat64()
    {
        var v = _lines[_cursor++].Value;
        if (v == "\"NaN\"") return double.NaN;
        if (v == "\"Infinity\"") return double.PositiveInfinity;
        if (v == "\"-Infinity\"") return double.NegativeInfinity;
        return double.Parse(v);
    }

    public void ReadNull()
    {
        if (_lines[_cursor++].Value != "null") throw new SCodecError("internal", "gron: expected null");
    }

    public byte[] ReadBytes()
    {
        var b64 = Unescape(_lines[_cursor++].Value);
        try { return Convert.FromBase64String(b64); }
        catch { throw new SCodecError("internal", "gron: invalid base64"); }
    }

    public string ReadEnum() => Unescape(_lines[_cursor++].Value);

    public void BeginObject()
    {
        var line = _lines[_cursor++];
        _ctx.Add(new CtxInfo(line.Path, "object"));
    }

    public bool HasNextField()
    {
        if (_cursor >= _lines.Count) return false;
        var pfx = _ctx[^1].Prefix + ".";
        var p = _lines[_cursor].Path;
        if (!p.StartsWith(pfx)) return false;
        var rem = p.Substring(pfx.Length);
        return !rem.Contains('.') && !rem.Contains('[');
    }

    public string ReadFieldName()
    {
        var pfx = _ctx[^1].Prefix + ".";
        return _lines[_cursor].Path.Substring(pfx.Length);
    }

    public void EndObject() { _ctx.RemoveAt(_ctx.Count - 1); }

    public void BeginArray()
    {
        var line = _lines[_cursor++];
        _ctx.Add(new CtxInfo(line.Path, "array", -1));
    }

    public bool HasNextElement()
    {
        if (_cursor >= _lines.Count) return false;
        var arr = _ctx[^1];
        var ni = arr.Index + 1;
        var exp = arr.Prefix + $"[{ni}]";
        var p = _lines[_cursor].Path;
        var hasNext = p == exp || p.StartsWith(exp + ".") || p.StartsWith(exp + "[");
        if (hasNext)
        {
            _ctx[^1] = arr with { Index = ni };
        }
        return hasNext;
    }

    public void EndArray() { _ctx.RemoveAt(_ctx.Count - 1); }

    public bool IsNull() => _cursor < _lines.Count && _lines[_cursor].Value == "null";

    public void Skip()
    {
        var sp = _lines[_cursor++].Path;
        while (_cursor < _lines.Count)
        {
            var np = _lines[_cursor].Path;
            if (np.Length > sp.Length && (np.StartsWith(sp + ".") || np.StartsWith(sp + "["))) _cursor++;
            else break;
        }
    }
}
