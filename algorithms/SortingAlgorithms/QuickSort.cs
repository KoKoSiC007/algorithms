using System;
using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class QuickSort: SortingAlgorithm
    {
        public override string Description => string.Empty;
        public override string Complexity => "n*log n";
        public override string Name => "QuickSort";
        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            _Sort(array, 0, array.Count);
            return array;
        }

        private void _Sort<Type>(IList<Type> array, int low, int high) where Type : IComparable<Type>
        {
            if (low < high)
            {
                var p = Partition<Type>(array, low, high);
                _Sort<Type>(array, low, p);
                _Sort<Type>(array, p + 1, high);
            }
        }
        
        private int Partition<T>(IList<T> array, int low, int high) where T: IComparable<T>
        {
            var pivot = array[(low + high) / 2];

            var i = low;
            var j = high - 1;
            while (true)
            {
                while (array[i].CompareTo(pivot) < 0) ++i;
                while (array[j].CompareTo(pivot) > 0) --j;
                if (i >= j) return j;

                var temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                ++i;
                --j;
            }
        }
    }
}