namespace Problems.Solutions
{
    public abstract class ProblemBase : ISolution
    {
        private readonly long expectedAnswer;
        private readonly int problemId;


        protected ProblemBase(int problemId, long expectedAnswer)
        {
            this.problemId = problemId;
            this.expectedAnswer = expectedAnswer;
        }


        #region ISolution Members
        int ISolution.ProblemId
        {
            get { return problemId; }
        }


        long ISolution.ExpectedAnswer
        {
            get { return expectedAnswer; }
        }


        public abstract long GetAnswer();
        #endregion
    }
}