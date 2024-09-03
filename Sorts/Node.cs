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

        public void Add(int data)
        {
            Node newNode = new Node(data);
                Node lastNode = Head;
                while(lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
        }

        public string Display()
        {
            string str = "";
            Node node = Head;
            while (node.Next != null)
            {
                str += node.Value.ToString();
                node = node.Next;
            }
            str += node.Value.ToString();
            return str;
        }

        public int Length()
        {
            int counter = 0;
            Node node = Head;
            while (node.Next != null)
            {
                counter++;
                node = node.Next;
            }
            counter++;
            return counter;
        }

        public void RemoveValue(int data)
        {
            Node node = Head;
            Node prev = Head;
            while (node.Next != null)
            {
                if(node.Value == data)
                {
                    prev.Next = node;
                    break;
                }
                node = node.Next;
                prev = node;
            }
        }

        public void RemoveAllValues(int data)
        {
            Node node = Head;
            Node prev = Head;
            while (node.Next != null)
            {
                if (node.Value == data)
                {
                    prev.Next = node;
                }
                node = node.Next;
                prev = node;
            }
        }

        public int Find(int data)
        {
            int index = 0;
            Node node = Head;
            while (node.Next != null)
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
            while (node.Next != null)
            {
                if (myIndex == index)
                {
                    return node.Value;
                }
                node = node.Next;
                index++;
            }
            return -1;
        }
    }
}
