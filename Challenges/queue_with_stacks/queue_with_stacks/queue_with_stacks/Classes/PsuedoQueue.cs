using StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace queue_with_stacks.Classes
{
    public class PsuedoQueue : Stack
    {
        Node Front {get; set;}
        Node Rear { get; set; }

        public PsuedoQueue()
        {
            Front = null;
            Rear = null;
            Top = null;
        }

        public PsuedoQueue(int value)
        {
            Node node = new Node(value);
            Front = node;
            Rear = node;
            Top = node;
            
        }



        public void Enqueue(int value)
        {
            Stack HolderStack = new Stack();
            while (Top != null)
            {
                HolderStack.Push(Pop());
            }
            Push(value);
            while (HolderStack.Top != null)
            {
                Push(HolderStack.Pop());
            }
        }

        public Node Dequeue()
        {
            return Pop();
        }

    }
}
