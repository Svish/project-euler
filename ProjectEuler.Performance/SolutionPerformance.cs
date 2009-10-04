using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Problems;
using System.Collections.Generic;


namespace ProjectEuler.Performance
{
    [TestFixture]
    public class SolutionPerformance
    {
        [Test]
        public void AllSolutions_Benchmark()
        {
            var maxPerSolution = TimeSpan.FromSeconds(10);
            const int n = 500;

            const string format = "{0,-15} {6,8} {3,13} {4,13}  {1,13} {2,13}   {5}";

            Console.WriteLine(format,
                "N = " + n,
                "Minimum",
                "Maximum",
                "Mean",
                "StdDev",
                "Note",
                "n");
            Console.WriteLine(new string('-', 90));

            foreach (var problem in new ProblemIterator())
            {
                var first = true;
                foreach (var s in problem.GetSolutions())
                {
                    var solution = s;
                    var results = Benchmark
                        .This(() => solution.GetAnswer(), maxPerSolution)
                        .Take(n)
                        .Select(x => (long) x.TotalMilliseconds)
                        .ToList();

                    Console.WriteLine(format,
                        first ? problem.ToString() : "",
                        results.Min(),
                        results.Max(),
                        Math.Round(results.Median(), 0),
                        Math.Round(Math.Sqrt(Convert.ToDouble(results.Variance(true))), 0),
                        s.Note ?? "--",
                        results.Count);
                    first = false;
                }
            }
        }
    }
}