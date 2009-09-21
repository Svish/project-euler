using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem7 : ProblemBase
    {
        public Problem7()
            : base(104743) {}


        protected override object GetAnswer()
        {
            return new Eratosthenes().Take(10001).Last();
        }
    }
}