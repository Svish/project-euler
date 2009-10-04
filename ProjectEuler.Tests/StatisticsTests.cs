using NUnit.Framework;


namespace ProjectEuler.Tests
{
    [TestFixture]
    public class StatisticsTests
    {
        [Test]
        public void Variance_EmptyList_ReturnsZero()
        {
            var actual = new long[0]
                .Variance(true);
            Assert.AreEqual(0, actual);
        }


        [Test]
        public void Variance_Example1_IsCorrect()
        {
            var actual = new long[] { 1, 2, 3 }
                .Variance(true);
            Assert.AreEqual(2 / 3M, actual);
        }


        [Test]
        public void Variance_Example2_IsCorrect()
        {
            var actual = new long[] { 60, 56, 61, 68, 51, 53, 69, 54 }
                .Variance(true);
            Assert.AreEqual(40M, actual);
        }


        [Test]
        public void Variance_Example3_IsCorrect()
        {
            var actual = new long[] { 4, 5, 6, 5, 3, 2, 8, 0, 4, 6, 7, 8, 4, 5, 7, 9, 8, 6, 7, 5, 5, 4, 2, 1, 9, 3, 3, 4, 6, 4 }
                .Variance(true);
            Assert.AreEqual(152/30M, actual);
        }


        [Test]
        public void Variance_Example4_IsCorrect()
        {
            var actual = new long[] { 4, 5, 6, 5, 3, 2, 8, 0, 4, 6, 7, 8, 4, 5, 7, 9, 8, 6, 7, 5, 5, 4, 2, 1, 9, 3, 3, 4, 6, 4 }
                .Variance(false);
            Assert.AreEqual(152 / 29M, actual);
        }


        [Test]
        public void Median_EmptyList_ReturnsZero()
        {
            var actual = new long[0].Median();
            Assert.AreEqual(0, actual);
        }


        [Test]
        public void Median_SingleNumber_ReturnsNumber()
        {
            var actual = new long[] {7}.Median();
            Assert.AreEqual(7, actual);
        }


        [Test]
        public void Median_EvenNumber_ReturnsMiddle()
        {
            var actual = new long[] { 1, 5, 2, 10, 8, 7 }.Median();
            Assert.AreEqual(6, actual);
        }


        [Test]
        public void Median_OddNumber_ReturnsMiddle()
        {
            var actual = new long[] { 1, 5, 2, 8, 7 }.Median();
            Assert.AreEqual(5, actual);
        }
    }
}