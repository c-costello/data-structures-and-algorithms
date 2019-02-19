using hashtablesApp.Classes;
using StacksAndQueues;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int[] TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            Hashtable hashtable = new Hashtable();
            List<int> list = new List<int>();
            StacksAndQueues.Queue<Tree.Classes.Node<int>> queue = new StacksAndQueues.Queue<Tree.Classes.Node<int>>();
            queue.Enqueue(tree1.Root);
            while(queue.Front != null)
            {
                if(queue.Front.Value.LeftChild != null)
                {
                    queue.Enqueue(queue.Front.Value.LeftChild);
                }
                if (queue.Front.Value.RightChild != null)
                {
                    queue.Enqueue(queue.Front.Value.RightChild);
                }
                string key = queue.Front.Value.Value.ToString();
                hashtable.Add(key, key);
                queue.Dequeue();
            }
            queue.Enqueue(tree2.Root);
            while (queue.Front != null)
            {
                if (queue.Front.Value.LeftChild != null)
                {
                    queue.Enqueue(queue.Front.Value.LeftChild);
                }
                if (queue.Front.Value.RightChild != null)
                {
                    queue.Enqueue(queue.Front.Value.RightChild);
                }
                string key = queue.Front.Value.Value.ToString();
                if (hashtable.Contains(key))
                {
                    list.Add(Convert.ToInt32(key));
                }
                queue.Dequeue();
            }
            int[] arr = list.ToArray();
            return arr;
        }
    }
}
