namespace Specodec.Ryu;

public static class RyuF32
{
    private const int FloatMantissaBits = 23;
    private const int FloatBias = 127;
    private const int FloatPow5InvBitcount = 59;
    private const int FloatPow5Bitcount = 61;

    public static string Float32ToString(float f)
    {
        var bits = BitConverter.SingleToInt32Bits(f);

        var sign = (bits >>> 31) != 0;
        var ieeeMantissa = bits & 0x7FFFFF;
        var ieeeExponent = (bits >>> 23) & 0xFF;

        if (ieeeExponent == 255)
        {
            if (ieeeMantissa == 0)
                return sign ? "-Infinity" : "Infinity";
            return "NaN";
        }
        if (ieeeExponent == 0 && ieeeMantissa == 0)
            return sign ? "-0E0" : "0E0";

        int e2;
        ulong m2;
        if (ieeeExponent == 0)
        {
            e2 = 1 - FloatBias - FloatMantissaBits - 2;
            m2 = (uint)ieeeMantissa;
        }
        else
        {
            e2 = ieeeExponent - FloatBias - FloatMantissaBits - 2;
            m2 = (uint)((1 << FloatMantissaBits) | ieeeMantissa);
        }

        var even = (m2 & 1UL) == 0UL;
        var acceptBounds = even;

        var mv = m2 * 4UL;
        var mp = mv + 2UL;
        var mmShift = 0;
        if (ieeeMantissa != 0 || ieeeExponent <= 1)
            mmShift = 1;
        var mm = mv - 1UL - (uint)mmShift;

        var vrIsTrailingZeros = false;
        var vmIsTrailingZeros = false;
        var lastDigit = 0UL;
        int e10;
        ulong vr, vp, vm;

        if (e2 >= 0)
        {
            var q = RyuMath.Log10Pow2(e2);
            e10 = q;
            var k = FloatPow5InvBitcount + RyuMath.Pow5Bits(q) - 1;
            var i = -e2 + q + k;

            vr = RyuMath.MulShift32(mv, TablesF32.FloatPow5InvSplit[q] + 1UL, i);
            vp = RyuMath.MulShift32(mp, TablesF32.FloatPow5InvSplit[q] + 1UL, i);
            vm = RyuMath.MulShift32(mm, TablesF32.FloatPow5InvSplit[q] + 1UL, i);

            if (q != 0 && (vp - 1UL) / 10UL <= vm / 10UL)
            {
                var l = FloatPow5InvBitcount + RyuMath.Pow5Bits(q - 1) - 1;
                lastDigit = RyuMath.MulShift32(mv, TablesF32.FloatPow5InvSplit[q - 1] + 1UL, -e2 + q - 1 + l) % 10UL;
            }

            if (q <= 9)
            {
                if (mv % 5UL == 0UL)
                {
                    vrIsTrailingZeros = RyuMath.MultipleOfPowerOf5_32((uint)mv, q);
                    vmIsTrailingZeros = RyuMath.MultipleOfPowerOf5_32((uint)mm, q);
                    if (RyuMath.MultipleOfPowerOf5_32((uint)mp, q))
                        vp--;
                }
            }
        }
        else
        {
            var q = RyuMath.Log10Pow5(-e2);
            e10 = q + e2;
            var i = -e2 - q;
            var k = RyuMath.Pow5Bits(i) - FloatPow5Bitcount;
            var j = q - k;

            vr = RyuMath.MulShift32(mv, TablesF32.FloatPow5Split[i], j);
            vp = RyuMath.MulShift32(mp, TablesF32.FloatPow5Split[i], j);
            vm = RyuMath.MulShift32(mm, TablesF32.FloatPow5Split[i], j);

            if (q != 0 && (vp - 1UL) / 10UL <= vm / 10UL)
            {
                var j2 = q - 1 - (RyuMath.Pow5Bits(i + 1) - FloatPow5Bitcount);
                lastDigit = RyuMath.MulShift32(mv, TablesF32.FloatPow5Split[i + 1], j2) % 10UL;
            }

            if (q <= 1)
            {
                vrIsTrailingZeros = true;
                if (acceptBounds)
                    vmIsTrailingZeros = mmShift == 1;
                else
                    vp--;
            }
            else if (q < 31)
            {
                vrIsTrailingZeros = RyuMath.MultipleOfPowerOf2_32((uint)mv, q - 1);
                if (acceptBounds)
                    vmIsTrailingZeros = RyuMath.MultipleOfPowerOf5_32((uint)mm, q);
                else if (RyuMath.MultipleOfPowerOf5_32((uint)mp, q))
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
            var olength = RyuMath.DecimalLength9((uint)output);

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
            var olength = RyuMath.DecimalLength9((uint)output);

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
