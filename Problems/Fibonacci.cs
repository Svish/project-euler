using System.Collections;
using System.Collections.Generic;


namespace Problems
{
    public class Fibonacci : IFibonacciSequence
    {
        #region IFibonacciSequence Members
        public IEnumerator<long> GetEnumerator()
        {
            long a = 0;
            long b = 1;
            long c = a + b;

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