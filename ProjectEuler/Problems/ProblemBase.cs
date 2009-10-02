using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectEuler.Problems
{
    public abstract class ProblemBase<TAnswer> : IProblem
    {
        private readonly TAnswer answer;
        private readonly List<ISolution> solutions;


        protected ProblemBase(TAnswer answer)
        {
            this.answer = answer;
            solutions = new List<ISolution>();
        }


        #region IProblem Members
        object IProblem.ExpectedAnswer
        {
            get { return answer; }
        }


        IEnumerable<ISolution> IProblem.GetSolutions()
        {
            return solutions.OfType<ISolution>();
        }
        #endregion


        protected void AddSolution(Func<TAnswer> f)
        {
            AddSolution(f, null);
        }


        protected void AddSolution(Func<TAnswer> f, string note)
        {
            solutions.Add(new Solution<TAnswer>(f, note));
        }


        public override string ToString()
        {
            return GetType().Name;
        }
    }
}