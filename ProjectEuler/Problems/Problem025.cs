using System;
using System.Linq;
using ProjectEuler.Sequences;
using MathNet.Numerics;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// What is the first term in the Fibonacci sequence to contain 1000 digits?
    /// </summary>
    public class Problem025 : ProblemBase<int>
    {
        // http://en.wikipedia.org/wiki/Fibonacci_series
        // http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibFormula.html


        public Problem025()
            : base(4782)
        {
            AddSolution(BruteForce, "Brute-force");
            AddSolution(Mathematical, "Calculated");
        }


        private static int BruteForce()
        {
            var sequence = new LargeFibonacciSequence();
            using (var e = sequence.GetEnumerator())
            {

                var n = 0;
                while (e.MoveNext() && e.Current.ToString().Length < 1000)
                    n++;

                return n;
            }
        }


        private static int Mathematical()
        {
            const int length = 1000;
            var n = (int)Math.Ceiling((length + Math.Log10(5) / 2 - 1) / Math.Log10(Constants.GoldenRatio));

            return n;
        }
    }
}
