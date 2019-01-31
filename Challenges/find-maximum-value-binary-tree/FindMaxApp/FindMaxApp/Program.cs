using System;
using Tree.Classes;

namespace FindMaxApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(-7);
            tree.Root.LeftChild = new Node<int>(-45);
            tree.Root.LeftChild.LeftChild = new Node<int>(-11);
            tree.Root.LeftChild.RightChild = new Node<int>(-27);
            tree.Root.RightChild = new Node<int>(-2);
            tree.Root.RightChild.LeftChild = new Node<int>(-100);
            tree.Root.RightChild.RightChild = new Node<int>(-4);

            Console.WriteLine(FindMaxValue(tree));
        }

        /// <summary>
        /// Finds MaxValue of a tree.
        /// </summary>
        /// <param name="tree">BinaryTree</param>
        /// <returns>MaxValue</returns>
        public static int FindMaxValue(BinaryTree<int> tree)
        {
            //if (tree.Root == null)
            //{
            //    Exception nullTree = new Exception("tree cannot be empty");
            //    throw nullTree;
            //}
            int maxValue = int.MinValue;
            Node<int> root = tree.Root;

            if (maxValue < root.Value)
            {
                maxValue = root.Value;
            }

            if (root.LeftChild != null)
            {
                maxValue = FindMaxValue(root.LeftChild, maxValue);
            }
            if (root.RightChild != null)
            {
                maxValue = FindMaxValue(root.RightChild, maxValue);
            }

            return maxValue;


        }

        /// <summary>
        /// Overloaded method called by FIndMaxValue(BinaryTree)
        /// </summary>
        /// <param name="root">Node</param>
        /// <param name="maxValue">int</param>
        /// <returns>int maxValue</returns>
        private static int FindMaxValue(Node<int> root, int maxValue)
        {
            if (maxValue < root.Value)
            {
                maxValue = root.Value;
            }

            if (root.LeftChild != null)
            {
                maxValue = FindMaxValue(root.LeftChild, maxValue);
            }
            if (root.RightChild != null)
            {
                maxValue = FindMaxValue(root.RightChild, maxValue);
            }

            return maxValue;
        }
    }
}
