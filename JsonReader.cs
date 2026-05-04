using System.Collections.Generic;
using System.Text;

namespace Specodec;

public class JsonReader : SpecReader
{
    private readonly string _src;
    private int _pos;
    private readonly List<bool> _firstField = new();
    private readonly List<bool> _firstElem = new();

    public JsonReader(byte[] data)
    {
        _src = Encoding.UTF8.GetString(data);
    }

    public int Pos() => _pos;

    private void Ws()
    {
        while (_pos < _src.Length)
        {
            var c = (int)_src[_pos];
            if (c == 0x20 || c == 0x09 || c == 0x0A || c == 0x0D) _pos++;
            else break;
        }
    }

    private char Peek()
    {
        Ws();
        if (_pos >= _src.Length) throw new SCodecError("internal", "json: unexpected end of input");
        return _src[_pos];
    }

    private char Read()
    {
        Ws();
        if (_pos >= _src.Length) throw new SCodecError("internal", "json: unexpected end of input");
        return _src[_pos++];
    }

    private void Expect(char ch)
    {
        var got = Read();
        if (got != ch) throw new SCodecError("internal", $"json: expected '{ch}', got '{got}' at {_pos - 1}");
    }

    private string ParseString()
    {
        Expect('"');
        var parts = new StringBuilder();
        while (_pos < _src.Length)
        {
            var c = _src[_pos];
            var code = (int)c;
            if (code == 0x22) { _pos++; return parts.ToString(); }
            if (code == 0x5C)
            {
                _pos++;
                if (_pos >= _src.Length) throw new SCodecError("internal", "json: unexpected end of string escape");
                var esc = _src[_pos];
                switch ((int)esc)
                {
                    case 0x22: parts.Append('"'); _pos++; break;
                    case 0x5C: parts.Append('\\'); _pos++; break;
                    case 0x2F: parts.Append('/'); _pos++; break;
                    case 0x62: parts.Append('\b'); _pos++; break;
                    case 0x66: parts.Append('\f'); _pos++; break;
                    case 0x6E: parts.Append('\n'); _pos++; break;
                    case 0x72: parts.Append('\r'); _pos++; break;
                    case 0x74: parts.Append('\t'); _pos++; break;
                    case 0x75:
                        _pos++;
                        if (_pos + 4 > _src.Length) throw new SCodecError("internal", "json: incomplete unicode escape");
                        var hex = _src.Substring(_pos, 4);
                        var cp = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                        _pos += 4;
                        if (cp >= 0xD800 && cp <= 0xDBFF)
                        {
                            if (_pos + 6 <= _src.Length && _src[_pos] == '\\' && _src[_pos + 1] == 'u')
                            {
                                _pos += 2;
                                var hex2 = _src.Substring(_pos, 4);
                                var low = int.Parse(hex2, System.Globalization.NumberStyles.HexNumber);
                                _pos += 4;
                                if (low >= 0xDC00 && low <= 0xDFFF)
                                {
                                    cp = 0x10000 + (cp - 0xD800) * 0x400 + (low - 0xDC00);
                                }
                                else
                                {
                                    throw new SCodecError("internal", "json: expected low surrogate");
                                }
                            }
                            else
                            {
                                throw new SCodecError("internal", "json: expected low surrogate");
                            }
                        }
                        parts.Append((char)cp);
                        break;
                    default:
                        throw new SCodecError("internal", $"json: invalid escape '\\{esc}'");
                }
            }
            else if (code < 0x20)
            {
                throw new SCodecError("internal", $"json: unescaped control char U+{code.ToString("x4")}");
            }
            else
            {
                parts.Append(c); _pos++;
            }
        }
        throw new SCodecError("internal", "json: unterminated string");
    }

    private string ParseNumberRaw()
    {
        Ws();
        var start = _pos;
        if (_pos < _src.Length && _src[_pos] == '-') _pos++;
        if (_pos >= _src.Length) throw new SCodecError("internal", "json: unexpected end of number");
        if (_src[_pos] == '0') { _pos++; }
        else if (_src[_pos] >= '1' && _src[_pos] <= '9')
        {
            _pos++;
            while (_pos < _src.Length && _src[_pos] >= '0' && _src[_pos] <= '9') _pos++;
        }
        else throw new SCodecError("internal", "json: invalid number");
        if (_pos < _src.Length && _src[_pos] == '.')
        {
            _pos++;
            if (_pos >= _src.Length || _src[_pos] < '0' || _src[_pos] > '9') throw new SCodecError("internal", "json: invalid fraction");
            while (_pos < _src.Length && _src[_pos] >= '0' && _src[_pos] <= '9') _pos++;
        }
        if (_pos < _src.Length && (_src[_pos] == 'e' || _src[_pos] == 'E'))
        {
            _pos++;
            if (_pos < _src.Length && (_src[_pos] == '+' || _src[_pos] == '-')) _pos++;
            if (_pos >= _src.Length || _src[_pos] < '0' || _src[_pos] > '9') throw new SCodecError("internal", "json: invalid exponent");
            while (_pos < _src.Length && _src[_pos] >= '0' && _src[_pos] <= '9') _pos++;
        }
        return _src.Substring(start, _pos - start);
    }

    public string ReadString() => ParseString();

    public bool ReadBool()
    {
        var ch = Peek();
        if (ch == 't') { foreach (var c in "true") if (Read() != c) throw new SCodecError("internal", "json: expected true"); return true; }
        if (ch == 'f') { foreach (var c in "false") if (Read() != c) throw new SCodecError("internal", "json: expected false"); return false; }
        throw new SCodecError("internal", $"json: expected bool, got '{ch}'");
    }

    public int ReadInt32()
    {
        var raw = ParseNumberRaw();
        return int.TryParse(raw, out var v) ? v : throw new SCodecError("internal", $"json: invalid int32: {raw}");
    }

    public long ReadInt64()
    {
        if (Peek() == '"')
        {
            var s = ParseString();
            return long.TryParse(s, out var v) ? v : throw new SCodecError("internal", $"json: invalid int64: {s}");
        }
        var raw = ParseNumberRaw();
        return long.TryParse(raw, out var v2) ? v2 : throw new SCodecError("internal", $"json: invalid int64: {raw}");
    }

    public uint ReadUint32()
    {
        var raw = ParseNumberRaw();
        return uint.TryParse(raw, out var v) ? v : throw new SCodecError("internal", $"json: invalid uint32: {raw}");
    }

    public ulong ReadUint64()
    {
        if (Peek() == '"')
        {
            var s = ParseString();
            return ulong.TryParse(s, out var v) ? v : throw new SCodecError("internal", $"json: invalid uint64: {s}");
        }
        var raw = ParseNumberRaw();
        return ulong.TryParse(raw, out var v2) ? v2 : throw new SCodecError("internal", $"json: invalid uint64: {raw}");
    }

    public float ReadFloat32()
    {
        if (Peek() == '"')
        {
            var s = ParseString();
            if (s == "NaN") return float.NaN;
            if (s == "Infinity") return float.PositiveInfinity;
            if (s == "-Infinity") return float.NegativeInfinity;
            return float.TryParse(s, out var v) ? v : throw new SCodecError("internal", $"json: invalid float32: {s}");
        }
        var raw = ParseNumberRaw();
        return float.TryParse(raw, out var v2) ? v2 : throw new SCodecError("internal", $"json: invalid float32: {raw}");
    }

    public double ReadFloat64()
    {
        if (Peek() == '"')
        {
            var s = ParseString();
            if (s == "NaN") return double.NaN;
            if (s == "Infinity") return double.PositiveInfinity;
            if (s == "-Infinity") return double.NegativeInfinity;
            return double.TryParse(s, out var v) ? v : throw new SCodecError("internal", $"json: invalid float64: {s}");
        }
        var raw = ParseNumberRaw();
        return double.TryParse(raw, out var v2) ? v2 : throw new SCodecError("internal", $"json: invalid float64: {raw}");
    }

    public void ReadNull()
    {
        foreach (var c in "null") if (Read() != c) throw new SCodecError("internal", "json: expected null");
    }

    public byte[] ReadBytes()
    {
        var s = ParseString();
        try { return Convert.FromBase64String(s); }
        catch { throw new SCodecError("internal", "json: invalid base64"); }
    }

    public string ReadEnum() => ParseString();

    public void BeginObject()
    {
        Expect('{');
        _firstField.Add(true);
    }

    public bool HasNextField()
    {
        var ch = Peek();
        if (ch == '}')
        {
            _firstField.RemoveAt(_firstField.Count - 1);
            return false;
        }
        var top = _firstField.Count - 1;
        if (!_firstField[top])
        {
            if (ch != ',') throw new SCodecError("internal", $"json: expected ',' or '}}', got '{ch}'");
            _pos++;
        }
        else
        {
            _firstField[top] = false;
        }
        return true;
    }

    public string ReadFieldName()
    {
        var key = ParseString();
        Ws();
        if (_pos < _src.Length && _src[_pos] == ':')
        {
            _pos++;
        }
        else
        {
            throw new SCodecError("internal", $"json: expected ':' after field name '{key}'");
        }
        return key;
    }

    public void EndObject() { Expect('}'); }

    public void BeginArray()
    {
        Expect('[');
        _firstElem.Add(true);
    }

    public bool HasNextElement()
    {
        var ch = Peek();
        if (ch == ']')
        {
            _firstElem.RemoveAt(_firstElem.Count - 1);
            return false;
        }
        var top = _firstElem.Count - 1;
        if (!_firstElem[top])
        {
            if (ch != ',') throw new SCodecError("internal", $"json: expected ',' or ']', got '{ch}'");
            _pos++;
        }
        else
        {
            _firstElem[top] = false;
        }
        return true;
    }

    public void EndArray() { Expect(']'); }

    public bool IsNull() => Peek() == 'n';

    public void Skip()
    {
        Ws();
        if (_pos >= _src.Length) throw new SCodecError("internal", "json: unexpected end of input");
        var ch = _src[_pos];
        switch (ch)
        {
            case '"':
                _pos++;
                while (_pos < _src.Length)
                {
                    if (_src[_pos] == '\\') _pos += 2;
                    else if (_src[_pos] == '"') { _pos++; return; }
                    else _pos++;
                }
                throw new SCodecError("internal", "json: unterminated string in skip");
            case '{':
                BeginObject();
                while (HasNextField())
                {
                    ReadFieldName();
                    Skip();
                }
                EndObject();
                break;
            case '[':
                BeginArray();
                while (HasNextElement())
                {
                    Skip();
                }
                EndArray();
                break;
            case 't':
                foreach (var c in "true") if (Read() != c) throw new SCodecError("internal", "json: skip expected true");
                break;
            case 'f':
                foreach (var c in "false") if (Read() != c) throw new SCodecError("internal", "json: skip expected false");
                break;
            case 'n':
                foreach (var c in "null") if (Read() != c) throw new SCodecError("internal", "json: skip expected null");
                break;
            default:
                if ((ch >= '0' && ch <= '9') || ch == '-') ParseNumberRaw();
                else throw new SCodecError("internal", $"json: unexpected '{ch}' in skip");
                break;
        }
    }
}
