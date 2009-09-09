﻿using NUnit.Framework;


namespace Problems.Tests
{
    [TestFixture]
    public class NumbersTests
    {
        [TestCase(5UL, 5UL, Result = 5)]
        [TestCase(15UL, 5UL, Result = 5)]
        [TestCase(7UL, 9UL, Result = 1)]
        [TestCase(12UL, 9UL, Result = 3)]
        [TestCase(81UL, 57UL, Result = 3)]
        public ulong GreatestCommonDivisor_Examples_AreCorrect(ulong a, ulong b)
        {
            return Numbers.GetGreatestCommonDivisor(a, b);
        }


        [TestCase(0UL, 1)]
        [TestCase(1UL, 1)]
        [TestCase(11UL, 2)]
        [TestCase(111UL, 3)]
        [TestCase(1234567UL, 7)]
        [TestCase(ulong.MaxValue, 20)]
        [TestCase(ulong.MinValue, 1)]
        public void GetNumberOfDigits_Int64Numbers(ulong value, int actualDigits)
        {
            Assert.AreEqual(actualDigits, value.GetNumberOfDigits());
        }


        [TestCase(0U, 1)]
        [TestCase(1U, 1)]
        [TestCase(11U, 2)]
        [TestCase(111U, 3)]
        [TestCase(1234567U, 7)]
        [TestCase(uint.MaxValue, 10)]
        [TestCase(uint.MinValue, 1)]
        public void GetNumberOfDigits_Int32Numbers(uint value, int actualDigits)
        {
            Assert.AreEqual(actualDigits, value.GetNumberOfDigits());
        }


        [TestCase(0U, 0U)]
        [TestCase(1U, 1U)]
        [TestCase(10U, 1U)]
        [TestCase(11U, 11U)]
        [TestCase(12U, 21U)]
        [TestCase(123U, 321U)]
        [TestCase(121U, 121U)]
        [TestCase(122U, 221U)]
        [TestCase(221U, 122U)]
        [TestCase(1234U, 4321U)]
        public void Reverse_Int32Numbers(uint value, uint reversed)
        {
            Assert.AreEqual(value.Reverse(), reversed);
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
        public void Reverse_Int64Numbers(ulong value, ulong reversed)
        {
            Assert.AreEqual(value.Reverse(), reversed);
        }


        [TestCase(0U)]
        [TestCase(1U)]
        [TestCase(11U)]
        [TestCase(22U)]
        [TestCase(111U)]
        [TestCase(121U)]
        [TestCase(212U)]
        [TestCase(1001U)]
        [TestCase(2112U)]
        [TestCase(10101U)]
        [TestCase(21012U)]
        public void IsPalindrome_Int32Palindromes_ReturnsTrue(uint value)
        {
            Assert.IsTrue(value.IsPalindrome());
        }


        [TestCase(12U)]
        [TestCase(21U)]
        [TestCase(123U)]
        [TestCase(321U)]
        [TestCase(122U)]
        [TestCase(221U)]
        [TestCase(1234U)]
        [TestCase(12345U)]
        [TestCase(54321U)]
        [TestCase(332211U)]
        [TestCase(112233U)]
        public void IsPalindrome_Int32NotPalindromes_ReturnsFalse(uint value)
        {
            Assert.IsFalse(value.IsPalindrome());
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
    }
}