namespace ProjectEuler.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Problem004 : ProblemBase<ulong>
    {
        public Problem004()
            : base(906609)
        {
            AddSolution(Solution);
        }


        private static ulong Solution()
        {
            return Numbers.FindLargestPalindromeMadeFromProductOf(3);
        }
    }
}