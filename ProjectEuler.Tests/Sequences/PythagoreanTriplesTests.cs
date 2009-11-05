using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class PythagoreanTriplesTests
    {
        [Test]
        public void GetEnumerator_FirstKnownTriplets_AreCorrect()
        {
            var expected = KnownSequences.FirstPythagoreanTriplets;
            var actual = new PythagoreanTriples()
                .Take(expected.Length)
                .ToArray();

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}