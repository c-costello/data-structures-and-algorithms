using System;
using System.Collections.Generic;
using Tree.Classes;

namespace BinaryTreeHeightApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);
            Console.WriteLine(CalculateBinaryTreeHeight(tree.Root));
        }

        public static int CalculateBinaryTreeHeight(Node<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = 0;
            int rightHeight = 0;
            if (root.LeftChild != null)
            {
                leftHeight = CalculateBinaryTreeHeight(root.LeftChild, leftHeight);
                
            }
            if (root.RightChild != null)
            {
               rightHeight = CalculateBinaryTreeHeight(root.RightChild, rightHeight);
            }
            if (leftHeight > rightHeight)
            {
                return leftHeight - 1;
            }
            else
            {
                return rightHeight - 1;
            }
        }
        public static int CalculateBinaryTreeHeight(Node<int> root, int height)
        {

            if (root.LeftChild != null)
            {
                height = CalculateBinaryTreeHeight(root.LeftChild, height);

            }
            if (root.RightChild != null)
            {
                height = CalculateBinaryTreeHeight(root.RightChild, height);
            }
            height++;
            Console.WriteLine("V" + root.Value);
            Console.WriteLine("H" + height);
            return height;
        }

    }
}
