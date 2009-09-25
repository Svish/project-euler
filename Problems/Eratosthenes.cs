using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Problems
{
    /// <summary>
    /// Generates prime numbers by using a variation upon the 
    /// Sieve of Eratosthenes algorithm.
    /// </summary>
    /// <remarks>The <see cref="GetEnumerator()"/> method never returns.</remarks>
    public class Eratosthenes : IPrimeSequence
    {
        // http://www.blackwasp.co.uk/Eratosthenes.aspx
        // http://www.blackwasp.co.uk/PrimeFactors.aspx

        private readonly List<ulong> knownPrimes;

        /// <summary>
        /// Initializes a new <see cref="Eratosthenes"/> prime number generator.
        /// </summary>
        public Eratosthenes()
        {
            knownPrimes = new List<ulong> {2, 3};
        }


        #region IPrimeSequence Members
        public IEnumerator<ulong> GetEnumerator()
        {
            // Return the ones we know
            foreach (var prime in knownPrimes)
                yield return prime;

            // Then find new ones
            var possible = knownPrimes.Last();
            while (true)
                if (IsPrime(possible += 2))
                {
                    yield return possible;
                    knownPrimes.Add(possible);
                }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion


        /// <summary>
        /// Returns the prime factors of the given number. 
        /// Uses an instance of <see cref="Eratosthenes"/> for <see cref="IPrimeSequence"/>.
        /// </summary>
        public static IEnumerable<ulong> GetPrimeFactors(ulong value)
        {
            return GetPrimeFactors(value, new Eratosthenes());
        }


        /// <summary>
        /// Returns the prime factors of the given number.
        /// </summary>
        public static IEnumerable<ulong> GetPrimeFactors(ulong value, IPrimeSequence primeSequence)
        {
            foreach (var prime in primeSequence)
            {
                while (value % prime == 0)
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


        private bool IsPrime(ulong value)
        {
            var sqrt = (ulong) Math.Sqrt(value);
            return !knownPrimes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value % x == 0);
        }
    }
}