namespace Specodec;

public interface SpecWriter
{
    void WriteString(string value);
    void WriteBool(bool value);
    void WriteInt32(int value);
    void WriteInt64(long value);
    void WriteUint32(uint value);
    void WriteUint64(ulong value);
    void WriteFloat32(float value);
    void WriteFloat64(double value);
    void WriteNull();
    void WriteBytes(byte[] value);
    void WriteEnum(string value);
    void BeginObject(int fieldCount);
    void WriteField(string name);
    void EndObject();
    void BeginArray(int elementCount);
    void NextElement();
    void EndArray();
    byte[] ToBytes();
}
