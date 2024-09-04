using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorts
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node(int d)
        {
            Value = d;
            Next = null;
        }
        public int GetValue()
        {
            return Value;
        }
        public void SetValue(int data)
        {
            this.Value = data;
        }
        public Node GetNext()
        {
            return Next;
        }
        public void SetNext(Node next)
        {
            this.Next = next;
        }
    }
    public class LinkedList
    {
        public Node Head;
        public LinkedList() { }
        public LinkedList(Node head)
        {
            Head = head;
        }


        // TODO the problem in Test 2, 3, 5, is that 'Display' in the test does not return the respected result. Check what is this 'Display' thing.
        // TODO test 12 has the same problem but a bit diffrent - check.
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null) { Head = newNode; }
            else
            {
                Node lastNode = Head;
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
        }


        public void RemoveIndex(int data)
        {
            if (Head == null) { return; }

            Node node = Head;
            Node prev = Head;
            int index = 0;

            while (node != null)
            {
                if (index == data)
                {
                    prev.Next = node.Next;
                    return;
                }

                prev = node;
                node = node.Next;
                index++;
            }
        }
        public int Length()
        {
            int counter = 0;
            Node node = Head;
            while (node != null)
            {
                counter++;
                node = node.Next;
            }
            return counter;
        }

        public void RemoveValue(int data)
        {
            if (Head == null) { return; }

            if (Head.Value == data)
            {
                Head = Head.Next;
            }

            Node node = Head;
            Node prev = Head;
            while (node != null)
            {
                if (node.Value == data)
                {
                    prev.Next = node.Next;
                    return;
                }
                prev = node;
                node = node.Next;
            }
        }



        public void RemoveAllValues(int data)
        {
            if (Head == null) { return; }

            while (Head != null && Head.Value == data)
            {
                Head = Head.Next;
            }

            if (Head == null) { return; }

            Node node = Head;
            Node prev = null;
            while (node.Next != null)
            {
                if (node.Value == data)
                {
                    if (prev != null)
                    {
                        prev.Next = node.Next;
                    }
                }
                else { prev = node; }
                node = node.Next;
            }
        }

        public int Find(int data)
        {
            int index = 0;
            Node node = Head;
            if (node == null) { return -1; }
            while (node != null)
            {
                if (node.Value == data)
                {
                    return index;
                }
                node = node.Next;
                index++;
            }
            return -1;
        }

        public int Get(int index)
        {
            int myIndex = 0;
            Node node = Head;
            while (node != null)
            {
                if (myIndex == index)
                {
                    return node.Value;
                }
                node = node.Next;
                myIndex++;
            }
            return -1;
        }

        public string Display()
        {
            if (Head == null) { return ""; }
            Node node = Head;
            string str = string.Empty;
            while (node != null)
            {
                if (node.Next == null)
                {
                    str += node.Value.ToString();
                    return str;
                }
                str += node.Value.ToString() + " -> ";
                node = node.Next;
            }
            return str;
            /*return "";*/
        }



    }
}
