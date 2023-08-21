using SortingAlgorithms.Contracts.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class InsertionSort : InsertionSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            int[] arr = items.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            return arr;
        }
    }
}
