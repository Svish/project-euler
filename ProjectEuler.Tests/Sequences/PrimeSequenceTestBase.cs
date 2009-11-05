using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    /// <summary>
    /// Just contains an array with the first five hundred primes for testing.
    /// </summary>
    public abstract class PrimeSequenceTestBase<TPrimeSequence> 
        where TPrimeSequence : IPrimeSequence
    {
        protected abstract TPrimeSequence GetPrimeSequence();


        [Test]
        public void GetEnumerator_FirstKnownPrimes_AreCorrect()
        {
            var expected = KnownSequences.FirstPrimeNumbers;
            var actual = GetPrimeSequence()
                .Take(expected.Length)
                .ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }



        [Test]
        public void GetEnumerator_WhenRanTwice_GetSameNumbers()
        {
            var primeSequence = GetPrimeSequence();

            var a = primeSequence.Take(100).ToArray();
            var b = primeSequence.Take(100).ToArray();

            CollectionAssert.AreEqual(a, b);
        }
    }
}