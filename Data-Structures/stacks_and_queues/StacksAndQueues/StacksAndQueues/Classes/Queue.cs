using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }


        /// <summary>
        /// Creates a queue with one node
        /// </summary>
        /// <param name="node">Node</param>
        public Queue(Node<T> node)
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
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
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
        public void Enqueue(Node<T> node)
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
        public Node<T> Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("Your Queue is Empty! There's Nothing to Dequeue!");
                return null;
            }
            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// Returns front Node<T>
        /// </summary>
        /// <returns>Front</returns>
        public Node<T> Peek()
        {
            return Front;
        }
        

    }
}
