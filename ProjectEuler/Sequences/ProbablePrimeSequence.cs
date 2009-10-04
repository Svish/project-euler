using System.Collections;
using System.Collections.Generic;


namespace ProjectEuler.Sequences
{
    /// <summary>
    /// Generates a sequence of probable primes.
    /// </summary>
    // http://stackoverflow.com/questions/110344/algorithm-to-calculate-the-number-of-divisors-of-a-given-number/118712#118712
    public class ProbablePrimeSequence : IEnumerable<ulong>
    {
        #region IEnumerable<ulong> Members
        public IEnumerator<ulong> GetEnumerator()
        {
            yield return 2;
            yield return 3;
            ulong i = 5;
            while (true)
            {
                yield return i;
                if (i % 6 == 1)
                    i += 2;
                i += 2;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}