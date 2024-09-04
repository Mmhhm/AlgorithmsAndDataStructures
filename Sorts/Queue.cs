using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Queue
    {
        Node Front;
        Node Rear;
        int Count;
        
        public Queue()  // Constructor 
        {
            Front = null;
            Rear = null;
        }

        public bool IsEmpty()
        {
            return Front == null && Rear == null;
        }

        public void Enqueue(int newData)
        {
            Node newNode = new Node(newData);

            if(Rear ==  null)
            {
                Front = newNode;  // If the queue is empty, the new node is both the front and rear
                Rear = newNode;
                return;
            }
            
            Rear.Next = newNode;
            Rear = newNode;
            Count++;
        }

        public int Dequeue()
        {
            if (IsEmpty()) { return -1; }

            int value = Front.Value;
            Front = Front.Next;
            Count--;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty()) { return -1; };
            return Front.Value;
        }
    }
}
