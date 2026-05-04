using System.Text;

namespace Specodec;

public class JsonWriter : SpecWriter
{
    private readonly StringBuilder _sb = new();
    private readonly List<bool> _firstItem = new();

    private void Escape(string s)
    {
        foreach (var c in s)
        {
            switch ((int)c)
            {
                case 0x22: _sb.Append("\\\""); break;
                case 0x5C: _sb.Append("\\\\"); break;
                case 0x08: _sb.Append("\\b"); break;
                case 0x0C: _sb.Append("\\f"); break;
                case 0x0A: _sb.Append("\\n"); break;
                case 0x0D: _sb.Append("\\r"); break;
                case 0x09: _sb.Append("\\t"); break;
                case >= 0 and <= 0x1F: _sb.Append($"\\u{((int)c).ToString("x4")}"); break;
                default: _sb.Append(c); break;
            }
        }
    }

    public void WriteString(string value)
    {
        _sb.Append('"');
        Escape(value);
        _sb.Append('"');
    }

    public void WriteBool(bool value)
    {
        _sb.Append(value ? "true" : "false");
    }

    public void WriteInt32(int value)
    {
        _sb.Append(value);
    }

    public void WriteInt64(long value)
    {
        _sb.Append('"');
        _sb.Append(value);
        _sb.Append('"');
    }

    public void WriteUint32(uint value)
    {
        _sb.Append(value);
    }

    public void WriteUint64(ulong value)
    {
        _sb.Append('"');
        _sb.Append(value);
        _sb.Append('"');
    }

    public void WriteFloat32(float value)
    {
        if (float.IsNaN(value))
        {
            _sb.Append("\"NaN\"");
        }
        else if (float.IsInfinity(value))
        {
            _sb.Append(value > 0 ? "\"Infinity\"" : "\"-Infinity\"");
        }
        else
        {
            _sb.Append(FloatFmt.FormatFloat32(value));
        }
    }

    public void WriteFloat64(double value)
    {
        if (double.IsNaN(value))
        {
            _sb.Append("\"NaN\"");
        }
        else if (double.IsInfinity(value))
        {
            _sb.Append(value > 0 ? "\"Infinity\"" : "\"-Infinity\"");
        }
        else
        {
            _sb.Append(FloatFmt.FormatFloat64(value));
        }
    }

    public void WriteNull()
    {
        _sb.Append("null");
    }

    public void WriteBytes(byte[] value)
    {
        _sb.Append('"');
        _sb.Append(Convert.ToBase64String(value));
        _sb.Append('"');
    }

    public void WriteEnum(string value)
    {
        _sb.Append('"');
        Escape(value);
        _sb.Append('"');
    }

    public void BeginObject(int fieldCount)
    {
        _sb.Append('{');
        _firstItem.Add(true);
    }

    public void WriteField(string name)
    {
        var top = _firstItem.Count - 1;
        if (!_firstItem[top]) _sb.Append(',');
        _firstItem[top] = false;
        _sb.Append('"');
        Escape(name);
        _sb.Append('"');
        _sb.Append(':');
    }

    public void EndObject()
    {
        _firstItem.RemoveAt(_firstItem.Count - 1);
        _sb.Append('}');
    }

    public void BeginArray(int elementCount)
    {
        _sb.Append('[');
        _firstItem.Add(true);
    }

    public void NextElement()
    {
        var top = _firstItem.Count - 1;
        if (!_firstItem[top]) _sb.Append(',');
        _firstItem[top] = false;
    }

    public void EndArray()
    {
        _firstItem.RemoveAt(_firstItem.Count - 1);
        _sb.Append(']');
    }

    public byte[] ToBytes() => Encoding.UTF8.GetBytes(_sb.ToString());
}
