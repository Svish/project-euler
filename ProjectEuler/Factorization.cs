using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler
{
    public static class Factorization
    {
        /// <summary>
        /// Returns the Lowest Common Multiple, the smallest number 
        /// that is divisible by all the given divisors; 
        /// zero if none could be found.
        /// </summary>
        public static ulong Lcm(params ulong[] divisors)
        {
            return divisors.Aggregate(1UL, (a, b) => a / Gcd(a, b) * b);
        }


        /// <summary>
        /// Returns the Greatest Common Divisor of two numbers.
        /// </summary>
        public static ulong Gcd(ulong a, ulong b)
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
        /// Returns all the divisors of the given number. (Naive trial division)
        /// </summary>
        public static IEnumerable<ulong> GetDivisorsNaive(ulong number)
        {
            if (number == 0)
                yield break;

            var limit = number / 2;
            for (ulong i = 1; i <= limit; i++)
                if (number % i == 0)
                    yield return i;

            yield return number;
        }


        /// <summary>
        /// Returns the number of possible divisors for the given number.
        /// </summary>
        // http://stackoverflow.com/questions/110344/algorithm-to-calculate-the-number-of-divisors-of-a-given-number/118712#118712
        public static ulong GetCountOfDivisors(ulong number)
        {
            if (number == 0)
                return 0;

            var divisors = 1UL;

            foreach (var prime in new ProbablePrimeSequence())
            {
                var exponent = 0UL;
                while (number % prime == 0)
                {
                    exponent += 1;
                    number /= prime;
                }

                if (exponent > 0)
                    divisors *= exponent + 1;

                if (number == 1)
                    break;
            }
            return divisors;
        }

    }
}
