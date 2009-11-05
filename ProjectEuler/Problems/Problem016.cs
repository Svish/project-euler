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
    public class Problem016 : ProblemBase<int>
    {
        public Problem016()
            : base(1366)
        {
            AddSolution(Solution);
        }


        private static int Solution()
        {
            return IntX
                .Pow(2, 1000)
                .ToString()
                .Select(x => x - '0')
                .Sum();
        }

        private static object T()
        {
            return decimal.MaxValue + Environment.NewLine + ulong.MaxValue;
        }
    }
}