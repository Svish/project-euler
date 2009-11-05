using System;
using ProjectEuler.Sequences;
using MathNet.Numerics;


namespace ProjectEuler.Problems
{
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
            var sequence = new LargeFibonacciSequence().GetEnumerator();

            var n = 0;
            while (sequence.MoveNext() && sequence.Current.ToString().Length < 1000)
                n++;

            return n;
        }


        public int Mathematical()
        {
            const int length = 1000;
            var digits = (int)Math.Ceiling((length + Math.Log10(5) / 2 - 1) / Math.Log10(Constants.GoldenRatio));

            return digits;
        }
    }
}
