﻿using System;
using System.Threading.Tasks;
using algorithms.SortingAlgorithms;

namespace algorithms
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var size = 50_000;

            var selSort = new SelectionSort();
            var bubbleSort = new BubbleSort();
            var insertionSort = new InsertionSort();
            var bubbleSortImpl = new BubbleSortImpl();
            var qsort = new QuickSort();
            
            var tasks = new[]
            {
                Task.Run(() => selSort.Benchmark(size)),
                Task.Run(() => bubbleSort.Benchmark(size)),
                Task.Run(() => insertionSort.Benchmark(size)),
                Task.Run(() => bubbleSortImpl.Benchmark(size)),
                Task.Run(() => qsort.Benchmark(size))
            };
            
            Task.WaitAll(tasks);
        }
    }
}