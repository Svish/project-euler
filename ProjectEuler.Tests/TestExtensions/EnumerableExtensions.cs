using System;
using System.Collections;


namespace ProjectEuler.Tests.TestExtensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Take implementation for non-generic IEnumerable.
        /// </summary>
        public static IEnumerable Take(this IEnumerable source, int count)
        {
            var e = source.GetEnumerator();
            while (count -- > 0 && e.MoveNext())
            {
                yield return e.Current;
            }
        }

        /// <summary>
        /// Select implementation for non-generic IEnumerable.
        /// </summary>
        public static IEnumerable Select<TSource, TResult>(this IEnumerable source, Func<TSource, TResult> selector)
        {
            var e = source.GetEnumerator();
            while (e.MoveNext())
                yield return selector((TSource) e.Current);
        }

        /// <summary>
        /// ToArray implementation for non-generic IEnumerable.
        /// </summary>
        public static object[] ToArray(this IEnumerable source)
        {
            var list = new ArrayList();

            var enumerator = source.GetEnumerator();
            while(enumerator.MoveNext())
                list.Add(enumerator.Current);

            return list.ToArray();
        }
    }
}