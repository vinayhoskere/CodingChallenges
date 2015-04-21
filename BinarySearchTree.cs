using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    /// <summary>
    /// Also has Depth first search (PreOrder, InOrder, PostOrder) and Breadth first search(Level Order) 
    /// Time Complexity for all of them is O(n)
    /// Space Completxity for DFS   O(n) - Worst
    ///                             O(log n) - Avg
    /// 
    /// Space Complexity for BFS    O(n)
    /// </summary>
    internal class BinarySearchTree
    {
        public interface IBST
        {
            void AddLeaf(int key);
            void PrintInOrder();
            Node ReturnNode(int key);
            int ReturnRootKey();
            void PrintChildren(int key);
            void RemoveNode(int key);
        }

        public class Node
        {
            public int key;
            public Node Left;
            public Node Right;

            public Node(int data)
            {
                key = data;
                Left = null;
                Right = null;
            }

            public void Dispose()
            {

            }
        }

        public class BST : IBST
        {
            private Node root;

            public BST()
            {
                root = null;
            }

            private Node CreateLeaf(int key)
            {
                Node n = new Node(key);
                return n;
            }

            public void AddLeaf(int key)
            {
                AddLeaf(key, root);
            }

            private void AddLeaf(int key, Node node)
            {
                //If there are no elements, then this will be root
                if (root == null)
                {
                    root = CreateLeaf(key);
                }
                    //If root is present, the check whether to go left or right
                else if (key < node.key)
                {
                    //If there is still an left node, then recurse
                    if (node.Left != null)
                    {
                        AddLeaf(key, node.Left);
                    }
                    else
                    {
                        node.Left = CreateLeaf(key);
                    }
                }
                else if (key > node.key)
                {
                    //If there is still an right node, then recurse
                    if (node.Right != null)
                    {
                        AddLeaf(key, node.Right);
                    }
                    else
                    {
                        node.Right = CreateLeaf(key);
                    }
                }
                else
                {
                    Console.WriteLine("the key " + key + "has already been added to the tree");
                }
            }

            /// <summary>
            /// InOrder traversal
            /// </summary>
            public void PrintInOrder()
            {
                Console.WriteLine("InOrder Traversal");
                PrintInOrder(root);

                Console.WriteLine("PreOrder Traversal");
                PrintPreOrder(root);

                Console.WriteLine("PostOrder Traversal");
                PrintPostOrder(root);

                Console.WriteLine("Level Order Traversal");
                PrintLevelOrder(root);
            }

            private void PrintInOrder(Node node)
            {
                if (root != null)
                {
                    //For InOrder traversal, we always go left first
                    if (node.Left != null)
                    {
                        PrintInOrder(node.Left);
                    }
                    //Once end of left print the key
                    Console.WriteLine(node.key + " ");
                    //Now go through right node
                    if (node.Right != null)
                    {
                        PrintInOrder(node.Right);
                    }
                }
                else
                {
                    Console.WriteLine("Tree is empty");
                }
            }

            /// <summary>
            /// Pre Order
            /// </summary>
            /// <param name="node"></param>
            private void PrintPreOrder(Node node)
            {
                if (root != null)
                {
                    Console.WriteLine(node.key + " ");
                    if (node.Left != null)
                    {
                        PrintPreOrder(node.Left);
                    }
                    if (node.Right != null)
                    {
                        PrintPreOrder(node.Right);
                    }
                }
                else
                {
                    Console.WriteLine("Tree empty");
                }
            }

            /// <summary>
            /// Post Order
            /// </summary>
            /// <param name="node"></param>
            private void PrintPostOrder(Node node)
            {
                if (root != null)
                {
                    if (node.Left != null)
                        PrintPostOrder(node.Left);
                    if (node.Right != null)
                        PrintPostOrder(node.Right);
                    Console.WriteLine(node.key + " ");
                }
                else
                {
                    Console.WriteLine("Tree is empty");
                }
            }

            /// <summary>
            /// Level Order
            /// </summary>
            /// <param name="node"></param>
            private void PrintLevelOrder(Node node)
            {
                if (root != null)
                {
                    Queue<Node> queue = null;
                    if (node != null)
                        queue.Enqueue(node);

                    while (queue.Any())
                    {
                        Node currentNode = queue.Dequeue();
                        Console.WriteLine(currentNode.key + " ");
                        if (node.Left != null)
                            queue.Enqueue(node.Left);
                        if (node.Right != null)
                            queue.Enqueue(node.Right);
                    }
                }
                else
                {
                    Console.WriteLine("Tree is empty");
                }
            }

            public Node ReturnNode(int key)
            {
                return ReturnNode(key, root);
            }

            private Node ReturnNode(int key, Node node)
            {
                if (node != null)
                {
                    if (node.key == key)
                    {
                        return node;
                    }
                    else
                    {
                        if (key < node.key)
                        {
                            return ReturnNode(key, node.Left);
                        }
                        else
                        {
                            return ReturnNode(key, node.Right);
                        }
                    }
                }
                else
                {
                    return null;
                }
            }

            public int ReturnRootKey()
            {
                if (root != null)
                {
                    return root.key;
                }
                return -1;
            }

            public void PrintChildren(int key)
            {
                Node node = ReturnNode(key);

                if (node != null)
                {
                    Console.WriteLine("Parent Node: " + node.key);
                    if (node.Left == null)
                    {
                        Console.WriteLine("Left child is null");
                    }
                    else
                    {
                        Console.WriteLine("Left child " + node.Left.key);
                    }
                    if (node.Right == null)
                    {
                        Console.WriteLine("Right child is null");
                    }
                    else
                    {
                        Console.WriteLine("Right child " + node.Right.key);
                    }
                }
                else
                {
                    Console.WriteLine("key " + key + "is not in the tree");
                }
            }

            public int FindSmallest()
            {
                return FindSmallest(root);
            }

            private int FindSmallest(Node node)
            {
                if (root == null)
                {
                    Console.WriteLine("Tree is empty");
                    return -1;
                }
                else
                {
                    if (node.Left != null)
                    {
                        return FindSmallest(node.Left);
                    }
                    else
                    {
                        return node.key;
                    }
                }
            }

            public void RemoveNode(int key)
            {
                RemoveNode(key, root);
            }

            private void RemoveNode(int key, Node node)
            {
                if (node != null)
                {
                    if (node.key == key)
                    {
                        RemoveRootMatch();
                    }
                    else
                    {
                        //if the key is less than node key, then move left
                        if (key < node.key && node.Left != null)
                        {
                            //Check if the child key matches. This is done to make sure we can easily change the pointer. 
                            if (node.Left.key == key)
                                //true if it is the left child match
                                RemoveMatch(node, node.Left, true);
                            else
                                RemoveNode(key, node.Left);
                        }
                            //if the key is greater than node key, then move right
                        else if (key > node.key && node.Right != null)
                        {
                            //Check if the child key matches. This is done to make sure we can easily change the pointer. 
                            if (node.Right.key == key)
                                //false if it is the left child match
                                RemoveMatch(node, node.Right, false);
                            else
                                RemoveNode(key, node.Right);
                        }
                        else
                        {
                            Console.WriteLine("key not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tree is empty");
                }
            }

            private void RemoveRootMatch()
            {
                if (root != null)
                {
                    Node delNode = root;
                    int rootKey = root.key;
                    int smallestInRightSubTree;

                    //Case 0 - 0 children
                    if (root.Left == null && root.Right == null)
                    {
                        root = null;
                        delNode.Dispose();
                    }

                        //Case 1 : 1 child
                    else if (root.Left == null && root.Right != null)
                    {
                        root = root.Right;
                        delNode.Right = null;
                        delNode.Dispose();
                        Console.WriteLine("The root node with key " + rootKey + "was deleted");
                        Console.WriteLine("The new root node is key " + root.key);
                    }
                    else if (root.Left != null && root.Right == null)
                    {
                        root = root.Left;
                        delNode.Left = null;
                        delNode.Dispose();
                        Console.WriteLine("The root node with key " + rootKey + "was deleted");
                        Console.WriteLine("The new root node is key " + root.key);
                    }
                        //Case 2: 2 children
                    else
                    {
                        //get the smallest key from the right sub tree first 
                        smallestInRightSubTree = FindSmallest(root.Right);
                        RemoveNode(smallestInRightSubTree, root);
                        root.key = smallestInRightSubTree;
                        Console.WriteLine("Root key containing key" + rootKey + "was overwritten with key " + root.key);
                    }
                }
                else
                {
                    Console.WriteLine("Tree empty");
                }
            }

            private void RemoveMatch(Node parent, Node match, bool left)
            {
                if (root != null)
                {
                    Node delNode;
                    int matchKey = match.key;
                    int smallestInRightSubTree;

                    //Case 0: 0 Children
                    if (match.Left == null && match.Right == null)
                    {
                        delNode = match;
                        //Check if left or right child is the match
                        if (left == true)
                            parent.Left = null;
                        else
                            parent.Right = null;
                        delNode.Dispose();
                    }
                        //Case 1: 1 child (right child)
                    else if (match.Left == null && match.Right != null)
                    {
                        if (left)
                        {
                            parent.Left = match.Right;
                        }
                        else
                            parent.Right = match.Right;

                        match.Right = null;
                        delNode = match;
                        delNode.Dispose();
                    }
                        //left child
                    else if (match.Left != null && match.Right == null)
                    {
                        if (left)
                        {
                            parent.Left = match.Left;
                        }
                        else
                            parent.Right = match.Left;

                        match.Left = null;
                        delNode = match;
                        delNode.Dispose();
                    }
                        //Case 2 - 2 children
                    else
                    {
                        smallestInRightSubTree = FindSmallest(match.Right);
                        RemoveNode(smallestInRightSubTree, match);
                        match.key = smallestInRightSubTree;
                    }
                }
                else
                {
                    Console.WriteLine("Cannot remove match");
                }
            }

            /// <summary>
            /// TIME COMPLEXITY O(n)
            /// </summary>
            /// <param name="node"></param>
            /// <returns></returns>
            private int FindHeight(Node node)
            {
                //Height of leaf node is always 0, so we need to return -1 if it is a leaf node. 
                if (node == null)
                {
                    return -1;
                }

                //First find height of the left child
                int leftHeigh = FindHeight(node.Left);

                //Find height of right child
                int rightHeigh = FindHeight(node.Right);

                //Max of left and right + 1 (include root)
                return (leftHeigh > rightHeigh ? leftHeigh : rightHeigh) + 1;
            }
        }

        //private static void Main(String[] args)
        //{
        //    int[] keys = {50, 76, 21, 4, 32, 64, 15, 52, 14, 100, 83, 2, 3, 70, 87, 80};
        //    BST mytree = new BST();
        //    int input = 0;
        //    Console.WriteLine("Before Adding number");
        //    mytree.PrintInOrder();

        //    for (int i = 0; i < keys.Length; i++)
        //    {
        //        mytree.AddLeaf(keys[i]);
        //    }

        //    Console.WriteLine("After Adding number");
        //    mytree.PrintInOrder();

        //    mytree.PrintChildren(mytree.ReturnRootKey());

        //    mytree.RemoveNode(4);
        //    mytree.PrintInOrder();

        //    Console.ReadKey();
        //}
    }
}
