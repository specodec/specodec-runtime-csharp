namespace Specodec.Ryu;

public static class RyuMath
{
    public static int Pow5Bits(int e) => e * 1217359 / 524288 + 1;
    public static int Log10Pow2(int e) => e * 78913 / 262144;
    public static int Log10Pow5(int e) => e * 732923 / 1048576;

    public static int DecimalLength17(ulong v)
    {
        if (v >= 10000000000000000UL) return 17;
        if (v >= 1000000000000000UL) return 16;
        if (v >= 100000000000000UL) return 15;
        if (v >= 10000000000000UL) return 14;
        if (v >= 1000000000000UL) return 13;
        if (v >= 100000000000UL) return 12;
        if (v >= 10000000000UL) return 11;
        if (v >= 1000000000UL) return 10;
        if (v >= 100000000UL) return 9;
        if (v >= 10000000UL) return 8;
        if (v >= 1000000UL) return 7;
        if (v >= 100000UL) return 6;
        if (v >= 10000UL) return 5;
        if (v >= 1000UL) return 4;
        if (v >= 100UL) return 3;
        if (v >= 10UL) return 2;
        return 1;
    }

    public static int DecimalLength9(uint v)
    {
        if (v >= 100000000U) return 9;
        if (v >= 10000000U) return 8;
        if (v >= 1000000U) return 7;
        if (v >= 100000U) return 6;
        if (v >= 10000U) return 5;
        if (v >= 1000U) return 4;
        if (v >= 100U) return 3;
        if (v >= 10U) return 2;
        return 1;
    }

    public static ulong MulShift32(ulong m, ulong factor, int shift)
    {
        var factorLo = factor & 0xFFFFFFFFUL;
        var factorHi = factor >> 32;
        var bits0 = m * factorLo;
        var bits1 = m * factorHi;
        var sumVal = (bits0 >> 32) + bits1;
        return (sumVal >> (shift - 32)) & 0xFFFFFFFFUL;
    }

    public static ulong MulShift64(ulong m, ulong[] mul, int shift)
    {
        var (hi0, _) = Umul128(m, mul[0]);
        var (hi2, lo2) = Umul128(m, mul[1]);

        var sumLo = lo2 + hi0;
        var carry = sumLo < lo2 ? 1UL : 0UL;
        var sumHi = hi2 + carry;

        var shiftAmount = shift - 64;
        if (shiftAmount >= 128) return 0UL;
        if (shiftAmount >= 64) return sumHi >> (shiftAmount - 64);
        if (shiftAmount == 0) return sumLo;
        return (sumHi << (64 - shiftAmount)) | (sumLo >> shiftAmount);
    }

    public static (ulong hi, ulong lo) Umul128(ulong a, ulong b)
    {
        var aLo = a & 0xFFFFFFFFUL;
        var aHi = a >> 32;
        var bLo = b & 0xFFFFFFFFUL;
        var bHi = b >> 32;

        var ll = aLo * bLo;
        var lh = aLo * bHi;
        var hl = aHi * bLo;
        var hh = aHi * bHi;

        var mid = lh + hl;
        var overflow = mid < lh ? 1UL : 0UL;

        var hi = hh + (mid >> 32) + overflow;
        var lo = ll + ((mid & 0xFFFFFFFFUL) << 32);
        if (lo < ll) hi++;

        return (hi, lo);
    }

    public static bool MultipleOfPowerOf5_64(ulong value, int q)
    {
        if (q == 0) return true;
        if (q >= 64) return value == 0UL;
        var pow5 = 5UL;
        for (var i = 1; i < q; i++) pow5 *= 5UL;
        return (value % pow5) == 0UL;
    }

    public static bool MultipleOfPowerOf2_64(ulong value, int q)
    {
        if (q == 0) return true;
        if (q >= 64) return value == 0UL;
        return (value & ((1UL << q) - 1UL)) == 0UL;
    }

    public static bool MultipleOfPowerOf5_32(uint value, int q)
    {
        if (q == 0) return true;
        if (q >= 32) return value == 0U;
        var pow5 = 5U;
        for (var i = 1; i < q; i++) pow5 *= 5U;
        return (value % pow5) == 0U;
    }

    public static bool MultipleOfPowerOf2_32(uint value, int q)
    {
        if (q == 0) return true;
        if (q >= 32) return value == 0U;
        return (value & ((1U << q) - 1U)) == 0U;
    }
}
