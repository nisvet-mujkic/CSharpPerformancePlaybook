using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class Loops
    {
        string[] _names = { "Nisvet", "John", "Lewis", "Ana", "Christian" };

        [Benchmark]
        public void ForLoop()
        {
            for (int i = 0; i < _names.Length; i++)
            {
                var x = _names[i];
            }
        }

        [Benchmark]
        public void ForEachLoop()
        {
            foreach (string name in _names)
            {
                var x = name;
            }
        }
    }
}