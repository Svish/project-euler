using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
    /// we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
    /// </summary>
    public class Problem007 : ProblemBase<ulong>
    {
        public Problem007()
            : base(104743)
        {
            AddSolution(GetAnswer);
        }
        
        private static ulong GetAnswer()
        {
            return new Eratosthenes().Take(10001).Last();
        }
    }
}