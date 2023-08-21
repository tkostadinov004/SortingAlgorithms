using SortingAlgorithms.Contracts.Abstracts;
using SortingAlgorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSort : BubbleSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            int[] arr = items.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        GlobalMethods.Swap(arr, i, j);
                    }
                }
            }
            return arr;
        }
    }
}
