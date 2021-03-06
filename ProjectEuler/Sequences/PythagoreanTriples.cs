﻿using System.Collections;
using System.Collections.Generic;
using Lokad;


namespace ProjectEuler.Sequences
{
    /// <summary>
    /// Generates Pythagorean triplets.
    /// </summary>
    /// <remarks>The <see cref="GetEnumerator()"/> method never returns.</remarks>
    public class PythagoreanTriples : IEnumerable<Triple<ulong, ulong, ulong>>
    {
        #region IEnumerable<Triple<ulong,ulong,ulong>> Members
        public IEnumerator<Triple<ulong, ulong, ulong>> GetEnumerator()
        {
            for (ulong c = 1;; c++)
                for (ulong b = 1; b <= c; b++)
                    for (ulong a = 1; a < b; a++)
                        if ((a * a) + (b * b) == c * c)
                            yield return Tuple.From(a, b, c);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}