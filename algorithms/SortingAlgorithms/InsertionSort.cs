using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class InsertionSort: SortingAlgorithm
    {
        public override string Description => string.Empty;
        public override string Complexity => "O(n^2)";
        public override string Name => "InsertionSort";
        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var key = array[i];
                var j = i;
                
                while (j > 0 && array[j - 1].CompareTo(key) < 0)
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