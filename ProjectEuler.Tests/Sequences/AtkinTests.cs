using NUnit.Framework;
using ProjectEuler.Sequences;

namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class AtkinTests : PrimeSequenceTests<Atkin>
    {
        protected override Atkin GetSequence()
        {
            return new Atkin(4000);
        }
    }
}