using algorithms.SortingAlgorithms;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public abstract class SortingAlgorithmsTests
    {
        protected SortingAlgorithm _algorithm;
        
        [SetUp]
        public abstract void Configure();

        [Test]
        public void SortingIsRightTest()
        {
            var array = new[]{1, 3, 2, 4, 6, 5, 10, 0};

            var sortedArray = new[] {0, 1, 2, 3, 4, 5, 6, 10};

            array = (int[])_algorithm.Sort(array);

            var equal = !array.Where((t, i) => t != sortedArray[i]).Any();

            Assert.IsTrue(equal, "Оба массива должны быть отсортированы!");
        }

        [Test]
        public void OneElementedArraysAreEqual()
        {
            var array = new[] {1};

            var sortedArray = new[] {1};

            array = (int[]) _algorithm.Sort(array);
            
            Assert.AreEqual(sortedArray, array, "Массивы из одного элемента должны быть равны!");
        }

        [Test]
        public void EmptyArraysAreEqual()
        {
            var array = new int[0];
            
            var sortedArray = new int[0];

            array = (int[]) _algorithm.Sort(array);

            Assert.AreEqual(array.Length, sortedArray.Length, "Оба массива должны быть пустыми");
        }
    }
}