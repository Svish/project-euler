using System;


namespace ProjectEuler.Problems
{
    public class Solution<TAnswer> : ISolution
    {
        private readonly string note;
        private readonly Func<TAnswer> solution;


        public Solution(Func<TAnswer> solution, string note)
        {
            this.solution = solution;
            this.note = note;
        }


        #region ISolution Members
        public string Note
        {
            get { return note; }
        }


        object ISolution.GetAnswer()
        {
            return solution();
        }
        #endregion


        public TAnswer GetAnswer()
        {
            return solution();
        }
    }
}