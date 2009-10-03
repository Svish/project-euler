using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public static class Factorization
    {


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
        /// Returns the prime factors of the given number.
        /// </summary>
        public static IEnumerable<ulong> GetPrimeFactors(ulong number, IPrimeSequence primeSequence)
        {
            foreach (var prime in primeSequence)
            {
                while (number % prime == 0)
                {
                    number /= prime;
                    yield return prime;
                }

                if (number == 1)
                {
                    yield break;
                }
            }
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

        /// <summary>
        /// Returns all the divisors of the given number.
        /// </summary>
        public static IEnumerable<ulong> GetDivisors(ulong number)
        {
            var limit = number / 2;
            for (ulong i = 1; i <= limit; i++)
                if (number % i == 0)
                    yield return i;

            yield return number;
        }
    }
}
