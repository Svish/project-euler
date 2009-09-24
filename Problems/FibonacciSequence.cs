using System.Collections;
using System.Collections.Generic;


namespace Problems
{
    /// <summary>
    /// Generates the Fibonacci sequence, starting with 1, 1, 2, 3, 5 and so on.
    /// </summary>
    public class FibonacciSequence : IEnumerable<ulong>
    {
        #region IEnumerable<ulong> Members
        public IEnumerator<ulong> GetEnumerator()
        {
            var a = 0UL;
            var b = 1UL;
            var c = a + b;

            while (true)
            {
                yield return c;

                c = a + b;
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