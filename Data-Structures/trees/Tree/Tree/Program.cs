﻿using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree bTree = new BinaryTree();

            bTree.Root = new Node(50);
            bTree.Root.LeftChild = new Node(300);
            bTree.Root.RightChild = new Node(22);
            bTree.Root.LeftChild.LeftChild = new Node(75);
            bTree.Root.LeftChild.RightChild = new Node(11);
            bTree.Root.RightChild.LeftChild = new Node(3);
            bTree.Root.RightChild.RightChild = new Node(100);
            Console.WriteLine("=====================PreOrder===================");
            Console.Write(String.Join(" ", bTree.PreOrder(bTree.Root)));
            Console.WriteLine();
            Console.WriteLine("=====================InOrder===================");
            Console.Write(String.Join(" ", bTree.InOrder(bTree.Root)));
            Console.WriteLine();
            Console.WriteLine("=========================");
            bTree.InOrder2(bTree.Root);
            Console.WriteLine();
            Console.WriteLine("+++++++++PostOrder+++++++++++++++++");
            Console.Write(String.Join(" ", bTree.PostOrder(bTree.Root)));
            Console.WriteLine();
        }
    }
}
