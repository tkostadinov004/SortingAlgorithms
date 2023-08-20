using SortingAlgorithms.Contracts.Abstracts;

namespace SortingAlgorithms.Algorithms
{
    public class CountingSort : CountingSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            int[] arr = items.ToArray();

            int[] negative = arr.Where(i => i < 0).ToArray();
            int[] nonNegative = arr.Where(i => i >= 0).ToArray();

            negative = this.CountingSortAlgo(negative);
            nonNegative = this.CountingSortAlgo(nonNegative);
            
            for (int i = 0; i < negative.Length; i++)
            {
                arr[i] = negative[i];
            }
            for (int i = 0; i < nonNegative.Length; i++)
            {
                arr[i + negative.Length] = nonNegative[i];
            }
            return arr;
        }
        protected override int[] CountingSortAlgo(int[] items)
        {
            int min = items.Min();
            int max = items.Max();
            int[] occurrences = new int[max - min + 1];

            int[] sorted = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                occurrences[items[i] - min]++;
            }

            for (int i = 1; i < occurrences.Length; i++)
            {
                occurrences[i] += occurrences[i - 1];
            }

            for (int i = occurrences.Length - 2; i >= 0; i--)
            {
                occurrences[i + 1] = occurrences[i];
            }
            occurrences[0] = 0;

            for (int i = 0; i < items.Length; i++)
            {
                sorted[occurrences[items[i] - min]] = items[i];
                occurrences[items[i] - min]++;
            }
            return sorted;
        }
    }
}
