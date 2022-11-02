using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using CSharpPerformancePlaybook.Code;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    [MemoryDiagnoser]
    public class StringFunctions
    {
        [Benchmark]
        public void BuildStringBadly()
        {
            var x = new StringWorker().BuildStringBadly("test");
        }

        [Benchmark]
        public void BuildStringBetter()
        {
            var x = new StringWorker().BuildStringBetter("test");
        }

        [Benchmark]
        public void NaiveSplit()
        {
            var x = new StringWorker().NaiveSplitName("Mujkic, Nisvet");
        }

        [Benchmark]
        public void SplitSplit()
        {
            var x = new StringWorker().SplitSplitName("Mujkic, Nisvet");
        }

        [Benchmark]
        public void SpanSplit()
        {
            var x = new StringWorker().SpanSplitName("Mujkic, Nisvet");
        }
    }
}