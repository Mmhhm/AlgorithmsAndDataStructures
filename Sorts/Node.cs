using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorts
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
        public Node GetValue()
        {
            return data;
        }
        public void SetValue(int data)
        {
            this.data = data;
        }
        public Node GetValue()
        {
            return next;
        }
        public void SetValue(Node next)
        {
            this.next = next;
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
                while(lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = newNode;
        }

        public string Display()
        {
            string str = "";
            Node node = Head;
            while (node.next != null)
            {
                str += node.data.ToString();
                node = node.next;
            }
            str += node.data.ToString();
            return str;
        }

        public int Length()
        {
            int counter = 0;
            Node node = Head;
            while (node.next != null)
            {
                counter++;
                node = node.next;
            }
            counter++;
            return counter;
        }

        public void RemoveValue(int data)
        {
            Node node = Head;
            Node prev = Head;
            while (node.next != null)
            {
                if(node.data == data)
                {
                    prev.next = node;
                    break;
                }
                node = node.next;
                prev = node;
            }
        }

        public void RemoveAllValues(int data)
        {
            Node node = Head;
            Node prev = Head;
            while (node.next != null)
            {
                if (node.data == data)
                {
                    prev.next = node;
                }
                node = node.next;
                prev = node;
            }
        }

        public void RemoveIndex(int data)
        {

        }
    }
}
