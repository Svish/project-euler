﻿using System.Collections;
using System.Collections.Generic;


namespace ProjectEuler.Sequences
{
    /// <summary>
    /// Generates the Fibonacci sequence, starting with 0, 1, 1, 2, 3, 5 and so on.
    /// </summary>
    /// <remarks>The <see cref="GetEnumerator()"/> method never returns.</remarks>
    public class FibonacciSequence : IEnumerable<ulong>
    {
        #region IEnumerable<ulong> Members
        public IEnumerator<ulong> GetEnumerator()
        {
            var a = 0UL;
            var b = 1UL;

            while (true)
            {
                yield return a;

                var c = a + b;
                a = b;
                b = c;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}