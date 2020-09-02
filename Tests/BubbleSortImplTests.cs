using algorithms.SortingAlgorithms;
using NUnit.Framework;

namespace Tests
{
    public class BubbleSortImplTests: SortingAlgorithmsTests
    {
        [SetUp]
        public override void Configure()
        {
            _algorithm = new BubbleSortImpl();
        }
    }
}