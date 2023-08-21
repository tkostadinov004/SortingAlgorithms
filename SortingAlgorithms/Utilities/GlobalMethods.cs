using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Utilities
{
    public static class GlobalMethods
    {
        public static void Swap(int[] items, int i, int j)
        {
            int swap = items[i];
            items[i] = items[j];
            items[j] = swap;
        }
    }
}
