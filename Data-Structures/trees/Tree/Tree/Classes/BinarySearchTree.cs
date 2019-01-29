using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree<int>
    {
        public Node<int> Root {get; set;}


        public void Add(Node<int> root, int value)
        {
            
            if (value < root.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = new Node<int>(value);
                }
                else
                {
                    Add(root.LeftChild, value);
                }
                
            }

            if (value > root.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = new Node<int>(value);
                }
                else
                {
                    Add(root.RightChild, value);
                }

            }

        }
    }
}
