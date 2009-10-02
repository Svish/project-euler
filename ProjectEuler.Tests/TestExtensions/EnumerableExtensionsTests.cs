using System.Collections;
using NUnit.Framework;


namespace ProjectEuler.Tests.TestExtensions
{
    [TestFixture]
    public class EnumerableExtensionsTests
    {
        private class EmptyCollection : IEnumerable
        {
            #region IEnumerable Members
            public IEnumerator GetEnumerator()
            {
                yield break;
            }
            #endregion
        }


        private class RegularCollection : IEnumerable
        {
            #region IEnumerable Members
            public IEnumerator GetEnumerator()
            {
                for (var i = 0; i < 5; i++)
                    yield return i;
            }
            #endregion
        }


        [Test]
        public void Select_EmptyCollection_ReturnsEmpty()
        {
            var actual = new EmptyCollection().Select<int, string>(null);
            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Select_NonemptyCollection_DoesTheConversion()
        {
            var actual = new RegularCollection().Select<int, string>(x => x.ToString());
            var expected = new[] { "0", "1", "2", "3", "4" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void Take_AskingForEqualNumber_GetWhatIsThere()
        {
            var actual = new RegularCollection().Take(5);
            var expected = new[] {0, 1, 2, 3, 4};
            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void Take_AskingForLess_GetOnlyWhatWeAskFor()
        {
            var actual = new RegularCollection().Take(3);
            CollectionAssert.AreEqual(new[] {0, 1, 2}, actual);
        }


        [Test]
        public void Take_AskingForMore_GetWhatIsThere()
        {
            var actual = new RegularCollection().Take(10);
            var expected = new[] {0, 1, 2, 3, 4};
            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void Take_EmptyCollection_ReturnsEmptyCollection()
        {
            var actual = new EmptyCollection().Take(5);
            Assert.That(actual, Is.Empty);
        }
    }
}