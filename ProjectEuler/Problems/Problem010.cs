using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// 
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Problem010 : ProblemBase<ulong>
    {
        public Problem010()
            : base(142913828922)
        {
            AddSolution(GetAnswer, "Eratosthenes");
            AddSolution(GetAnswer2, "Atkin");
        }

        private static ulong GetAnswer2()
        {
            const ulong limit = 2000000;
            return new Atkin(limit)
                .TakeWhile(x => x < limit)
                .Aggregate((sum, x) => sum + x);
        }

        private static ulong GetAnswer()
        {
            const ulong limit = 2000000;
            return new Eratosthenes()
                .TakeWhile(x => x < limit)
                .Aggregate((sum, x) => sum + x);
        }
    }
}