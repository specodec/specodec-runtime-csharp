namespace Specodec;

public interface SpecReader
{
    void BeginObject();
    bool HasNextField();
    string ReadFieldName();
    void EndObject();
    void BeginArray();
    bool HasNextElement();
    void EndArray();
    string ReadString();
    bool ReadBool();
    int ReadInt32();
    long ReadInt64();
    uint ReadUint32();
    ulong ReadUint64();
    float ReadFloat32();
    double ReadFloat64();
    void ReadNull();
    byte[] ReadBytes();
    string ReadEnum();
    bool IsNull();
    void Skip();
}
