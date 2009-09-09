﻿using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
    /// By starting with 1 and 2, the first 10 terms will be:
    ///  
    ///     1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// 
    /// Find the sum of all the even-valued terms in the sequence which do not exceed four million.
    /// </summary>
    public class Problem2 : ProblemBase
    {
        public Problem2()
            : base(2, 4613732) {}


        public static long SumOfEvenFibonacciNumbersUpTo(ulong limit, IFibonacciSequence sequence)
        {
            return sequence
                .Where(x => x%2 == 0)
                .TakeWhile(x => x < limit)
                .Select(x => (long) x)
                .Sum();
        }


        public override long GetAnswer()
        {
            return SumOfEvenFibonacciNumbersUpTo(4000000, new Fibonacci());
        }
    }
}