using System;
using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class SelectionSort: ISortingAlgorithm
    {
        public override string Description  => string.Empty;
        
        public override string Complexity => "O(n^2)";

        public override string Name => "SelectionSort";

        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            for (var i = 0; i <= array.Count - 1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < array.Count; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            return array;
        }
        
    }
}