using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Problems.Solutions;


namespace Problems.Tests.Solutions
{
    [TestFixture]
    public class SolutionTests
    {
        private static IEnumerable<ISolution> GetSolutions()
        {
            // Find implementors
            return Assembly
                .GetAssembly(typeof(ISolution))
                .GetTypes()
                .Where(x => x.IsClass
                         && !x.IsAbstract
                         && typeof(ISolution).IsAssignableFrom(x))
                .OrderBy(x => x.Name, new NaturalStringComparer())
                .Select(x => (ISolution)Activator.CreateInstance(x));
        }

        [Test]
        public void AllSolutions_ReturnExpectedAnswer()
        {
            foreach (var solution in GetSolutions())
            {
                var watch = Stopwatch.StartNew();

                var actual = solution.CalculatedAnswer;

                Assert.AreEqual(solution.Answer, actual,
                    string.Format("Solution of {0} is not correct", solution));

                watch.Stop();

                Console.WriteLine("{0,-20}OK     {1,10} ms {2,15} ticks {3,30}",
                    solution,
                    watch.ElapsedMilliseconds,
                    watch.ElapsedTicks,
                    actual);
            }
        }
    }
}