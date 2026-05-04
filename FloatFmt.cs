namespace Specodec;

using Specodec.Ryu;

public static class FloatFmt
{
    public static string FormatFloat32(float value) => RyuF32.Float32ToString(value);
    public static string FormatFloat64(double value) => RyuF64.Float64ToString(value);
}
