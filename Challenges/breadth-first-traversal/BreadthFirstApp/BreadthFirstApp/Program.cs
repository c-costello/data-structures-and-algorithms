using System;
using System.Collections.Generic;
using StacksAndQueues;
using Tree.Classes;

namespace BreadthFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Tree.Classes.Node<int>(3);
            tree.Root.LeftChild = new Tree.Classes.Node<int>(1);
            tree.Root.RightChild = new Tree.Classes.Node<int>(50);
            tree.Root.LeftChild.LeftChild = new Tree.Classes.Node<int>(75);
            tree.Root.LeftChild.RightChild = new Tree.Classes.Node<int>(4);
            tree.Root.RightChild.LeftChild = new Tree.Classes.Node<int>(19);
            BreadthFirstTraversal(tree);
            Console.WriteLine(String.Join("", BreadthFirstTraversal(tree)));

        }

        public static int[] BreadthFirstTraversal(BinaryTree<int> tree)
        {
            List<int> list = new List<int>();
            StacksAndQueues.Queue<Tree.Classes.Node<int>> queue = new StacksAndQueues.Queue<Tree.Classes.Node<int>>(new StacksAndQueues.Node<Tree.Classes.Node<int>>(tree.Root));
            while(queue.Front != null)
            {
                if (queue.Front.Value.LeftChild != null)
                {
                    queue.Enqueue(new StacksAndQueues.Node<Tree.Classes.Node<int>>(queue.Front.Value.LeftChild));
                }
                if (queue.Front.Value.RightChild != null)
                {
                    queue.Enqueue(new StacksAndQueues.Node<Tree.Classes.Node<int>>(queue.Front.Value.RightChild));
                }
                list.Add(queue.Dequeue().Value.Value);

            }
            int[] arr = list.ToArray();
            return arr;
        }
    }
}
