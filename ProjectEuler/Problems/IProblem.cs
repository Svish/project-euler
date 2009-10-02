using System.Collections.Generic;


namespace ProjectEuler.Problems
{
    public interface IProblem
    {
        object ExpectedAnswer { get; }
        IEnumerable<ISolution> GetSolutions();
    }
}