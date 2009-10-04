using System.Linq;
using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, 
    /// a &lt; b &lt; c, for which, a^2 + b^2 = c^2
    /// 
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.
    /// 
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Problem009 : ProblemBase<ulong>
    {
        public Problem009()
            : base(31875000)
        {
            AddSolution(GetAnswer);
        }


        private static ulong GetAnswer()
        {
            var t = new PythagoreanTriples()
                .First(x => x.Item1 + x.Item2 + x.Item3 == 1000);
            return t.Item1 * t.Item2 * t.Item3;
        }
    }
}