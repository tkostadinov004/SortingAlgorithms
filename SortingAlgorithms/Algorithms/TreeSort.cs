using SortingAlgorithms.Contracts.Abstracts;
using SortingAlgorithms.Utilities.TreeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    public class TreeSort : TreeSortAlgorithm
    {
        private TreeNode? root;
        private int[] sortedData;
        private int count;

        public TreeSort()
        {
            root = null;
            sortedData = new int[] { };
        }

        public override IEnumerable<int> Sort(IEnumerable<int> items)
        {
            int[] arr = items.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                root = Insert(root, arr[i]);
            }
            return InOrderTraversal(root);
        }
        protected override TreeNode Insert(TreeNode root, int item)
        {
            if(root == null)
            {
                root = new TreeNode(item);
                return root;
            }

            if (item < root.Value)
            {
                root.Left = Insert(root.Left, item);
            }
            else if(item > root.Value)
            {
                root.Right = Insert(root.Right, item);
            }
            return root;
        }
        protected override IEnumerable<int> InOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                GrowResult();
                sortedData[count++] = root.Value;
                InOrderTraversal(root.Right);
            }
            return sortedData;
        }
        private void GrowResult()
        {
            int[] arr = new int[count + 1];
            for (int i = 0; i < sortedData.Length; i++)
            {
                arr[i] = sortedData[i];
            }
            sortedData = arr;
        }
    }
}
