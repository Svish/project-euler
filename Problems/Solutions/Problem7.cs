using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
    /// we can see that the 6th prime is 13.
    /// 
    /// What is the 10001st prime number?
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