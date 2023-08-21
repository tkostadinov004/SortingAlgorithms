using SortingAlgorithms.Contracts.Abstracts;
using SortingAlgorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class SelectionSort : SelectionSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            int[] arr = items.ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                GlobalMethods.Swap(arr, i, minIndex);
            }
            return arr;
        }
    }
}
