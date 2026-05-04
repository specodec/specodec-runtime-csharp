namespace Specodec.Ryu;

public static class RyuF64
{
    private const int DoubleMantissaBits = 52;
    private const int DoubleBias = 1023;
    private const int DoublePow5InvBitcount = 125;
    private const int DoublePow5Bitcount = 125;

    public static string Float64ToString(double d)
    {
        var bits = BitConverter.DoubleToInt64Bits(d);

        var sign = (bits >>> 63) != 0L;
        var ieeeMantissa = bits & 0xFFFFFFFFFFFFFL;
        var ieeeExponent = (int)((bits >>> 52) & 0x7FFL);

        if (ieeeExponent == 2047)
        {
            if (ieeeMantissa == 0L)
                return sign ? "-Infinity" : "Infinity";
            return "NaN";
        }
        if (ieeeExponent == 0 && ieeeMantissa == 0L)
            return sign ? "-0E0" : "0E0";

        int e2;
        ulong m2;
        if (ieeeExponent == 0)
        {
            e2 = 1 - DoubleBias - DoubleMantissaBits - 2;
            m2 = (ulong)ieeeMantissa;
        }
        else
        {
            e2 = ieeeExponent - DoubleBias - DoubleMantissaBits - 2;
            m2 = (ulong)((1L << DoubleMantissaBits) | ieeeMantissa);
        }

        var even = (m2 & 1UL) == 0UL;
        var acceptBounds = even;

        var mv = m2 * 4UL;
        var mp = mv + 2UL;
        var mmShift = 0UL;
        if (ieeeMantissa != 0L || ieeeExponent <= 1)
            mmShift = 1UL;
        var mm = mv - 1UL - mmShift;

        var vrIsTrailingZeros = false;
        var vmIsTrailingZeros = false;
        var lastDigit = 0UL;
        int e10;
        ulong vr, vp, vm;

        if (e2 >= 0)
        {
            var q = RyuMath.Log10Pow2(e2);
            e10 = q;
            var k = DoublePow5InvBitcount + RyuMath.Pow5Bits(q) - 1;
            var i = -e2 + q + k;

            vr = RyuMath.MulShift64(mv, TablesF64.DoublePow5InvSplit[q], i);
            vp = RyuMath.MulShift64(mp, TablesF64.DoublePow5InvSplit[q], i);
            vm = RyuMath.MulShift64(mm, TablesF64.DoublePow5InvSplit[q], i);

            if (q != 0 && (vp - 1UL) / 10UL <= vm / 10UL)
            {
                var l = DoublePow5InvBitcount + RyuMath.Pow5Bits(q - 1) - 1;
                lastDigit = RyuMath.MulShift64(mv, TablesF64.DoublePow5InvSplit[q - 1], -e2 + q - 1 + l) % 10UL;
            }

            if (q <= 21)
            {
                if (mv % 5UL == 0UL)
                {
                    vrIsTrailingZeros = RyuMath.MultipleOfPowerOf5_64(mv, q);
                }
                else if (acceptBounds)
                {
                    vmIsTrailingZeros = RyuMath.MultipleOfPowerOf5_64(mm, q);
                }
                else
                {
                    if (RyuMath.MultipleOfPowerOf5_64(mp, q))
                        vp--;
                }
            }
        }
        else
        {
            var q = RyuMath.Log10Pow5(-e2);
            e10 = q + e2;
            var i = -e2 - q;
            var k = RyuMath.Pow5Bits(i) - DoublePow5Bitcount;
            var j = q - k;

            vr = RyuMath.MulShift64(mv, TablesF64.DoublePow5Split[i], j);
            vp = RyuMath.MulShift64(mp, TablesF64.DoublePow5Split[i], j);
            vm = RyuMath.MulShift64(mm, TablesF64.DoublePow5Split[i], j);

            if (q != 0 && (vp - 1UL) / 10UL <= vm / 10UL)
            {
                var j2 = q - 1 - (RyuMath.Pow5Bits(i + 1) - DoublePow5Bitcount);
                lastDigit = RyuMath.MulShift64(mv, TablesF64.DoublePow5Split[i + 1], j2) % 10UL;
            }

            if (q <= 1)
            {
                vrIsTrailingZeros = true;
                if (acceptBounds)
                    vmIsTrailingZeros = mmShift == 1UL;
                else
                    vp--;
            }
            else if (q < 63)
            {
                vrIsTrailingZeros = RyuMath.MultipleOfPowerOf2_64(mv, q - 1);
                if (acceptBounds)
                    vmIsTrailingZeros = RyuMath.MultipleOfPowerOf5_64(mm, q);
                else if (RyuMath.MultipleOfPowerOf5_64(mp, q))
                    vp--;
            }
        }

        var removed = 0;
        var vr2 = vr;
        var vp2 = vp;
        var vm2 = vm;

        if (vmIsTrailingZeros || vrIsTrailingZeros)
        {
            while (vp2 / 10UL > vm2 / 10UL)
            {
                vmIsTrailingZeros = vmIsTrailingZeros && (vm2 % 10UL == 0UL);
                vrIsTrailingZeros = vrIsTrailingZeros && (lastDigit == 0UL);
                lastDigit = vr2 % 10UL;
                vr2 /= 10UL;
                vp2 /= 10UL;
                vm2 /= 10UL;
                removed++;
            }

            if (vmIsTrailingZeros)
            {
                while (vm2 % 10UL == 0UL)
                {
                    vrIsTrailingZeros = vrIsTrailingZeros && (lastDigit == 0UL);
                    lastDigit = vr2 % 10UL;
                    vr2 /= 10UL;
                    vp2 /= 10UL;
                    vm2 /= 10UL;
                    removed++;
                }
            }

            if (vrIsTrailingZeros && lastDigit == 5UL && (vr2 & 1UL) == 0UL)
                lastDigit = 4UL;

            var roundUp = (vr2 == vm2 && (!acceptBounds || !vmIsTrailingZeros)) || lastDigit >= 5UL;
            var output = vr2;
            if (roundUp) output++;
            var exp = e10 + removed;
            var olength = RyuMath.DecimalLength17(output);

            var result = sign ? "-" : "";
            var digits = output.ToString();
            if (olength == 1)
                result += digits;
            else
                result += digits.Substring(0, 1) + "." + digits.Substring(1);
            result += "E" + (exp + olength - 1).ToString();
            return result;
        }
        else
        {
            while (vp2 / 10UL > vm2 / 10UL)
            {
                lastDigit = vr2 % 10UL;
                vr2 /= 10UL;
                vp2 /= 10UL;
                vm2 /= 10UL;
                removed++;
            }

            var output = vr2;
            if (vr2 == vm2 || lastDigit >= 5UL)
                output++;
            var exp = e10 + removed;
            var olength = RyuMath.DecimalLength17(output);

            var result = sign ? "-" : "";
            var digits = output.ToString();
            if (olength == 1)
                result += digits;
            else
                result += digits.Substring(0, 1) + "." + digits.Substring(1);
            result += "E" + (exp + olength - 1).ToString();
            return result;
        }
    }
}
