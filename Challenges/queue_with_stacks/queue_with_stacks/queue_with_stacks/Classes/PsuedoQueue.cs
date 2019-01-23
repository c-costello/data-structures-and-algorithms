﻿using StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace queue_with_stacks.Classes
{
    public class PsuedoQueue : Stack
    {
        public Node Front {get; set;}
        public Node Rear { get; set; }

        public PsuedoQueue()
        {
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
            if (Top == null)
            {
                Push(value);
                Front = Top;
                Rear = Top;
            }
            else
            {
                Stack HolderStack = new Stack();
                while (Top != null)
                {
                    Console.WriteLine("Top" + Top.Value);
                    HolderStack.Push(Pop());
                }
                Node node = new Node(value);
                Push(value);
                Console.WriteLine("Test" + Top.Value);
                Console.WriteLine("Other test" + Front.Value);
                    
                Rear = Top;
                Console.WriteLine("Rear" + Rear.Value);
            
                while (HolderStack.Top != null)
                {
                    Push(HolderStack.Pop());
                }
            }
        }

        public Node Dequeue()
        {
            Node removed = Pop();
            Front = Top;
            return removed;
        
        }

    }
}
