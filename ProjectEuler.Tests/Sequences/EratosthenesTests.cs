using NUnit.Framework;
using ProjectEuler.Sequences;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class EratosthenesTests : PrimeSequenceTestBase<Eratosthenes>
    {
        protected override Eratosthenes GetPrimeSequence()
        {
            return new Eratosthenes();
        }
    }
}