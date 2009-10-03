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
            return 0;
            return new TriangleSequence()
                .Select(x => new
                    {
                        Number = x,
                        DivisorCount = Factorization.GetDivisors(x).Count(),
                    })
                .First(x => x.DivisorCount > 500)
                .Number;
        }
    }
}