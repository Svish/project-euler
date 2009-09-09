using System;
using System.Collections.Generic;
using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem5 : ProblemBase
    {
        public Problem5()
            : base(5, 232792560) { }


        public override long GetAnswer()
        {
            // Skips 1 to 10, since they are "covered" in the others
            var divisors = new ulong[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            return (long)Numbers.FindSmallestNumberDivisibleBy(divisors);
        }
    }
}