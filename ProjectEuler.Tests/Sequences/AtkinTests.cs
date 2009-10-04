using System.Collections;
using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class AtkinTests
    {
        [Test]
        public void GetEnumerator_FirstFiveHundredNumbers_AreCorrect()
        {
            IEnumerable eratosthenes = new Atkin();

            var result = eratosthenes.Take(500);
            CollectionAssert.AreEqual(PrimeSequence.First500, result);
        }
    }
}