using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }

        public DoubleNode(int data) 
        {
            Value = data;
            Next = this;
            Prev = this;
        }
        public class CircularDoubleLinkedList
        {
            public DoubleNode Head { get; set; }
            public int Count { get; set; }
            public CircularDoubleLinkedList()
            {
                Head = null;
                Count = 0;
            }

            public void AddLast(DoubleNode newNode)
            {
                if(Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    DoubleNode tail = Head.Prev;
                    newNode.Prev = tail;
                    newNode.Next = Head;
                    Head.Prev = newNode;
                    tail.Next = newNode;

                }
            }

            
        }
        
    }
}
