using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sorts.DoubleNode;

namespace Sorts
{
    public class Stack
    {
        public Node Head {  get; set; }
        public int Counter;
        public Stack() { this.Head = null; }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = Head;
            Head = newNode;
            Counter++;
        }

        public int Pop()
        {
            if (this.IsEmpty()) { return -1;  }
            else
            {
                int value = Head.Value;
                Head = Head.Next;
                Counter--;
                return value;
            }
        }

        public int Peek()
        {
            if (this.IsEmpty()) { return -1; }
            
            return Head.Value;
        }

        public int Count()
        {
            return Counter;
        }
    }
}
