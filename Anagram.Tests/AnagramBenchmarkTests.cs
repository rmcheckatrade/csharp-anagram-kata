using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

namespace Anagram.Tests;

using Xunit.Abstractions;

[Collection("Sequential")]
public class AnagramBenchmarkTests
{
    private readonly ITestOutputHelper _output;

    public AnagramBenchmarkTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void TestPerformance()
    {
        var logger = new AccumulationLogger();

        var config = ManualConfig.Create(DefaultConfig.Instance)
            .AddLogger(logger)
            .WithOptions(ConfigOptions.DisableOptimizationsValidator);

        BenchmarkRunner.Run<AnagramBenchmarks>(config);

        // write benchmark summary
        _output.WriteLine(logger.GetLog());
    }
}
