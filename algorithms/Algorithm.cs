namespace algorithms
{
    public interface IAlgorithm
    {
        static string Name
        {
            get;
        }
        string Description
        {
            get;
        }

        string Complexity
        {
            get;
        }
    }
}