using System;
using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class InsertionSort: ISortingAlgorithm
    {
        public override string Description => String.Empty;
        public override string Complexity => "O(n^2)";
        public override string Name => "InsertionSort";
        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            for (var i = 2; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                
                while (j > 0 && array[j].CompareTo(key) > 0)
                {
                    array[j] = array[j - 1];
                    --j;
                }

                array[j] = key;
            }

            return array;
        }
    }
}