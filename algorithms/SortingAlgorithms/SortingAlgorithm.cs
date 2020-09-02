using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithms.SortingAlgorithms
{
    public class SortingAlgorithm: IAlgorithm
    {
        
        private static readonly Random R = new Random();
        public virtual string Description
        {
            get;
        }

        public virtual string Complexity
        {
            get;
        }

        public virtual string Name
        {
            get;
        }

        public virtual IEnumerable<U> Sort<U>(IList<U> array) where U : IComparable<U>
        {
            throw new NotImplementedException();
        }

        public async Task Benchmark(int arraySize)
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            
            var array = GetRandomArray(arraySize);

            stopwatch.Start();
            Sort(array);
            stopwatch.Stop();
            
            Console.WriteLine($"{Name} | {stopwatch.Elapsed} | {arraySize}");
        }
        
        private static int[] GetRandomArray(int size)
        {
            int[] array = new int[size];
            
            for(var i = 0; i < size; i++)
            {
                array[i] = R.Next(0, size);
            }

            return array;
        }
    }
}