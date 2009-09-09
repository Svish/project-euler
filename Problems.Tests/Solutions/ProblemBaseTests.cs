using NUnit.Framework;
using Problems.Solutions;


namespace Problems.Tests.Solutions
{
    [TestFixture]
    public class ProblemBaseTests
    {
        private class ProblemBaseImplementation : ProblemBase
        {
            public ProblemBaseImplementation(int problemId, long expectedAnswer)
                : base(problemId, expectedAnswer) {}


            public override long GetAnswer()
            {
                return 0;
            }
        }


        [Test]
        public void Constructor_ValidParameters_PropertiesAreCorrect()
        {
            ISolution solution = new ProblemBaseImplementation(7, 77);
            Assert.AreEqual(7, solution.ProblemId);
            Assert.AreEqual(77, solution.ExpectedAnswer);
            Assert.AreEqual(0, solution.GetAnswer());
        }
    }
}