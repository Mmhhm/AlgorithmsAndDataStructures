using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class BinaryTree
    {
        private TreeNode root;
        public BinaryTree()
        {
            root = null;
        }

        // TODO Make sure the this method works.
        // TODO Implement Find, FindMin, FindMax.
        
        public  void Insert(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (root == null) { root = newNode; return; }
            
            InsertRec(root, newNode);
        }

        private void InsertRec(TreeNode currNode, TreeNode newNode)
        {
            if (currNode.Value >= newNode.Value)
            {
                if(currNode.Left == null) 
                {
                    currNode.Left = newNode; 
                    return; 
                }
                InsertRec(currNode.Left, newNode);
            }
            else if(currNode.Value < newNode.Value)
            {
                if (currNode.Right == null) 
                {
                    currNode.Right = newNode; 
                    return; 
                }
                InsertRec(currNode.Right, newNode);
            }
        }
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
