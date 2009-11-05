using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class TriangleSequenceTests
    {
        [Test]
        public void GetEnumerator_FirstTen_AreCorrect()
        {
            var expected = KnownSequences.FirstTriangleNumbers;
            var actual = new TriangleSequence()
                .Take(expected.Length);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}