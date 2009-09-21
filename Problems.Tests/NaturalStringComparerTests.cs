using NUnit.Framework;


namespace Problems.Tests
{
    [TestFixture]
    public class NaturalStringComparerTests
    {
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("1", "1")]
        [TestCase("23", "23")]
        [TestCase("a", "A")]
        [TestCase("a1", "a1")]
        [TestCase("a1", "A1")]
        [TestCase("a12b", "a12b")]
        [TestCase("A12b", "A12b")]
        public void Compare_EqualStrings_ReturnsZero(string a, string b)
        {
            Assert.That(new NaturalStringComparer().Compare(a, b), Is.EqualTo(0));
        }


        [TestCase("", "a")]
        [TestCase("a", "b")]
        [TestCase("1", "2")]
        [TestCase("2", "10")]
        [TestCase("a1", "a2")]
        [TestCase("a2", "a10")]
        [TestCase("a2b", "a10b")]
        public void Compare_CertainStrings_ReturnsLessThanZero(string a, string b)
        {
            Assert.That(new NaturalStringComparer().Compare(a, b), Is.LessThan(0));
        }


        [TestCase("a", "")]
        [TestCase("b", "a")]
        [TestCase("2", "1")]
        [TestCase("10", "2")]
        [TestCase("a2", "a1")]
        [TestCase("a10", "a2")]
        [TestCase("a10b", "a2b")]
        public void Compare_CertainStrings_ReturnsGreaterThanZero(string a, string b)
        {
            Assert.That(new NaturalStringComparer().Compare(a, b), Is.GreaterThan(0));
        }
    }
}