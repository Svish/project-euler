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
            return (long)GetLargestPalindromeMadeFromAProductOf(3);
        }


        public static ulong GetLargestPalindromeMadeFromAProductOf(byte digits)
        {
            if (digits == 0)
                return 0;

            ulong largestPalindrome = 0;

            ulong start = (ulong)Math.Pow(10, digits) - 1;
            var numbers = DecreasingNumbers(start)
                .TakeWhile(x => x.GetNumberOfDigits() == digits);

            foreach (var x in numbers)
                foreach (var y in numbers)
                {
                    var product = x * y;

                    if (product.IsPalindrome() && product > largestPalindrome)
                        largestPalindrome = product;
                }

            return largestPalindrome;
        }


        private static IEnumerable<ulong> DecreasingNumbers(ulong start)
        {
            do
            {
                yield return start--;
            } while (start != 0);
        }
    }
}