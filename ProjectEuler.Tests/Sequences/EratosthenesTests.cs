using NUnit.Framework;
using ProjectEuler.Sequences;


namespace ProjectEuler.Tests.Sequences
{
    [TestFixture]
    public class EratosthenesTests : PrimeSequenceTests<Eratosthenes>
    {
        protected override Eratosthenes GetSequence()
        {
            return new Eratosthenes();
        }
    }
}