using SortingAlgorithms.Contracts.Abstracts;
using SortingAlgorithms.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class QuickSort : QuickSortAlgorithm
    {
        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            return this.SortRec(items.ToArray(), 0, items.Count() - 1);
        }
        protected override IEnumerable<int> SortRec(int[] items, int start, int end)
        {
            if (start < end)
            {
                int divisionIndex = this.Divide(items, start, end);

                SortRec(items, start, divisionIndex - 1);
                SortRec(items, divisionIndex + 1, end);
            }
            return items;
        }
        protected override int Divide(int[] items, int start, int end)
        {
            int pivotItem = items[end];

            int correctPivotPosition = start - 1;
            for (int i = start; i < end; i++)
            {
                if (items[i] < pivotItem)
                {
                    correctPivotPosition++;
                    GlobalMethods.Swap(items, correctPivotPosition, i);
                }
            }
            GlobalMethods.Swap(items, correctPivotPosition + 1, end);
            return correctPivotPosition + 1;
        }
    }
}
