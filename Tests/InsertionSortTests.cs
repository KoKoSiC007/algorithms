using algorithms.SortingAlgorithms;
using NUnit.Framework;

namespace Tests
{
    public class InsertionSortTests: SortingAlgorithmsTests
    {
        [SetUp]
        public override void Configure()
        {
            _algorithm = new InsertionSort(); 
        }
    }
}