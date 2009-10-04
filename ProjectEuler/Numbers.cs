using System;
using System.Globalization;


namespace ProjectEuler
{
    public static class Numbers
    {
        /// <summary>
        /// Reverses the number.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">If n is greater than 18446744073709551611.</exception>
        public static ulong Reverse(this ulong n)
        {
            if (n > 18446744073709551611)
                throw new ArgumentOutOfRangeException("n");

            ulong r = 0;
            while (n > 0)
            {
                r = 10 * r + n % 10;
                n /= 10;
            }
            return r;
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
        /// Returns true if the given value is evenly divisible 
        /// by all the given divisors; otherwise false.
        /// </summary>
        public static bool IsEvenlyDivisibleBy(this ulong value, params ulong[] divisors)
        {
            foreach (var divisor in divisors)
                if (value % divisor != 0)
                    return false;
            return true;
        }
    }
}