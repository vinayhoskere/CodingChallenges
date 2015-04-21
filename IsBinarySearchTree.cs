using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    /// <summary>
    /// Is the given binary tree a Binary Search Tree
    /// </summary>
    class IsBinarySearchTree
    {
        public bool IsBST(BinarySearchTree.Node node)
        {
            return IsBSTUtil(node, Int32.MinValue, Int32.MaxValue);
        }

        public bool IsBSTUtil(BinarySearchTree.Node node, int minValue, int maxValue)
        {
            if (node == null)
                return true;

            if (node.key > minValue && node.key < maxValue && IsBSTUtil(node.Left, minValue, node.key) &&
                IsBSTUtil(node.Right, node.key, maxValue))
                return true;

            return false;
        }

        
    }
}
