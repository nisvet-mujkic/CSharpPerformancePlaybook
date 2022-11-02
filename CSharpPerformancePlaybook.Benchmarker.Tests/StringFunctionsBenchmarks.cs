using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Xunit;

namespace CSharpPerformancePlaybook.Benchmarker.Tests
{
    public class StringFunctionsBenchmarks
    {
        private readonly Summary _summary;

        public StringFunctionsBenchmarks()
        {
#if DEBUG
            _summary = BenchmarkRunner.Run(typeof(StringFunctions), new DebugBuildConfig());
#else
            _summary = BenchmarkRunner.Run(typeof(StringFunctions));
#endif
        }

        [Fact]
        public void SpanSplitWithinSpec()
        {
            var mean = GetReport(_summary, "StringFunctions.SpanSplit").Mean; 

            Assert.True(mean > 0 && mean < 50, $"Mean was {mean}");
        }

        private static Statistics GetReport(Summary summary, string key)
        {
            return summary.Reports.FirstOrDefault(x =>
                string.Compare(x.BenchmarkCase.Descriptor.DisplayInfo, key, true) == 0)?.ResultStatistics;
        }
    }
}