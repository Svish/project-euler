using NUnit.Framework;
using ProjectEuler.Sequences;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        private static FibonacciSequence GetFibonacciSequence()
        {
            return new FibonacciSequence();
        }


        [Test]
        public void GetEnumerator_FirstNumbers_AreCorrect()
        {
            var expected = KnownSequences.FirstFibonacciNumbers;
            var actual = GetFibonacciSequence()
                .Take(expected.Length)
                .ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void GetEnumerator_FirstTwo_AreZeroAndOne()
        {
            var expected = new[] {0ul, 1ul};
            var actual = GetFibonacciSequence()
                .Take(expected.Length)
                .ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}