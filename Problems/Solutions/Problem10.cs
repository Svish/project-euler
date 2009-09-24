using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// 
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Problem10 : ProblemBase
    {
        public Problem10()
            : base(142913828922) {}


        protected override object GetAnswer()
        {
            const ulong limit = 2000000;
            return new Eratosthenes()
                .TakeWhile(x => x < limit)
                .Aggregate((sum, x) => sum + x);
        }
    }
}