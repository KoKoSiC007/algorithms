using System;
using System.Threading.Tasks;
using algorithms.SortingAlgorithms;

namespace algorithms
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var size = 100_00;

            var selSort = new SelectionSort();
            var bubbleSort = new BubbleSort();
            var insertionSort = new InsertionSort();
            
            var tasks = new[]
            {
                Task.Run(() => selSort.Benchmark(size)),
                Task.Run(() => bubbleSort.Benchmark(size)),
                Task.Run(() => insertionSort.Benchmark(size))
            };

            Task.WaitAll(tasks);
        }
    }
}