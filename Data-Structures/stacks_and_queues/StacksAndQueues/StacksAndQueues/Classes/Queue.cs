using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }


        /// <summary>
        /// Creates a queue with one node
        /// </summary>
        /// <param name="node">Node</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }


        /// <summary>
        /// creates an empty queue
        /// </summary>
        public Queue()
        {
            Front = null;
            Rear = null;
        }


        /// <summary>
        /// Adds new node to end of list
        /// </summary>
        /// <param name="value">Int</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Adds new node to end of list
        /// </summary>
        /// <param name="node">Node</param>
        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Remove top node
        /// </summary>
        /// <returns>Top node</returns>
        public Node Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("Your Queue is Empty! There's Nothing to Dequeue!");
                return null;
            }
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// Returns front node
        /// </summary>
        /// <returns>Front</returns>
        public Node Peek()
        {
            return Front;
        }
        

    }
}
