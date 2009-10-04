using System.Collections;
using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class EratosthenesTests
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            IEnumerable eratosthenes = new Eratosthenes();

            var result = eratosthenes.Take(500);
            CollectionAssert.AreEqual(PrimeSequence.First500, result);
        }


        [Test]
        public void GetEnumerator_WhenRanTwice_GetSameNumbers()
        {
            IPrimeSequence gen = new Eratosthenes();

            var a = gen.Take(100);
            var b = gen.Take(100);

            CollectionAssert.AreEqual(a, b);
        }
    }
}