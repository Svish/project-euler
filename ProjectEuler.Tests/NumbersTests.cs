using System;
using System.Linq;
using NUnit.Framework;


namespace ProjectEuler.Tests
{
    [TestFixture]
    public class NumbersTests
    {
        [Test]
        public void IsEvenlyDivisibleBy_Zero_ThrowsException()
        {
            Assert.That(() => Numbers.IsEvenlyDivisibleBy(5, 0), Throws.TypeOf(typeof(DivideByZeroException)));
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
        [TestCase((byte)0, 0L)] // 0 * 0 = 0
        [TestCase((byte)1, 9L)] // 9 = 1 * 9
        [TestCase((byte)2, 9009L)] // 9009 = 91 * 99
        [TestCase((byte)3, 906609)] // 906609 = 913 * 993
        [TestCase((byte)4, 99000099)] // 99000099 = 9901 * 9999
        public void FindGreatestPalindromeWith_Examples_AreCorrect(byte digits, long result)
        {
            Assert.AreEqual(result, Numbers.FindLargestPalindromeMadeFromProductOf(digits));
        }


        [TestCase(0UL, Result = 1)]
        [TestCase(1UL, Result = 1)]
        [TestCase(11UL, Result = 2)]
        [TestCase(111UL, Result = 3)]
        [TestCase(1234567UL, Result = 7)]
        [TestCase(ulong.MaxValue, Result = 20)]
        public byte GetNumberOfDigits_Examples_AreCorrect(ulong value)
        {
            return value.GetNumberOfDigits();
        }


        [TestCase(0UL, 0UL)]
        [TestCase(1UL, 1UL)]
        [TestCase(10UL, 1UL)]
        [TestCase(11UL, 11UL)]
        [TestCase(12UL, 21UL)]
        [TestCase(123UL, 321UL)]
        [TestCase(121UL, 121UL)]
        [TestCase(122UL, 221UL)]
        [TestCase(221UL, 122UL)]
        [TestCase(1234UL, 4321UL)]
        [TestCase(18446744073709551611UL, 11615590737044764481UL)]
        public void Reverse_Examples_AreCorrect(ulong number, ulong expected)
        {
            var actual = number.Reverse();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Reverse_NumberOutOfRange_ThrowsArgumentOutOfRange()
        {
            Assert.That(() => 18446744073709551612.Reverse(), Throws.TypeOf(typeof(ArgumentOutOfRangeException)));
        }


        [TestCase(0UL)]
        [TestCase(1UL)]
        [TestCase(11UL)]
        [TestCase(22UL)]
        [TestCase(111UL)]
        [TestCase(121UL)]
        [TestCase(212UL)]
        [TestCase(1001UL)]
        [TestCase(2112UL)]
        [TestCase(10101UL)]
        [TestCase(21012UL)]
        public void IsPalindrome_Int64Palindromes_ReturnsTrue(ulong value)
        {
            Assert.IsTrue(value.IsPalindrome());
        }


        [TestCase(12UL)]
        [TestCase(21UL)]
        [TestCase(123UL)]
        [TestCase(321UL)]
        [TestCase(122UL)]
        [TestCase(221UL)]
        [TestCase(1234UL)]
        [TestCase(12345UL)]
        [TestCase(54321UL)]
        [TestCase(332211UL)]
        [TestCase(112233UL)]
        public void IsPalindrome_Int64NotPalindromes_ReturnsFalse(ulong value)
        {
            Assert.IsFalse(value.IsPalindrome());
        }


        [TestCase(1UL, Result = 1)]
        [TestCase(2UL, Result = 1 + 2)]
        [TestCase(10UL, Result = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10)]
        public ulong SumExpansionK1(ulong n)
        {
            return Numbers.SumExpansionK1(n);
        }


        [TestCase(1UL, Result = 1)]
        [TestCase(2UL, Result = 1 + 4)]
        [TestCase(10UL, Result = 1 + 4 + 9 + 16 + 25 + 36 + 49 + 64 + 81 + 100)]
        public ulong SumExpansionK2(ulong n)
        {
            return Numbers.SumExpansionK2(n);
        }
    }
}