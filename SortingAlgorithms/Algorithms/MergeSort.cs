using SortingAlgorithms.Contracts.Abstracts;

namespace SortingAlgorithms.Algorithms
{
    public class MergeSort : MergeSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            return this.SortRec(items.ToArray());
        }

        protected override int[] SortRec(int[] items)
        {
            if (items.Length == 1)
            {
                return items;
            }

            var left = items[..(items.Length / 2)];
            var right = items[(items.Length / 2)..];

            left = SortRec(left);
            right = SortRec(right);

            return Merge(left, right);
        }
        protected override int[] Merge(int[] left, int[] right)
        {
            int[] arr = new int[left.Length + right.Length];

            int leftIndex = 0;
            int rightIndex = 0;

            int i = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] > right[rightIndex])
                {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
                else
                {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                }
                i++;
            }

            while (leftIndex < left.Length)
            {
                arr[i] = left[leftIndex];
                leftIndex++;
                i++;
            }
            while (rightIndex < right.Length)
            {
                arr[i] = right[rightIndex];
                rightIndex++;
                i++;
            }
            return arr;
        }
    }
}
