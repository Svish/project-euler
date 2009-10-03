using System;
using System.Linq;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// What is the value of the first triangle number 
    /// to have over five hundred divisors?
    /// </summary>
    public class Problem012 : ProblemBase<ulong>
    {
        public Problem012()
            : base(0)
        {
            AddSolution(Solution);
        }


        private static ulong Solution()
        {
            throw new NotImplementedException();
            return new TriangleSequence()
                .First(x => Factorization.GetCountOfDivisors(x) > 500);
        }
    }
}