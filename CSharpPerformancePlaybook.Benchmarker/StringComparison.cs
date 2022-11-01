using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class StringComparison
    {
        string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ";

        [Benchmark]
        public void EqualityComparison()
        {
            var compare = testString.ToUpper() == "TEST".ToUpper();
        }

        [Benchmark]
        public void EqualsComparison()
        {
            var compare = testString.ToUpper().Equals("TEST".ToUpper());
        }

        [Benchmark]
        public void StringCompareComparison()
        {
            var compare = string.Compare(testString, "TEST", true);
        }

        [Benchmark]
        public void StringLengthComparison()
        {
            var compare = testString.Length == "TEST".Length;
        }
    }
}