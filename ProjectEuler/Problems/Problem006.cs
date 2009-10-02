namespace ProjectEuler.Problems
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
    public class Problem006 : ProblemBase<ulong>
    {
        public Problem006()
            : base(25164150)
        {
            AddSolution(First);
            AddSolution(Second, "Optimized version");
        }

        const ulong N = 100;

        private static ulong First()
        {
            return Numbers.SumExpansionK1(N) * Numbers.SumExpansionK1(N) - Numbers.SumExpansionK2(N);
        }

        private static ulong Second()
        {
            return (3 * N * N * N * N + 2 * N * N * N - 3 * N * N - 2 * N) / 12;
        }
    }
}