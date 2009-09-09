namespace Problems.Solutions
{
    public interface ISolution
    {
        int ProblemId { get; }
        long ExpectedAnswer { get; }
        long GetAnswer();
    }
}