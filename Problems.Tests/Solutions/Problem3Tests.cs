using NUnit.Framework;
using Problems.Solutions;


namespace Problems.Tests.Solutions
{
    [TestFixture]
    public class Problem3Tests
    {
        [TestCase(13195, 29)] // The prime factors of 13195 are 5, 7, 13 and 29.
        public void VariousExamples(long value, long largestPrime)
        {
            Assert.AreEqual(largestPrime, Problem3.GetLargestPrimeFactorOf(value));
        }
    }
}