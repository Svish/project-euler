using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;
using System.Collections;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class ProbablePrimeSequenceTests
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            var realPrimes = KnownSequences.FirstPrimeNumbers;

            var actual = GetProbablePrimeSequence()
                .Take(realPrimes.Length * 3)    // Just need enough to cover the real primes
                .ToArray();
            
            Assert.That(realPrimes, Is.SubsetOf(actual));
        }


        private static IEnumerable GetProbablePrimeSequence()
        {
            return new ProbablePrimeSequence();
        }
    }
}