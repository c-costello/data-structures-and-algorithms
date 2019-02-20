using hashtablesApp.Classes;
using StacksAndQueues;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersectionApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Tree.Classes.Node<int>(1);
            tree1.Root.LeftChild = new Tree.Classes.Node<int>(2);
            tree1.Root.RightChild = new Tree.Classes.Node<int>(3);

            tree2.Root = new Tree.Classes.Node<int>(5);
            tree2.Root.LeftChild = new Tree.Classes.Node<int>(2);
            tree2.Root.RightChild = new Tree.Classes.Node<int>(3);

            Console.WriteLine(String.Join(" ->", TreeIntersection(tree1, tree2)));
        }
        public static int[] TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            if (tree1.Root == null || tree2.Root == null)
            {
                int[] emptyArray = new int[0];
                return emptyArray;
            }
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
