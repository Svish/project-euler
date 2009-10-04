using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// What is the value of the first triangle number 
    /// to have over five hundred divisors?
    /// </summary>
    public class Problem012 : ProblemBase<ulong>
    {
        public Problem012()
            : base(76576500)
        {
            AddSolution(Solution);
        }


        private static ulong Solution()
        {
            return new TriangleSequence()
                .First(x => Factorization.GetCountOfDivisors(x) > 500);
        }
    }
}