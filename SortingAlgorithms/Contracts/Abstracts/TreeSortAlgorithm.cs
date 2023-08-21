using SortingAlgorithms.Contracts.Interfaces.Base;
using SortingAlgorithms.Utilities.TreeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Contracts.Abstracts
{
    public abstract class TreeSortAlgorithm : ISortingAlgorithm
    {
        public abstract IEnumerable<int> Sort(IEnumerable<int> items);
        protected abstract TreeNode Insert(TreeNode root, int item);
        protected abstract IEnumerable<int> InOrderTraversal(TreeNode root);
    }
}
