using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace Tree.Classes
{
    public class BinaryTree<T>
    {

        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;

        }

        public BinaryTree(Node<T> node)
        {
            Root = node;
        }
    

        public T[] PreOrder(Node<T> root)
        {   
            List<T> list = new List<T>();
            list.Add(root.Value);            
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild, list);
            }
            T[] arr = list.ToArray();
            //Console.WriteLine(String.Join(" ",arr));
            return arr;

        }

        public T[] PreOrder(Node<T> root, List<T> list)
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
            T[] arr = list.ToArray();
            //Console.WriteLine(String.Join(" ",arr));
            return arr;

        }

        public T[] InOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild, list);
            }
            list.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrder(root.RightChild, list);
            }
            T[] arr = list.ToArray();
            return arr;

        }

        public T[] InOrder(Node<T> root, List<T> list)
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
            T[] arr = list.ToArray();
            return arr;

        }



        public T[] PostOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild, list);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild, list);
            }
            list.Add(root.Value);
            T[] arr = list.ToArray();
            return arr;

        }

        public T[] PostOrder(Node<T> root, List<T> list)
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
            T[] arr = list.ToArray();
            return arr;

        }
        public void InOrder2(Node<T> root)
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

        public void PostOrder2(Node<T> root)
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
