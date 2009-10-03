using System;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Problems;


namespace ProjectEuler.Performance
{
    [TestFixture]
    public class SolutionPerformance
    {
        [TestCase(50)]
        public void AllSolutions_Benchmark(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Benchmarking disabled (N = 0).");
                return;
            }

            var divider = new string('-', 90);
            const string format = "{0,-15} {5,13:F2} {1,13} {3,13} {2,13} {4,13:F2}    {6}";

            Console.WriteLine(format, "N = " + n, "Minimum", "Maximum", "Average", "StdDev", "Total", "Note");
            Console.WriteLine(divider);

            foreach (var problem in new ProblemIterator())
            {
                var first = true;
                foreach (var s in problem.GetSolutions())
                {
                    var solution = s;
                    var results = Benchmark.This(() => solution.GetAnswer(), TimeSpan.FromSeconds(2))
                        .Take(n)
                        .Select(x => x.TotalMilliseconds)
                        .OrderBy(x => x)
                        .ToArray();

                    var min = results.Min();
                    var max = results.Max();
                    var average = Math.Round(results.Average(), 2);
                    var stdDev = Math.Sqrt(results.Select(x => (x - average) * (x - average)).Sum() / (results.Count() - 1));
                    var sum = results.Sum();

                    Console.WriteLine(format,
                        first ? problem.ToString() : "",
                        min,
                        max,
                        average,
                        stdDev,
                        sum,
                        s.Note ?? "--");
                    first = false;
                }
            }
        }
    }
}