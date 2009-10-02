namespace ProjectEuler.Problems
{
    public interface ISolution
    {
        string Note { get; }
        object GetAnswer();
    }
}