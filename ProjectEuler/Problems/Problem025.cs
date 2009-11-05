using ProjectEuler.Sequences;


namespace ProjectEuler.Problems
{
    public class Problem025 : ProblemBase<int>
    {
        // http://en.wikipedia.org/wiki/Fibonacci_series
        // http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibFormula.html


        public Problem025()
            : base(4782)
        {
            AddSolution(BruteForce);
        }


        private static int BruteForce()
        {
            var sequence = new LargeFibonacciSequence().GetEnumerator();

            var n = 0;
            while (sequence.MoveNext() && sequence.Current.ToString().Length < 1000)
                n++;

            return n;
        }
    }
}
