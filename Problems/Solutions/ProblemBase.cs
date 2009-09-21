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
        object ISolution.ExpectedAnswer
        {
            get { return expectedAnswer; }
        }


        object ISolution.ActualAnswer
        {
            get { return GetAnswer(); }
        }
        #endregion


        protected abstract object GetAnswer();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}