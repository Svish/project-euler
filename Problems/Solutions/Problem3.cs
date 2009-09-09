using System.Linq;


namespace Problems.Solutions
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Problem3 : ProblemBase
    {
        public Problem3()
            : base(3, 6857) {}


        public override long GetAnswer()
        {
            return (long) Eratosthenes.GetPrimeFactors(600851475143).Max();
        }
    }
}