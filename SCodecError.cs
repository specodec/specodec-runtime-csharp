namespace Specodec;

public class SCodecError : Exception
{
    public string Code { get; }

    public SCodecError(string code, string message) : base(message)
    {
        Code = code;
    }
}
