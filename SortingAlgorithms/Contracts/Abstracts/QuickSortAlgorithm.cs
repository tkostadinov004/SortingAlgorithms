using SortingAlgorithms.Contracts.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Contracts.Abstracts
{
    public abstract class QuickSortAlgorithm : ISortingAlgorithm
    {
        public abstract IEnumerable<int> Sort(IEnumerable<int> items);
        protected abstract IEnumerable<int> SortRec(int[] items, int start, int end);
        protected abstract int Divide(int[] items, int start, int end);
    }
}
