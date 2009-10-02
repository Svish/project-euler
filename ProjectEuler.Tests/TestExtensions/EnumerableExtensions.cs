using System;
using System.Collections;


namespace ProjectEuler.Tests.TestExtensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable Take(this IEnumerable source, int count)
        {
            var e = source.GetEnumerator();
            while (count -- > 0 && e.MoveNext())
            {
                yield return e.Current;
            }
        }

        public static IEnumerable Select<TSource, TResult>(this IEnumerable source, Func<TSource, TResult> selector)
        {
            var e = source.GetEnumerator();
            while (e.MoveNext())
                yield return selector((TSource) e.Current);
        }
    }
}