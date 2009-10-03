﻿using NUnit.Framework;


namespace ProjectEuler.Tests
{
    [TestFixture]
    public class NumbersTests
    {
        [TestCase((byte) 0, 0L)] // 0 * 0 = 0
        [TestCase((byte) 1, 9L)] // 9 = 1 * 9
        [TestCase((byte) 2, 9009L)] // 9009 = 91 * 99
        [TestCase((byte) 3, 906609)] // 906609 = 913 * 993
        [TestCase((byte) 4, 99000099)] // 99000099 = 9901 * 9999
        public void FindGreatestPalindromeWith_Examples_AreCorrect(byte digits, long result)
        {
            Assert.AreEqual(result, Numbers.FindLargestPalindromeMadeFromProductOf(digits));
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