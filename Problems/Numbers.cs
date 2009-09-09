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
    }
}