using System;
using System.Globalization;


namespace Problems
{
    public static class Numbers
    {
        /// <summary>
        /// Rerverses the number.
        /// </summary>
        public static uint Reverse(this uint n)
        {
            uint r = 0;
            while (n > 0)
            {
                r = 10*r + n%10;
                n /= 10;
            }
            return r;
        }

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


        public static bool IsPalindrome(this uint n)
        {
            return n == n.Reverse();
        }


        public static bool IsPalindrome(this ulong n)
        {
            return n == n.Reverse();
        }


        public static byte GetNumberOfDigits(this uint value)
        {
            return (byte) value.ToString(CultureInfo.InvariantCulture).Length;
        }


        public static byte GetNumberOfDigits(this ulong value)
        {
            return (byte) value.ToString(CultureInfo.InvariantCulture).Length;
        }

        public static ulong FindSmallestNumberDivisibleBy(params ulong[] divisors)
        {
            ulong n = 1;

            while (!n.IsEvenlyDivisibleBy(divisors) && n <= long.MaxValue)
                n++;

            if (n == long.MaxValue && !n.IsEvenlyDivisibleBy(divisors))
                return 0;

            return n;
        }

        public static ulong FindLargestPalindromeMadeFromProductOf(byte digits)
        {
            if (digits == 0)
                return 0;

            ulong largestPalindrome = 0;

            var upper = (ulong)Math.Pow(10, digits) - 1;
            var lower = (ulong)Math.Pow(10, digits - 1);

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
            
            //Console.WriteLine("{2} = {1} * {0}", a, b, largestPalindrome);
            return largestPalindrome;
        }


        public static bool IsEvenlyDivisibleBy(this ulong value, params ulong[] divisors)
        {
            foreach(var divisor in divisors)
                if(value%divisor != 0)
                    return false;
            return true;
        }
    }
}