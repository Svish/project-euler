using System;
using System.Linq;
using NUnit.Framework;
using Problems.Solutions;
using System.Reflection;
using System.Diagnostics;


namespace Problems.Tests.Solutions
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void GetAnswer_AllImplementors_ReturnsExpectedAnswer()
        {
            // Find implementors
            var implementors = Assembly
                .GetAssembly(typeof (ISolution))
                .GetTypes()
                .Where(x 
                    => x.IsClass 
                    && !x.IsAbstract 
                    && typeof(ISolution).IsAssignableFrom(x))
                .OrderBy(x => x.Name, new NaturalStringComparer());


            // Test them
            foreach(var i in implementors)
            {
                var solution = (ISolution) Activator.CreateInstance(i);

                var watch = Stopwatch.StartNew();

                var expected = solution.ExpectedAnswer;
                var actual = solution.ActualAnswer;

                Assert.AreEqual(actual, expected,
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