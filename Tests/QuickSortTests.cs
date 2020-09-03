using algorithms.SortingAlgorithms;
using NUnit.Framework;

namespace Tests
{
    public class QuickSortTests: SortingAlgorithmsTests
    {
        [SetUp]
        public override void Configure()
        {
            _algorithm = new QuickSort();
        }
    }
}