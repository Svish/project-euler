using System;
using System.Linq;
using NUnit.Framework;


namespace ProjectEuler.Tests
{
    public class FactorizationTests
    {
        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void IsEvenlyDivisibleBy_Zero_ThrowsException()
        {
            Factorization.IsEvenlyDivisibleBy(5, 0);
        }


        [TestCase(true, 5UL, new ulong[] { 5 })]
        [TestCase(true, 6UL, new ulong[] { 2, 3 })]
        [TestCase(false, 8UL, new ulong[] { 2, 3 })]
        [TestCase(true, 10UL, new ulong[] { 10, 5, 2 })]
        [TestCase(false, 10UL, new ulong[] { 10, 5, 3 })]
        public void IsEvenlyDivisibleBy_Examples_AreCorrect(bool expected, ulong value, ulong[] divisors)
        {
            var actual = value.IsEvenlyDivisibleBy(divisors);
            Assert.AreEqual(expected, actual,
                string.Format("{0} % {1}", value, string.Join(", ", divisors.Select(x => x.ToString()).ToArray())));
        }


        [TestCase(13195UL, 29UL)] // The prime factors of 13195 are 5, 7, 13 and 29.
        public void GetPrimeFactors_LargestPrimeFactorOfExample_IsCorrect(ulong value, ulong expected)
        {
            var actual = Factorization.GetPrimeFactors(value, new Eratosthenes()).Max();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(12UL, new ulong[] { 2, 2, 3 })]
        [TestCase(15UL, new ulong[] { 3, 5 })]
        [TestCase(120UL, new ulong[] { 2, 2, 2, 3, 5 })]
        public void GetPrimeFactors_Examples_AreCorrect(ulong value, ulong[] expectedPrimeFactors)
        {
            var actual = Factorization.GetPrimeFactors(value, new Eratosthenes()).ToArray();
            CollectionAssert.AreEquivalent(expectedPrimeFactors, actual);
        }


        [TestCase(0UL, new ulong[] { 0 })]
        [TestCase(1UL, new ulong[] { 1 })]
        [TestCase(3UL, new ulong[] { 1, 3 })]
        [TestCase(6UL, new ulong[] { 1, 2, 3, 6 })]
        [TestCase(10UL, new ulong[] { 1, 2, 5, 10 })]
        [TestCase(15UL, new ulong[] { 1, 3, 5, 15 })]
        [TestCase(21UL, new ulong[] { 1, 3, 7, 21 })]
        [TestCase(28UL, new ulong[] { 1, 2, 4, 7, 14, 28 })]
        public void GetDivisors_Examples_AreCorrect(ulong number, ulong[] expectedDivisors)
        {
            var actual = Factorization.GetDivisors(number).ToArray();
            CollectionAssert.AreEquivalent(expectedDivisors, actual, "Divisors for {0} are wrong", number);
        }


        [TestCase(1UL, new ulong[] { 1 })]
        [TestCase(2UL, new ulong[] { 2 })]
        [TestCase(6UL, new ulong[] { 2, 3 })]
        [TestCase(10UL, new ulong[] { 2, 5 })]
        [TestCase(2520UL, new ulong[] { 6, 7, 8, 9, 10 })] // 1-10, stripped down.
        public void LowestCommonMultiple_Examples_AreCorrect(ulong result, ulong[] expectedDivisors)
        {
            Assert.AreEqual(result, Factorization.GetLowestCommonMultiple(expectedDivisors));
        }


        [TestCase(12UL, 15UL, Result = 60)]
        [TestCase(18UL, 24UL, Result = 72)]
        [TestCase(9UL, 10UL, Result = 90)]
        [TestCase(14UL, 42UL, Result = 42)]
        [TestCase(18UL, 30UL, Result = 90)]
        public ulong LowestCommonMultiple_Examples_AreCorrect(ulong a, ulong b)
        {
            return Factorization.GetLowestCommonMultiple(a, b);
        }


        [TestCase(5UL, 5UL, Result = 5)]
        [TestCase(15UL, 5UL, Result = 5)]
        [TestCase(7UL, 9UL, Result = 1)]
        [TestCase(12UL, 9UL, Result = 3)]
        [TestCase(81UL, 57UL, Result = 3)]
        public ulong GreatestCommonDivisor_Examples_AreCorrect(ulong a, ulong b)
        {
            return Factorization.GetGreatestCommonDivisor(a, b);
        }
    }
}