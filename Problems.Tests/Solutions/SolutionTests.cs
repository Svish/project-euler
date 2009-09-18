using System;
using System.Linq;
using NUnit.Framework;
using Problems.Solutions;
using System.Reflection;


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
                .OrderBy(x => x.FullName);

            // Test them
            foreach(var i in implementors)
            {
                var solution = (ISolution) Activator.CreateInstance(i);
                var start = DateTime.Now;

                var expected = solution.ExpectedAnswer;
                var actual = solution.ActualAnswer;

                Assert.AreEqual(actual, expected,
                    string.Format("Solution of {0} is not correct", solution, Environment.NewLine));

                var time = DateTime.Now - start;
                Console.WriteLine("{0,-20}OK     {1,15:0.000}", 
                    solution, 
                    time.TotalMilliseconds);
            }
        }
    }
}