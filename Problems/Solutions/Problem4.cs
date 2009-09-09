using System;
using System.Collections.Generic;
using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Problem4 : ProblemBase
    {
        public Problem4()
            : base(4, 906609) { }


        public override long GetAnswer()
        {
            return (long)Numbers.GetLargestPalindromeMadeFromProductOf(3);
        }
    }
}