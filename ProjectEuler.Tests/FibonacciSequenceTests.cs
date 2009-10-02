using System.Collections;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Tests.TestExtensions;


namespace ProjectEuler.Tests
{
    [TestFixture]
    public class FibonacciSequenceTests
    {
        [Test]
        public void GetEnumerator_EulerExample_IsCorrectSequence()
        {
            var actual = new FibonacciSequence().Skip(1).Take(10).ToArray();
            var expected = new[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89};
            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void GetEnumerator_FirstFifteenNumbers_AreCorrect()
        {
            var actual = (new FibonacciSequence() as IEnumerable).Take(15);
            var expected = new[] {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}