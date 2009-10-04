using System.Linq;
using NUnit.Framework;
using System.Collections;
using ProjectEuler.Sequences;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class EratosthenesTests
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            IEnumerable eratosthenes = new Eratosthenes();

            var result = TestExtensions.EnumerableExtensions.Take(eratosthenes, 500);
            CollectionAssert.AreEqual(PrimeSequence.First500, result);
        }

        [Test]
        public void GetEnumerator_WhenRanTwice_GetSameNumbers()
        {
            IPrimeSequence gen = new Eratosthenes();

            var a = gen.Take(100).ToArray();
            var b = gen.Take(100).ToArray();

            CollectionAssert.AreEqual(a, b);
        }
    }
}