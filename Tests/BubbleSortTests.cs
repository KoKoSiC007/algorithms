using algorithms.SortingAlgorithms;
using NUnit.Framework;

namespace Tests
{
    public class BubbleSortTests: SortingAlgorithmsTests
    {
        [SetUp]
        public override void Configure()
        {
            _algorithm = new BubbleSort();
        }
    }
}