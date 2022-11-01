using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using Bogus;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class ClassVsStruct
    {
        public List<string> Names
        {
            get => Enumerable.Repeat("Nisvet", 1000).ToList();
        }


        [Benchmark]
        public void ThousandClasses()
        {
            var classes = Names.Select(x => new PersonClass() { Name = x });
        }

        [Benchmark]
        public void ThousandStructs()
        {
            var structs = Names.Select(x => new PersonStruct() { Name = x });
        }
    }
}
