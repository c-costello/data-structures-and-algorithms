using System;
using System.Collections.Generic;
using Tree.Classes;

namespace IsAncestorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsAncestor(int A, int B, Node<int> root)
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            Queue<Node<int>> aIsFound = new Queue<Node<int>>();
            queue.Enqueue(root);
            while (queue.Peek() != null)
            {
                if (queue.Peek().Value == B)
                {
                    return false;
                }
                if (queue.Peek().LeftChild != null)
                {
                    queue.Enqueue(queue.Peek().LeftChild);
                }
                if (queue.Peek().RightChild != null)
                {
                    queue.Enqueue(queue.Peek().RightChild);
                }
                if (queue.Peek().Value == A)
                {
                    aIsFound.Enqueue(queue.Dequeue());
                    break;
                }
                queue.Dequeue();
            }

            while (aIsFound.Count > 0)
            {
                if (aIsFound.Peek().Value == B)
                {
                    return true;
                }
                if (aIsFound.Peek().LeftChild != null)
                {
                    aIsFound.Enqueue(aIsFound.Peek().LeftChild);
                }
                if (aIsFound.Peek().RightChild != null)
                {
                    aIsFound.Enqueue(aIsFound.Peek().RightChild);
                }
                aIsFound.Dequeue();
            }
            return false;

        }


    }
}
