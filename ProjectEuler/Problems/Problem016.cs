using System;
using System.Linq;
using Oyster.Math;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    /// 
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    public class Problem016 : ProblemBase<uint>
    {
        public Problem016()
            : base(1366)
        {
            AddSolution(Solution);
        }


        private static uint Solution()
        {
            var number = IntX.Pow(2, 1000);

            return number
                .ToString()
                .Select(x => Convert.ToUInt32(x - '0'))
                .Aggregate(0U, (sum, x) => sum + x);
        }
    }
}