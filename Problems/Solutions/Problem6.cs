using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Problem6 : ProblemBase
    {
        public Problem6()
            : base(6, 25164150) {}


        public override long GetAnswer()
        {
            var numbers = Enumerable.Range(1, 100);

            int a = numbers.Aggregate(0, (sum, x) => sum + x*x);
            int b = numbers.Sum()*numbers.Sum();
            return b - a;
        }
    }
}