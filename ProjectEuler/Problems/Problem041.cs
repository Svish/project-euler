using System;
using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
    /// 
    /// What is the largest n-digit pandigital prime that exists?
    /// </summary>
    public class Problem041 : ProblemBase<ulong>
    {
        // http://en.wikipedia.org/wiki/Fibonacci_series
        // http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibFormula.html


        public Problem041()
            : base(0)
        {
            AddSolution(BruteForce, "Brute-force");
        }


        private static ulong BruteForce()
        {
            var primes = new Atkin(987654321);

            return 0;
        }
    }
}
