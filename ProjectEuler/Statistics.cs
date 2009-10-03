using System.Collections.Generic;
using System.Linq;


namespace ProjectEuler
{
    public static class Statistics
    {
        public static decimal Median(this IEnumerable<long> subjects)
        {
            var sortedList = subjects.ToList();
            sortedList.Sort();

            var itemIndex = sortedList.Count / 2;

            if (itemIndex == 0)
                return 0;

            if (sortedList.Count() % 2 == 0)
                return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / 2M;

            return sortedList[itemIndex];
        }

        public static decimal Variance(this IEnumerable<long> subjects, bool entirePopulation)
        {
            if (!subjects.Any())
                return 0;

            var n = 0UL;
            var mean = 0M;
            var m2 = 0M;

            foreach(var x in subjects)
            {
                n += 1;
                var delta = x - mean;
                mean += delta / n;
                m2 += delta * (x - mean);
            }

            return entirePopulation ? m2 / n : m2 / (n - 1);
        }
    }
}