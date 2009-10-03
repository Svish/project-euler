using System.Collections;
using System.Collections.Generic;


namespace ProjectEuler
{
    /// <summary>
    /// Generates the triangle sequence, starting with 1, 3, 6, 10, 15 and so on.
    /// </summary>
    public class TriangleSequence : IEnumerable<ulong>
    {
        #region IEnumerable<ulong> Members
        public IEnumerator<ulong> GetEnumerator()
        {
            ulong sum = 0;
            for (ulong i = 1;; i++)
            {
                sum += i;
                yield return sum;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}