using System.Collections.Generic;
using System.Text;

namespace Specodec;

public class MsgPackWriter : SpecWriter
{
    private readonly List<byte> _buf = new();

    private void WriteByte(byte b) => _buf.Add(b);
    private void WriteU16(uint v) { _buf.Add((byte)(v >> 8)); _buf.Add((byte)v); }
    private void WriteU32(uint v) { _buf.Add((byte)(v >> 24)); _buf.Add((byte)(v >> 16)); _buf.Add((byte)(v >> 8)); _buf.Add((byte)v); }
    private void WriteU64(ulong v) { WriteU32((uint)(v >> 32)); WriteU32((uint)v); }

    public void WriteString(string value)
    {
        var bytes = Encoding.UTF8.GetBytes(value);
        var len = bytes.Length;
        if (len <= 0x1F) WriteByte((byte)(0xA0 | len));
        else if (len <= 0xFF) { WriteByte(0xD9); WriteByte((byte)len); }
        else if (len <= 0xFFFF) { WriteByte(0xDA); WriteU16((uint)len); }
        else { WriteByte(0xDB); WriteU32((uint)len); }
        _buf.AddRange(bytes);
    }

    public void WriteBool(bool value) => WriteByte(value ? (byte)0xC3 : (byte)0xC2);

    public void WriteInt32(int value)
    {
        if (value >= 0 && value <= 0x7F) WriteByte((byte)value);
        else if (value >= -0x20 && value <= -1) WriteByte((byte)value);
        else if (value >= 0 && value <= 0xFF) { WriteByte(0xCC); WriteByte((byte)value); }
        else if (value >= 0 && value <= 0xFFFF) { WriteByte(0xCD); WriteU16((uint)value); }
        else if (value >= 0) { WriteByte(0xCE); WriteU32((uint)value); }
        else if (value >= -0x80) { WriteByte(0xD0); WriteByte((byte)value); }
        else if (value >= -0x8000) { WriteByte(0xD1); WriteU16((uint)value); }
        else { WriteByte(0xD2); WriteU32((uint)value); }
    }

    public void WriteInt64(long value)
    {
        if (value >= 0 && value <= 0x7F) WriteByte((byte)value);
        else if (value >= -0x20 && value <= -1L) WriteByte((byte)value);
        else if (value >= 0 && value <= 0xFF) { WriteByte(0xCC); WriteByte((byte)value); }
        else if (value >= 0 && value <= 0xFFFF) { WriteByte(0xCD); WriteU16((uint)value); }
        else if (value >= 0 && value <= 0xFFFFFFFFL) { WriteByte(0xCE); WriteU32((uint)value); }
        else if (value >= 0) { WriteByte(0xCF); WriteU64((ulong)value); }
        else if (value >= -0x80L) { WriteByte(0xD0); WriteByte((byte)value); }
        else if (value >= -0x8000L) { WriteByte(0xD1); WriteU16((uint)value); }
        else if (value >= -0x80000000L) { WriteByte(0xD2); WriteU32((uint)value); }
        else { WriteByte(0xD3); WriteU64((ulong)value); }
    }

    public void WriteUint32(uint value)
    {
        if (value <= 0x7F) WriteByte((byte)value);
        else if (value <= 0xFF) { WriteByte(0xCC); WriteByte((byte)value); }
        else if (value <= 0xFFFF) { WriteByte(0xCD); WriteU16(value); }
        else { WriteByte(0xCE); WriteU32(value); }
    }

    public void WriteUint64(ulong value)
    {
        if (value <= 0x7FuL) WriteByte((byte)value);
        else if (value <= 0xFFuL) { WriteByte(0xCC); WriteByte((byte)value); }
        else if (value <= 0xFFFFuL) { WriteByte(0xCD); WriteU16((uint)value); }
        else if (value <= 0xFFFFFFFFuL) { WriteByte(0xCE); WriteU32((uint)value); }
        else { WriteByte(0xCF); WriteU64(value); }
    }

    public void WriteFloat32(float value)
    {
        WriteByte(0xCA);
        var bits = (uint)BitConverter.SingleToInt32Bits(value);
        WriteU32(bits);
    }

    public void WriteFloat64(double value)
    {
        WriteByte(0xCB);
        var bits = (ulong)BitConverter.DoubleToInt64Bits(value);
        WriteU32((uint)(bits >> 32));
        WriteU32((uint)bits);
    }

    public void WriteNull() => WriteByte(0xC0);

    public void WriteBytes(byte[] value)
    {
        var len = value.Length;
        if (len <= 0xFF) { WriteByte(0xC4); WriteByte((byte)len); }
        else if (len <= 0xFFFF) { WriteByte(0xC5); WriteU16((uint)len); }
        else { WriteByte(0xC6); WriteU32((uint)len); }
        _buf.AddRange(value);
    }

    public void BeginObject(int fieldCount)
    {
        if (fieldCount <= 0x0F) WriteByte((byte)(0x80 | fieldCount));
        else if (fieldCount <= 0xFFFF) { WriteByte(0xDE); WriteU16((uint)fieldCount); }
        else { WriteByte(0xDF); WriteU32((uint)fieldCount); }
    }

    public void WriteField(string name) => WriteString(name);
    public void EndObject() { }

    public void BeginArray(int elementCount)
    {
        if (elementCount <= 0x0F) WriteByte((byte)(0x90 | elementCount));
        else if (elementCount <= 0xFFFF) { WriteByte(0xDC); WriteU16((uint)elementCount); }
        else { WriteByte(0xDD); WriteU32((uint)elementCount); }
    }

    public void NextElement() { }
    public void EndArray() { }
    public void WriteEnum(string value) => WriteString(value);
    public byte[] ToBytes() => _buf.ToArray();
}
