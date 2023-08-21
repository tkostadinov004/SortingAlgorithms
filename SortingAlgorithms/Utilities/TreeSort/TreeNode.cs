using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Utilities.TreeSort
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
        }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }
    }
}
