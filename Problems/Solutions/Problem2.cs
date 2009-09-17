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


        public override long GetAnswer()
        {
            return (long) new Fibonacci()
                .Where(x => x%2 == 0)
                .TakeWhile(x => x < 4000000)
                .Aggregate((sum, x) => sum + x);
        }
    }
}