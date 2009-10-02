using System;
using NUnit.Framework;


namespace Problems.Tests
{
    [TestFixture]
    public class StringsTests
    {
        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aaa")]
        [TestCase("abba")]
        [TestCase("abcdcba")]
        [TestCase("abcddcba")]
        [TestCase("זרוורז")]
        public void IsPalindrome_True(string s)
        {
            Assert.IsTrue(s.IsPalindrome());
        }


        [TestCase(null)]
        [TestCase("")]
        [TestCase("ab")]
        [TestCase("abb")]
        [TestCase("abc")]
        [TestCase("abca")]
        [TestCase("abasdkjqwe")]
        [TestCase("זרוזרו")]
        [TestCase("aA")]
        [TestCase("aBcDCBA")]
        [TestCase("aBcDdCbA")]
        public void IsPalindrome_False(string s)
        {
            Assert.IsFalse(s.IsPalindrome());
        }


        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        [TestCase("abc", "cba")]
        [TestCase("ABC", "CBA")]
        [TestCase("AbC", "CbA")]
        public void Reverse(string original, string reverse)
        {
            Assert.AreEqual(original.Reverse(), reverse);
        }


        [Test]
        public void Reverse_NullString_ThrowsArgumentNullException()
        {
            Assert.That(() => Strings.Reverse(null), Throws.InstanceOf(typeof (ArgumentNullException)));
        }
    }
}