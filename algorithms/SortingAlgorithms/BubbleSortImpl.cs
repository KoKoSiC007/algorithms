using System.Collections.Generic;

namespace algorithms.SortingAlgorithms
{
    public class BubbleSortImpl: SortingAlgorithm
    {
        public override string Description => string.Empty;
        public override string Complexity => "O(n^2)";
        public override string Name => "BubbleSortImpl";
        public override IEnumerable<U> Sort<U>(IList<U> array)
        {
            var length = array.Count;
            do
            {
                var sw = 0;
                
                for (var i = 0; i < length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) <= 0) continue;
                    var temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    sw = i + 1;
                }

                length = sw;
            } while (length > 1);

            return array;
        }
    }
}