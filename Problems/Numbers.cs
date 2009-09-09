﻿using System;
using System.Globalization;


namespace Problems
{
    public static class Numbers
    {
        /// <summary>
        /// Reverses the number.
        public static ulong Reverse(this ulong n)
        {
            ulong r = 0L;
            while (n > 0)
            {
                r = 10*r + n%10;
                n /= 10;
            }
            return r;
        }


        /// <summary>
        /// Returns the greatest common divisor of the two numbers.
        /// </summary>
        public static ulong GetGreatestCommonDivisor(ulong a, ulong b)
        {
            while (b != 0)
            {
                ulong t = b;
                b = a%b;
                a = t;
            }
            return a;
        }


        /// <summary>
        /// Returns true if the given number is a palindrome; otherwise false.
        /// </summary>
        public static bool IsPalindrome(this ulong n)
        {
            return n == n.Reverse();
        }


        /// <summary>
        /// Returns the number of digits in the given value.
        /// </summary>
        public static byte GetNumberOfDigits(this ulong value)
        {
            return (byte) value.ToString(CultureInfo.InvariantCulture).Length;
        }


        /// <summary>
        /// Finds the smalles number that is divisible by the given divisors; zero if none could be found.
        /// </summary>
        public static ulong FindSmallestNumberDivisibleBy(params ulong[] divisors)
        {
            ulong n = 1;

            while (!n.IsEvenlyDivisibleBy(divisors) && n <= long.MaxValue)
                n++;

            if (n == long.MaxValue && !n.IsEvenlyDivisibleBy(divisors))
                return 0;

            return n;
        }


        /// <summary>
        /// Finds the largest palindrome that can be made from the product of two numbers
        /// with the given number of digits.
        /// </summary>
        public static ulong FindLargestPalindromeMadeFromProductOf(byte digits)
        {
            if (digits == 0)
                return 0;

            ulong largestPalindrome = 0;

            ulong upper = (ulong) Math.Pow(10, digits) - 1;
            ulong lower = (ulong) Math.Pow(10, digits - 1);

            for (ulong x = upper; x >= lower; x--)
                for (ulong y = upper; y >= lower; y--)
                {
                    ulong product = x*y;

                    if (product > largestPalindrome && product.IsPalindrome())
                    {
                        largestPalindrome = product;
                        break;
                    }
                }

            //Console.WriteLine("{2} = {1} * {0}", a, b, largestPalindrome);
            return largestPalindrome;
        }


        /// <summary>
        /// Returns true if the given value is evenly divisible by all the given divisors; otherwise false.
        /// </summary>
        public static bool IsEvenlyDivisibleBy(this ulong value, params ulong[] divisors)
        {
            foreach (ulong divisor in divisors)
                if (value%divisor != 0)
                    return false;
            return true;
        }
    }
}