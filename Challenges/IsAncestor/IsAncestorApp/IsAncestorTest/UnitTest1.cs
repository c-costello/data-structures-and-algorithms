using System;
using Xunit;
using Tree.Classes;
using IsAncestorApp;

namespace IsAncestorTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnTrueIfBIsAncestorOfA()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);

            Assert.True(Program.IsAncestor(2, 4, tree.Root));

        }
        [Fact]
        public void WillReturnFalseIfAIsAncestorOfB()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);

            Assert.False(Program.IsAncestor(4, 2, tree.Root));
        }

        [Fact]
        public void WillReturnFalseIfBDoesNotExist()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);

            Assert.False(Program.IsAncestor(2, 7, tree.Root));
        }
        [Fact]
        public void WillReturnFalseIfADoesNotExist()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);

            Assert.False(Program.IsAncestor(7, 4, tree.Root));
        }
    }

}
