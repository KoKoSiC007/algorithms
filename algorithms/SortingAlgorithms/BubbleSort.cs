using System;
using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class BubbleSort: SortingAlgorithm
    {
        public override string Description => string.Empty;
        public override string Complexity => "O(n^2)";
        public override string Name => "BubbleSort";

        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            for (var i = 0; i < array.Count - 2; i++)
            {
                for (var j = 0; j < array.Count - 2; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0) continue;
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }

            return array;
        }
    }
}