namespace Specodec;

public record SpecCodec<T>(Action<SpecWriter, T> Encode, Func<SpecReader, T> Decode);

public record FormatEntry(
    string Name,
    Func<SpecWriter> NewWriter,
    Func<byte[], SpecReader> NewReader
);

public class FormatRegistry
{
    private readonly List<FormatEntry> _entries = new();

    public FormatRegistry Register(FormatEntry entry)
    {
        _entries.Add(entry);
        return this;
    }

    public FormatEntry Match(string format) =>
        _entries.FirstOrDefault(e => format == e.Name) ?? _entries[0];
}

public static class SpecCodecHelper
{
    public static readonly FormatRegistry DefaultRegistry = new FormatRegistry()
        .Register(new FormatEntry("json", () => new JsonWriter(), data => new JsonReader(data)))
        .Register(new FormatEntry("msgpack", () => new MsgPackWriter(), data => new MsgPackReader(data)))
        .Register(new FormatEntry("gron", () => new GronWriter(), data => new GronReader(data)));

    public static T Dispatch<T>(SpecCodec<T> codec, byte[] body, string format, FormatRegistry? registry = null)
    {
        var fmt = (registry ?? DefaultRegistry).Match(format);
        return codec.Decode(fmt.NewReader(body));
    }

    public static RespondResult Respond<T>(SpecCodec<T> codec, T obj, string format, FormatRegistry? registry = null)
    {
        var fmt = (registry ?? DefaultRegistry).Match(format);
        var w = fmt.NewWriter();
        codec.Encode(w, obj);
        return new RespondResult(w.ToBytes(), fmt.Name);
    }
}

public record RespondResult(byte[] Body, string Name);
