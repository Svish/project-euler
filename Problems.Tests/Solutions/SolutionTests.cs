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
                
                Assert.AreEqual(solution.ExpectedAnswer, solution.GetAnswer(),
                    string.Format("Solution to problem #{0} is not correct.", solution.ProblemId));
                
                Console.WriteLine("Solution to problem #{0} took {1} seconds to find", 
                    solution.ProblemId, 
                    (DateTime.Now - start).TotalSeconds);
            }
        }
    }
}