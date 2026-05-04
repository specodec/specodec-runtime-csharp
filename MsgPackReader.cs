using System.Collections.Generic;
using System.Text;

namespace Specodec;

public class MsgPackReader : SpecReader
{
    private readonly byte[] _data;
    private int _pos;
    private readonly List<int> _containerCount = new();

    public MsgPackReader(byte[] data)
    {
        _data = data;
    }

    public int Pos() => _pos;

    private byte ReadByte()
    {
        if (_pos >= _data.Length) throw new SCodecError("internal", "msgpack: unexpected end of data");
        return _data[_pos++];
    }

    private uint ReadU8() => ReadByte();

    private uint ReadU16()
    {
        var v = ((uint)_data[_pos] << 8) | _data[_pos + 1];
        _pos += 2;
        return v;
    }

    private uint ReadU32()
    {
        var v = ((uint)_data[_pos] << 24) |
                ((uint)_data[_pos + 1] << 16) |
                ((uint)_data[_pos + 2] << 8) |
                _data[_pos + 3];
        _pos += 4;
        return v;
    }

    private int ReadI16()
    {
        var v = (int)ReadU16();
        return v > 0x7FFF ? v - 0x10000 : v;
    }

    private int ReadI32()
    {
        var v = (long)ReadU32();
        return (int)(v > 0x7FFFFFFF ? v - 0x100000000 : v);
    }

    private float ReadF32()
    {
        var bits = ReadU32();
        return BitConverter.Int32BitsToSingle((int)bits);
    }

    private double ReadF64()
    {
        var hi = (long)ReadU32();
        var lo = (long)ReadU32();
        var bits = (hi << 32) | lo;
        return BitConverter.Int64BitsToDouble(bits);
    }

    private int ReadMapHeader()
    {
        var b = ReadU8();
        if ((b & 0xF0) == 0x80) return (int)(b & 0x0F);
        if (b == 0xDE) return (int)ReadU16();
        if (b == 0xDF) return (int)ReadU32();
        throw new SCodecError("internal", $"msgpack: expected map, got 0x{b:x}");
    }

    private int ReadArrayHeader()
    {
        var b = ReadU8();
        if ((b & 0xF0) == 0x90) return (int)(b & 0x0F);
        if (b == 0xDC) return (int)ReadU16();
        if (b == 0xDD) return (int)ReadU32();
        throw new SCodecError("internal", $"msgpack: expected array, got 0x{b:x}");
    }

    public string ReadString()
    {
        var b = ReadU8();
        var len = b switch
        {
            _ when (b & 0xE0) == 0xA0 => (int)(b & 0x1F),
            0xD9 => (int)ReadU8(),
            0xDA => (int)ReadU16(),
            0xDB => (int)ReadU32(),
            _ => throw new SCodecError("internal", $"msgpack: expected string, got 0x{b:x}")
        };
        var s = Encoding.UTF8.GetString(_data, _pos, len);
        _pos += len;
        return s;
    }

    public long ReadInt()
    {
        var b = ReadU8();
        switch (b)
        {
            case <= 0x7F: return b;
            case >= 0xE0: return b - 0x100;
            case 0xCC: return ReadU8();
            case 0xCD: return ReadU16();
            case 0xCE: return ReadU32();
            case 0xD0: return (sbyte)ReadByte();
            case 0xD1: return ReadI16();
            case 0xD2: return ReadI32();
            case 0xD3:
                {
                    var hi = (long)ReadU32();
                    var lo = (long)ReadU32();
                    return (long)((ulong)hi << 32) | lo;
                }
            case 0xCF:
                {
                    var hi = (long)ReadU32();
                    var lo = (long)ReadU32();
                    return (long)((ulong)hi << 32) | lo;
                }
            default: throw new SCodecError("internal", $"msgpack: expected int, got 0x{b:x}");
        }
    }

    public double ReadFloat()
    {
        var b = ReadU8();
        if (b == 0xCA) return ReadF32();
        if (b == 0xCB) return ReadF64();
        if (b <= 0x7F) return b;
        if (b >= 0xE0) return b - 0x100;
        if (b == 0xCC) return ReadU8();
        if (b == 0xCD) return ReadU16();
        if (b == 0xCE) return ReadU32();
        if (b == 0xCF)
        {
            var hi = ReadU32();
            var lo = ReadU32();
            return (double)((ulong)hi << 32 | lo);
        }
        if (b == 0xD0) return (sbyte)ReadByte();
        if (b == 0xD1) return ReadI16();
        if (b == 0xD2) return ReadI32();
        if (b == 0xD3)
        {
            var hi = ReadU32();
            var lo = ReadU32();
            return (long)((ulong)hi << 32 | lo);
        }
        throw new SCodecError("internal", $"msgpack: expected float, got 0x{b:x}");
    }

    public bool ReadBool()
    {
        var b = ReadU8();
        if (b == 0xC3) return true;
        if (b == 0xC2) return false;
        throw new SCodecError("internal", $"msgpack: expected bool, got 0x{b:x}");
    }

    public void ReadNull()
    {
        var b = ReadU8();
        if (b != 0xC0) throw new SCodecError("internal", $"msgpack: expected null, got 0x{b:x}");
    }

    public int ReadInt32() => (int)ReadInt();
    public uint ReadUint32() => (uint)ReadInt();
    public ulong ReadUint64() => (ulong)ReadInt();
    public long ReadInt64() => ReadInt();
    public float ReadFloat32() => (float)ReadFloat();
    public double ReadFloat64() => ReadFloat();

    public byte[] ReadBytes()
    {
        var b = ReadU8();
        var len = b switch
        {
            0xC4 => (int)ReadU8(),
            0xC5 => (int)ReadU16(),
            0xC6 => (int)ReadU32(),
            _ => throw new SCodecError("internal", $"msgpack: expected bin, got 0x{b:x}")
        };
        var v = new byte[len];
        Array.Copy(_data, _pos, v, 0, len);
        _pos += len;
        return v;
    }

    public string ReadEnum() => ReadString();

    public bool IsNull() => _pos < _data.Length && _data[_pos] == 0xC0;

    public void Skip()
    {
        var b = ReadU8();
        if (b <= 0x7F || b >= 0xE0) return;
        if ((b & 0xF0) == 0x80)
        {
            for (var i = 0; i < (b & 0x0F); i++) { Skip(); Skip(); }
            return;
        }
        if ((b & 0xF0) == 0x90)
        {
            for (var i = 0; i < (b & 0x0F); i++) { Skip(); }
            return;
        }
        if ((b & 0xE0) == 0xA0) { _pos += (int)(b & 0x1F); return; }
        switch (b)
        {
            case 0xC0: case 0xC2: case 0xC3: break;
            case 0xCC: case 0xD0: _pos += 1; break;
            case 0xCD: case 0xD1: _pos += 2; break;
            case 0xCE: case 0xD2: case 0xCA: _pos += 4; break;
            case 0xCF: case 0xD3: case 0xCB: _pos += 8; break;
            case 0xD9: _pos += (int)ReadU8(); break;
            case 0xDA: _pos += (int)ReadU16(); break;
            case 0xDB: _pos += (int)ReadU32(); break;
            case 0xC4: _pos += (int)ReadU8(); break;
            case 0xC5: _pos += (int)ReadU16(); break;
            case 0xC6: _pos += (int)ReadU32(); break;
            case 0xD4: _pos += 2; break;
            case 0xD5: _pos += 3; break;
            case 0xD6: _pos += 5; break;
            case 0xD7: _pos += 9; break;
            case 0xD8: _pos += 17; break;
            case 0xC7: _pos += 1 + (int)ReadU8(); break;
            case 0xC8: _pos += 1 + (int)ReadU16(); break;
            case 0xC9: _pos += 1 + (int)ReadU32(); break;
            case 0xDC: { var n = (int)ReadU16(); for (var i = 0; i < n; i++) Skip(); break; }
            case 0xDD: { var n = (int)ReadU32(); for (var i = 0; i < n; i++) Skip(); break; }
            case 0xDE: { var n = (int)ReadU16(); for (var i = 0; i < n; i++) { Skip(); Skip(); } break; }
            case 0xDF: { var n = (int)ReadU32(); for (var i = 0; i < n; i++) { Skip(); Skip(); } break; }
            default: throw new SCodecError("internal", $"msgpack: unknown format 0x{b:x}");
        }
    }

    public void BeginObject()
    {
        var n = ReadMapHeader();
        _containerCount.Add(n);
    }

    public bool HasNextField()
    {
        var top = _containerCount.Count - 1;
        if (_containerCount[top] > 0)
        {
            _containerCount[top]--;
            return true;
        }
        _containerCount.RemoveAt(top);
        return false;
    }

    public string ReadFieldName() => ReadString();

    public void EndObject() { }

    public void BeginArray()
    {
        var n = ReadArrayHeader();
        _containerCount.Add(n);
    }

    public bool HasNextElement()
    {
        var top = _containerCount.Count - 1;
        if (_containerCount[top] > 0)
        {
            _containerCount[top]--;
            return true;
        }
        _containerCount.RemoveAt(top);
        return false;
    }

    public void EndArray() { }
}
