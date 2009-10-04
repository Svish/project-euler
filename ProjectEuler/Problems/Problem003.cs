using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem003 : ProblemBase<ulong>
    {
        public Problem003()
            : base(6857UL)
        {
            AddSolution(Solution);
        }


        private static ulong Solution()
        {
            return Factorization.GetPrimeFactors(600851475143, new Eratosthenes()).Max();
        }
    }
}