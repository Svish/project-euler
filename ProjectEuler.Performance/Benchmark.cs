using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace ProjectEuler.Performance
{
    public sealed class Benchmark : IEnumerable<TimeSpan>
    {
        private readonly Action subject;
        private readonly TimeSpan timeout;

        private Benchmark(Action subject, TimeSpan timeout)
        {
            this.subject = subject;
            this.timeout = timeout;
        }


        #region IEnumerable<TimeSpan> Members
        public IEnumerator<TimeSpan> GetEnumerator()
        {
            subject();                      // warm up
            GC.Collect();                   // compact Heap
            GC.WaitForPendingFinalizers();  // and wait for the finalizer que to empty

            var watch = new Stopwatch();
            var time = TimeSpan.FromTicks(0);

            while (time < timeout)
            {
                watch.Reset();
                watch.Start();
                subject();
                watch.Stop();
                time += watch.Elapsed;
                yield return watch.Elapsed;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion


        public static Benchmark This(Action subject, TimeSpan timeout)
        {
            return new Benchmark(subject, timeout);
        }
    }
}