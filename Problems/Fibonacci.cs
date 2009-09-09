using System.Collections;
using System.Collections.Generic;


namespace Problems
{
    public class Fibonacci : IFibonacciSequence
    {
        #region IFibonacciSequence Members
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