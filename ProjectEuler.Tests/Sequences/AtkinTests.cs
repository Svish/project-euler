using NUnit.Framework;
using ProjectEuler.Sequences;

namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class AtkinTests : PrimeSequenceTestBase<Atkin>
    {
        protected override Atkin GetPrimeSequence()
        {
            const int enoughPrimesToPastTest = 4000;

            return new Atkin(enoughPrimesToPastTest);
        }
    }
}