using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// 
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem001 : ProblemBase
    {
        public Problem001()
            : base(233168) {}


        protected override object GetAnswer()
        {
            var multiples = new long[] {3, 5};
            return Enumerable
                .Range(0, 1000)
                .Where(x => multiples.Any(y => x % y == 0))
                .Sum();
        }
    }
}