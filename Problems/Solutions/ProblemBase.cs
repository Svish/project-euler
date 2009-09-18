namespace Problems.Solutions
{
    public abstract class ProblemBase : ISolution
    {
        private readonly long expectedAnswer;


        protected ProblemBase(long expectedAnswer)
        {
            this.expectedAnswer = expectedAnswer;
        }


        #region ISolution Members
        long ISolution.ExpectedAnswer
        {
            get { return expectedAnswer; }
        }


        long ISolution.ActualAnswer
        {
            get { return GetAnswer(); }
        }
        #endregion


        protected abstract long GetAnswer();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}