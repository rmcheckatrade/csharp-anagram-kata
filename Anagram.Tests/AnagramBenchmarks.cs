using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace Anagram.Tests;

using Xunit.Abstractions;

[MemoryDiagnoser]
public class AnagramBenchmarks
{
    private const int Reps = 500;
    private readonly AnagramFinder _finder = new();

    [Benchmark]
    public void ShortAnagram()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "a",
                "a"
            );
        }
    }

    [Benchmark]
    public void ShortNonAnagram()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "a",
                "b"
            );
        }
    }

    [Benchmark]
    public void ShortSame()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp",
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp"
            );
        }
    }

    [Benchmark]
    public void LongAnagram()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "pazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp",
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolq"
            );
        }
    }

    [Benchmark]
    public void LongNonAnagram()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp",
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolq"
            );
        }
    }

    [Benchmark]
    public void LongNonAnagramOfDifferingLengths()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp",
                "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp"
            );
        }
    }

    [Benchmark]
    public void LongNonAnagramWhereFirsLetterDoesntExist()
    {
        for (var i = 0; i < Reps; i++)
        {
            _finder.IsAnagram(
                "qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop",
                "zwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop"
            );
        }
    }
}
