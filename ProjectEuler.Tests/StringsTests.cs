using System;
using NUnit.Framework;


namespace ProjectEuler.Tests
{
    [TestFixture]
    public class StringsTests
    {
        [Test]
        public void Truncate_LongerThanLength_TruncatedToLength()
        {
            var actual = "hello".Truncate(2);
            Assert.AreEqual("he", actual);
        }

        [Test]
        public void Truncate_EqualToLength_ReturnsOriginal()
        {
            var actual = "hello".Truncate(5);
            Assert.AreEqual("hello", actual);
        }

        [Test]
        public void Truncate_ShorterThanLength_ReturnsOriginal()
        {
            var actual = "hello".Truncate(10);
            Assert.AreEqual("hello", actual);
        }

        [Test]
        public void Truncate_EmptyString_ReturnsEmptyString()
        {
            var actual = "".Truncate(10);
            Assert.AreEqual("", actual);
        }


        [TestCase("a")]
        [TestCase("aa")]
        [TestCase("aaa")]
        [TestCase("abba")]
        [TestCase("abcdcba")]
        [TestCase("abcddcba")]
        [TestCase("������")]
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
        [TestCase("������")]
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