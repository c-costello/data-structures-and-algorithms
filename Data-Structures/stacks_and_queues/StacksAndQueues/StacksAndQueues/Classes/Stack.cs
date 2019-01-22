using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Creates a stack with the given node set to Top
        /// </summary>
        /// <param name="node">Node</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Creates and empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Pushes value into Stack
        /// </summary>
        /// <param name="value">int</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pushes new node into Stack
        /// </summary>
        /// <param name="node">Node</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }


        /// <summary>
        /// Pops the top node off of the stack, returns that node
        /// </summary>
        /// <returns>Node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }


        /// <summary>
        /// Returns top node
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            return Top;
        }


       
    }
}
