using System;
using System.IO;
using System.Linq;
using System.Globalization;
using Specodec;
using Specodec.Ryu;

class TestRyu
{
    static void Main()
    {
        string dir = Environment.GetEnvironmentVariable("TEST_DIR") ?? "./";

        int passed = 0, failed = 0;

        Console.WriteLine("=== Float32 Original (125 tests) ===");
        var f32Input = LoadTests(dir + "test_cases_f32.txt");
        var f32Expected = LoadExpected(dir + "expected_f32.txt");
        RunGroup(f32Input, f32Expected, ref passed, ref failed,
            s => RyuF32.Float32ToString(ParseFloat32(s)));

        Console.WriteLine("=== Float64 Original (102 tests) ===");
        var f64Input = LoadTests(dir + "test_cases_f64.txt");
        var f64Expected = LoadExpected(dir + "expected_f64.txt");
        RunGroup(f64Input, f64Expected, ref passed, ref failed,
            s => RyuF64.Float64ToString(ParseFloat64(s)));

        Console.WriteLine("=== Float32 Coverage (78 tests) ===");
        var covInput = LoadCoverageTests(dir + "test_cases_table_coverage.txt");
        var covExpected = LoadExpected(dir + "expected_table_coverage.txt");
        RunGroup(covInput, covExpected, ref passed, ref failed,
            s => RyuF32.Float32ToString(ParseFloat32(s)));

        Console.WriteLine("=== Float64 Coverage (616 tests) ===");
        var f64CovInput = LoadCoverageTests(dir + "test_cases_f64_table_coverage.txt");
        var f64CovExpected = LoadExpected(dir + "expected_f64_table_coverage.txt");
        RunGroup(f64CovInput, f64CovExpected, ref passed, ref failed,
            s => RyuF64.Float64ToString(ParseFloat64(s)));

        int total = passed + failed;
        Console.WriteLine($"=== TOTAL: {passed}/{total} ===");
        if (failed > 0) Environment.Exit(1);
    }

    static float ParseFloat32(string s)
    {
        s = s.Trim();
        if (s == "NaN") return float.NaN;
        if (s == "Infinity") return float.PositiveInfinity;
        if (s == "-Infinity") return float.NegativeInfinity;
        return float.Parse(s, CultureInfo.InvariantCulture);
    }

    static double ParseFloat64(string s)
    {
        s = s.Trim();
        if (s == "NaN") return double.NaN;
        if (s == "Infinity") return double.PositiveInfinity;
        if (s == "-Infinity") return double.NegativeInfinity;
        return double.Parse(s, CultureInfo.InvariantCulture);
    }

    static void RunGroup(string[] inputs, string[] expected,
        ref int passed, ref int failed, Func<string, string> convert)
    {
        int pass = 0, fail = 0;
        int count = Math.Min(inputs.Length, expected.Length);
        for (int i = 0; i < count; i++)
        {
            var result = convert(inputs[i]);
            if (result == expected[i])
            {
                pass++; passed++;
            }
            else
            {
                fail++; failed++;
                if (fail <= 5)
                    Console.WriteLine($"FAIL: {inputs[i]} => {result} (expected {expected[i]})");
            }
        }
        Console.WriteLine($"{pass}/{count}\n");
    }

    static string[] LoadExpected(string path)
    {
        return File.ReadAllLines(path)
            .Select(l => l.Trim())
            .Where(l => l.Length > 0)
            .ToArray();
    }

    static string[] LoadTests(string path)
    {
        return File.ReadAllLines(path)
            .Select(l => l.Trim())
            .Where(l => l.Length > 0 && !l.StartsWith("#"))
            .ToArray();
    }

    static string[] LoadCoverageTests(string path)
    {
        return File.ReadAllLines(path)
            .Select(l => l.Trim())
            .Where(l => l.Length > 0 && char.IsDigit(l[0]))
            .Select(l => l.Split('#')[0].Trim())
            .ToArray();
    }
}
