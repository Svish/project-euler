using System.Collections;
using System.Collections.Generic;
using Oyster.Math;


namespace ProjectEuler.Sequences
{
    /// <summary>
    /// Generates the Fibonacci sequence, starting with 0, 1, 1, 2, 3, 5 and so on.
    /// </summary>
    /// <remarks>The <see cref="GetEnumerator()"/> method never returns.</remarks>
    public class LargeFibonacciSequence : IEnumerable<IntX>
    {
        #region IEnumerable<ulong> Members
        public IEnumerator<IntX> GetEnumerator()
        {
            var a = new IntX(0);
            var b = new IntX(1);

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