using System.Collections;
using System.Linq;
using Lokad;
using NUnit.Framework;


namespace Problems.Tests
{
    [TestFixture]
    public class PythagoreanTriplesTests
    {
        [Test]
        public void GetEnumerator_FirstFifty_AreCorrect()
        {
            var first = new[]
                {
                    Tuple.From(3UL, 4UL, 5UL),
                    Tuple.From(6UL, 8UL, 10UL),
                    Tuple.From(5UL, 12UL, 13UL),
                    Tuple.From(9UL, 12UL, 15UL),
                    Tuple.From(8UL, 15UL, 17UL),
                    Tuple.From(12UL, 16UL, 20UL),
                    Tuple.From(7UL, 24UL, 25UL),
                    Tuple.From(15UL, 20UL, 25UL),
                    Tuple.From(10UL, 24UL, 26UL),
                    Tuple.From(20UL, 21UL, 29UL),
                    Tuple.From(18UL, 24UL, 30UL),
                    Tuple.From(16UL, 30UL, 34UL),
                    Tuple.From(21UL, 28UL, 35UL),
                    Tuple.From(12UL, 35UL, 37UL),
                    Tuple.From(15UL, 36UL, 39UL),
                    Tuple.From(24UL, 32UL, 40UL),
                    Tuple.From(9UL, 40UL, 41UL),
                    Tuple.From(27UL, 36UL, 45UL),
                    Tuple.From(14UL, 48UL, 50UL),
                    Tuple.From(30UL, 40UL, 50UL),
                    Tuple.From(24UL, 45UL, 51UL),
                    Tuple.From(20UL, 48UL, 52UL),
                    Tuple.From(28UL, 45UL, 53UL),
                    Tuple.From(33UL, 44UL, 55UL),
                    Tuple.From(40UL, 42UL, 58UL),
                    Tuple.From(36UL, 48UL, 60UL),
                    Tuple.From(11UL, 60UL, 61UL),
                    Tuple.From(16UL, 63UL, 65UL),
                    Tuple.From(25UL, 60UL, 65UL),
                    Tuple.From(33UL, 56UL, 65UL),
                    Tuple.From(39UL, 52UL, 65UL),
                    Tuple.From(32UL, 60UL, 68UL),
                    Tuple.From(42UL, 56UL, 70UL),
                    Tuple.From(48UL, 55UL, 73UL),
                    Tuple.From(24UL, 70UL, 74UL),
                    Tuple.From(21UL, 72UL, 75UL),
                    Tuple.From(45UL, 60UL, 75UL),
                    Tuple.From(30UL, 72UL, 78UL),
                    Tuple.From(48UL, 64UL, 80UL),
                    Tuple.From(18UL, 80UL, 82UL),
                    Tuple.From(13UL, 84UL, 85UL),
                    Tuple.From(36UL, 77UL, 85UL),
                    Tuple.From(40UL, 75UL, 85UL),
                    Tuple.From(51UL, 68UL, 85UL),
                    Tuple.From(60UL, 63UL, 87UL),
                    Tuple.From(39UL, 80UL, 89UL),
                    Tuple.From(54UL, 72UL, 90UL),
                    Tuple.From(35UL, 84UL, 91UL),
                    Tuple.From(57UL, 76UL, 95UL),
                    Tuple.From(65UL, 72UL, 97UL),
                };

            CollectionAssert.AreEquivalent(first, new PythagoreanTriples().Take(50).ToArray());
        }


        [Test]
        public void GetEnumerator_GenericAndRegular_FirstFiftyAreTheSame()
        {
            var gen = new PythagoreanTriples();

            using (var g = gen.GetEnumerator())
            {
                var e = (gen as IEnumerable).GetEnumerator();
                
                int i = 0;
                while (i++ < 50 && g.MoveNext() && e.MoveNext())
                    Assert.AreEqual(g.Current, e.Current);
            }
        }
    }
}