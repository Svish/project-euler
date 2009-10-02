namespace ProjectEuler.Problems
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem005 : ProblemBase<ulong>
    {
        public Problem005()
            : base(232792560)
        {
            AddSolution(GetAnswer);
        }


        private static ulong GetAnswer()
        {
            // Skips 1 to 10, since they are "covered" in the others
            return Numbers.GetLowestCommonMultiple(new ulong[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20});
        }
    }
}