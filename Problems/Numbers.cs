using System;
using System.Globalization;
using System.Linq;


namespace Problems
{
    public static class Numbers
    {
        /// <summary>
        /// Returns the sum of 1 + 2 + 3 + ... + n. (Sum n)
        /// </summary>
        public static ulong SumExpansionK1(ulong n)
        {
            return (n * n + n) / 2;
        }


        /// <summary>
        /// Returns the sum of 1^2 + 2^2 + 3^2 + ... + n^2. (Sum n^2)
        /// </summary>
        public static ulong SumExpansionK2(ulong n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }


        /// <summary>
        /// Reverses the number.
        /// </summary>
        public static ulong Reverse(this ulong n)
        {
            ulong r = 0L;
            while (n > 0)
            {
                r = 10 * r + n % 10;
                n /= 10;
            }
            return r;
        }


        /// <summary>
        /// Finds the smalles number that is divisible by the given divisors; zero if none could be found.
        /// </summary>
        public static ulong GetLowestCommonMultiple(params ulong[] divisors)
        {
            return divisors.Aggregate(1UL, (a, b) => a / GetGreatestCommonDivisor(a, b) * b);
        }


        /// <summary>
        /// Returns the greatest common divisor of two numbers.
        /// </summary>
        public static ulong GetGreatestCommonDivisor(ulong a, ulong b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
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
        /// Finds the largest palindrome that can be made from the product of two numbers
        /// with the given number of digits.
        /// </summary>
        public static ulong FindLargestPalindromeMadeFromProductOf(byte digits)
        {
            if (digits == 0)
                return 0;

            ulong largestPalindrome = 0;

            var upper = (ulong) Math.Pow(10, digits) - 1;
            var lower = (ulong) Math.Pow(10, digits - 1);

            for (var x = upper; x >= lower; x--)
                for (var y = upper; y >= lower; y--)
                {
                    var product = x * y;

                    if (product > largestPalindrome && product.IsPalindrome())
                    {
                        largestPalindrome = product;
                        break;
                    }
                }

            return largestPalindrome;
        }


        /// <summary>
        /// Returns true if the given value is evenly divisible by all the given divisors; otherwise false.
        /// </summary>
        public static bool IsEvenlyDivisibleBy(this ulong value, params ulong[] divisors)
        {
            if (divisors.Any(x => x == 0))
                throw new ArgumentException("Divisors can not be zero.");
            foreach (var divisor in divisors)
                if (value % divisor != 0)
                    return false;
            return true;
        }
    }
}