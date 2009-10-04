using System;
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
            var actual = new TriangleSequence().Take(10);
            CollectionAssert.AreEqual(FirstTen, actual);
        }

        private static readonly int[] FirstTen = new[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };

    }
}