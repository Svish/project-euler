using NUnit.Framework;
using ProjectEuler.Sequences;
using System.Linq;


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