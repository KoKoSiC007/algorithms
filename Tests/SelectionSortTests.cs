using algorithms.SortingAlgorithms;
using NUnit.Framework;

namespace Tests
{
    public class SelectionSortTests: SortingAlgorithmsTests
    {
        [SetUp]
        public override void Configure()
        {
            _algorithm = new SelectionSort();
        }
    }
}