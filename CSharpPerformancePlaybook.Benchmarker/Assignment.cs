using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Assignment
    {
        [Benchmark]
        public void PropertyAssignment()
        {
            foreach (var name in new ClassVsStruct().Names)
            {
                var person = new PersonClass();
                person.Name = name;
            }
        }

        [Benchmark]
        public void DirectAssignment()
        {
            foreach (var name in new ClassVsStruct().Names)
            {
                var person = new PersonClass();

                person.name = name;
            }
        }
    }
}