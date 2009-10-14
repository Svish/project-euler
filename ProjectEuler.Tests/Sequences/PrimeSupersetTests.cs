using System.Collections;
using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class ProbablePrimeSequenceTests
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            IEnumerable eratosthenes = new ProbablePrimeSequence();

            var result = eratosthenes.Take(1200).ToArray();
            Assert.That(PrimeSequenceTests.First500, Is.SubsetOf(result));
        }
    }
}