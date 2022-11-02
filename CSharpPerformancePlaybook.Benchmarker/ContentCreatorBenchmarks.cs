using BenchmarkDotNet.Attributes;
using CSharpPerformancePlaybook.Code;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    [MemoryDiagnoser]
    public class ContentCreatorBenchmarks
    {
        [Benchmark]
        public void CreateUsingIfs()
        {
            var content = new ContentCreator().CreateUsingIfs();
        }

        [Benchmark]
        public void CreateUsingReflection()
        {
            var content = new ContentCreator().CreateUsingReflection();
        }
    }
}
