using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Problems
{
    /// <summary>
    /// Generates prime numbers by using a variation upon the Sieve of Eratosthenes algorithm.
    /// </summary>
    // http://www.blackwasp.co.uk/Eratosthenes.aspx
    // http://www.blackwasp.co.uk/PrimeFactors.aspx
    public class Eratosthenes : IPrimeSequence
    {
        private readonly List<long> primes;


        /// <summary>
        /// Initializes a new <see cref="Eratosthenes"/> prime number generator.
        /// </summary>
        public Eratosthenes()
        {
            primes = new List<long> {2, 3};
        }


        #region IPrimeSequence Members
        public IEnumerator<long> GetEnumerator()
        {
            // Return the ones we know
            foreach (long prime in primes)
                yield return prime;

            // Then find new ones
            long possible = primes.Last();
            while (true)
                if (IsPrime(possible += 2))
                {
                    yield return possible;
                    primes.Add(possible);
                }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion


        /// <summary>
        /// Returns the prime factors of the given number. Uses an instance of <see cref="Eratosthenes"/> for <see cref="IPrimeSequence"/>.
        /// </summary>
        public static IEnumerable<long> GetPrimeFactors(long value)
        {
            return GetPrimeFactors(value, new Eratosthenes());
        }


        /// <summary>
        /// Returns the prime factors of the given number.
        /// </summary>
        public static IEnumerable<long> GetPrimeFactors(long value, IPrimeSequence primeSequence)
        {
            foreach (int prime in primeSequence)
            {
                while (value%prime == 0)
                {
                    value /= prime;
                    yield return prime;
                }

                if (value == 1)
                {
                    yield break;
                }
            }
        }


        private bool IsPrime(long value)
        {
            long sqrt = (long) Math.Sqrt(value);
            return !primes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value%x == 0);
        }
    }
}