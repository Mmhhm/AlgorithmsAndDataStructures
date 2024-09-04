using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sorts
{
    public class BinaryTree
    {
        private TreeNode root;
        public BinaryTree()
        {
            root = null;
        }

        // Insert new value
        public void Insert(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (root == null) { root = newNode; return; }

            InsRecursion(root, newNode);
        }

        private void InsRecursion(TreeNode currNode, TreeNode newNode)
        {
            if (currNode.Value >= newNode.Value)
            {
                if (currNode.Left == null)
                {
                    currNode.Left = newNode;
                    return;
                }
                InsRecursion(currNode.Left, newNode);
            }
            else if (currNode.Value < newNode.Value)
            {
                if (currNode.Right == null)
                {
                    currNode.Right = newNode;
                    return;
                }
                InsRecursion(currNode.Right, newNode);
            }
        }

        // Search value
        public bool Find(int value)
        {
            return RecFind(root, value);
        }

        public bool RecFind(TreeNode node, int value)
        {
            if (node == null) { return false; }

            if (node.Value > value)
            {
                return RecFind(node.Left, value);
            }
            else if (node.Value < value)
            {
                return RecFind(node.Right, value);
            }
            else
            {
                return true;
            }
        }

        // Find max value
        public int FindMax()
        {
            if (root == null) { return -1; }
            return RecFindMax(root);
        }

        private int RecFindMax(TreeNode node)
        {
            if (node.Right == null) { return node.Value; }
            return RecFindMax(node.Right);
        }

        // Find min value
        public int FindMin()
        {
            if (root == null) { return -1; }
            return FindMin(root);
        }

        private int FindMin(TreeNode node)
        {
            if (node.Left == null) { return node.Value; }
            return FindMin(node.Left);
        }
        

        // Prints the tree structure
        public void PrintTree()
        {
            PrintTreeRec(root, "", true);
        }

        private void PrintTreeRec(TreeNode node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|  ";
                }

                Console.WriteLine(node.Value);

                PrintTreeRec(node.Left, indent, false);
                PrintTreeRec(node.Right, indent, true);
            }
        }
    }
}
