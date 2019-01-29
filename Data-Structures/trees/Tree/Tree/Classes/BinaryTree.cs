using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace Tree.Classes
{
    class BinaryTree
    {

        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;

        }

        public BinaryTree(Node node)
        {
            Root = node;
        }
    

        public int[] PreOrder(Node root)
        {   
            List<int> list = new List<int>();
            list.Add(root.Value);            
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild, list);
            }
            int[] arr = list.ToArray();
            //Console.WriteLine(String.Join(" ",arr));
            return arr;

        }

        public int[] PreOrder(Node root, List<int> list)
        {
            list.Add(root.Value);
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild, list);
            }
            int[] arr = list.ToArray();
            //Console.WriteLine(String.Join(" ",arr));
            return arr;

        }

        public int[] InOrder(Node root)
        {
            List<int> list = new List<int>();
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild, list);
            }
            list.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrder(root.RightChild, list);
            }
            int[] arr = list.ToArray();
            return arr;

        }

        public int[] InOrder(Node root, List<int> list)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild, list);
            }
            list.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrder(root.RightChild, list);
            }
            int[] arr = list.ToArray();
            return arr;

        }



        public int[] PostOrder(Node root)
        {
            List<int> list = new List<int>();
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild, list);
            }
            list.Add(root.Value);
            int[] arr = list.ToArray();
            return arr;

        }

        public int[] PostOrder(Node root, List<int> list)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild, list);
            }
            list.Add(root.Value);
            int[] arr = list.ToArray();
            return arr;

        }
        public void InOrder2(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder2(root.LeftChild);
            }
            Console.Write(" " + root.Value);
            if (root.RightChild != null)
            {
                InOrder2(root.RightChild);
            }
        }

        public void PostOrder2(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder2(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PostOrder2(root.RightChild);
            }
            Console.Write(" " + root.Value);

        }
    }
}
