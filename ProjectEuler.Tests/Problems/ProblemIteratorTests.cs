using NUnit.Framework;
using ProjectEuler.Problems;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Problems
{
    [TestFixture]
    public class ProblemIteratorTests
    {
        [Test]
        public void GetEnumerator_ReturnsSomeOfTheExpectedProblems()
        {
            var someExpected = new[] {"Problem001", "Problem005", "Problem010"};
            var allActual = new ProblemIterator().Select<IProblem, string>(x => x.ToString());

            CollectionAssert.IsSubsetOf(someExpected, allActual);
        }
    }
}