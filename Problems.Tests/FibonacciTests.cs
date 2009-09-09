using System.Collections;
using System.Linq;
using NUnit.Framework;


namespace Problems.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void GetEnumerator_EulerExample_IsCorrectSequence()
        {
            IFibonacciSequence sequence = new Fibonacci();
            var result = sequence.Skip(1).Take(10).ToArray();
            CollectionAssert.AreEqual(result, new[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89});
        }


        [Test]
        public void GetEnumerator_FirstFifteenNumbers_AreCorrect()
        {
            IFibonacciSequence sequence = new Fibonacci();
            var result = sequence.Take(15).ToArray();
            CollectionAssert.AreEqual(result, new[] {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610});
        }


        [Test]
        public void GetEnumerator_GenericAndNonGeneric_FirstHundredAreTheSame()
        {
            var gen = new Fibonacci();

            using (var g = gen.GetEnumerator())
            {
                var e = (gen as IEnumerable).GetEnumerator();

                int i = 0;
                while (i++ < 100 && g.MoveNext() && e.MoveNext())
                    Assert.AreEqual(g.Current, e.Current);
            }
        }
    }
}