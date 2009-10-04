using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ProjectEuler.Sequences
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



        private bool IsPrime(ulong value)
        {
            var sqrt = (ulong) Math.Sqrt(value);
            return !knownPrimes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value % x == 0);
        }
    }
}