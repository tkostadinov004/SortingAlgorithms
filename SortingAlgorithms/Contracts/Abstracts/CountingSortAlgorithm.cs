using SortingAlgorithms.Contracts.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Contracts.Abstracts
{
    public abstract class CountingSortAlgorithm : ISortingAlgorithm
    {
        public abstract IEnumerable<int> Sort(IEnumerable<int> items);
        protected abstract int[] CountingSortAlgo(int[] items);
    }
}
