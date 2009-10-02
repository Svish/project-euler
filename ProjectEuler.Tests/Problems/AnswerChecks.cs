using NUnit.Framework;
using ProjectEuler.Problems;


namespace ProjectEuler.Tests.Problems
{
    [TestFixture]
    public class AnswerChecks
    {
        [Test]
        public void AllSolutions_ReturnAnswerToProblem()
        {
            foreach (var problem in new ProblemIterator())
                foreach (var s in problem.GetSolutions())
                {
                    var expected = problem.ExpectedAnswer;
                    var actual = s.GetAnswer();

                    Assert.AreEqual(expected, actual, "Answer to problem {0} is wrong.", problem);
                }
        }
    }
}