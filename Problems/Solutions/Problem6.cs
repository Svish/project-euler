using System;
using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first 
    /// ten natural numbers and the square of the sum is 3025 * 385 = 2640.
    /// 
    /// Find the difference between the sum of the squares of the first 
    /// one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Problem6 : ProblemBase
    {
        public Problem6()
            : base(25164150) { }


        protected override object GetAnswer()
        {
            const ulong n = 100;
            return (3 * n * n * n * n + 2 * n * n * n - 3 * n * n - 2 * n) / 12;

            return Numbers.SumExpansionK1(n)
                * Numbers.SumExpansionK1(n)
                - Numbers.SumExpansionK2(n);
        }

        public static ulong test()
        {
            const ulong n = 100;
            return (3*n*n*n*n + 2*n*n*n - 3*n*n - 2*n) / 12;
        }
    }
}