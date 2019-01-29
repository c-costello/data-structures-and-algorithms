using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Creates a stack with the given node set to Top
        /// </summary>
        /// <param name="node">Node</param>
        public Stack(Node<T> node)
        {
            Top = node;
        }

        /// <summary>
        /// Creates and empty stack
        /// </summary>
        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// Pushes value into Stack
        /// </summary>
        /// <param name="value">int</param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pushes new node into Stack
        /// </summary>
        /// <param name="node">Node</param>
        public void Push(Node<T> node)
        {
            node.Next = Top;
            Top = node;
        }


        /// <summary>
        /// Pops the top node off of the stack, returns that node
        /// </summary>
        /// <returns>Node</returns>
        public Node<T> Pop()
        {
            Node<T> temp = null;
            try
            {
                temp = Top;
                Top = Top.Next;
                temp.Next = null;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Your Stack is Empty, there's no node!");
                return null;
            }
            return temp;
        }


        /// <summary>
        /// Returns top node
        /// </summary>
        /// <returns>Node</returns>
        public Node<T> Peek()
        {
            return Top;
        }


       
    }
}
