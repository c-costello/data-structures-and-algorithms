using System;
using Xunit;
using BinaryTreeHeightApp;
using Tree.Classes;

namespace BinaryTreeHeightTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHeightOfBalanceBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);

            Assert.Equal(2, Program.CalculateBinaryTreeHeight(tree.Root));
        }
        [Fact]
        public void CanFindHeightOFUnBalancedBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);
            tree.Root.RightChild.RightChild.RightChild = new Node<int>(8);
            Assert.Equal(3, Program.CalculateBinaryTreeHeight(tree.Root));
        }
        [Fact]
        public void CanFindHeightOfSuperUnBalancedBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(1);
            tree.Root.LeftChild = new Node<int>(2);
            tree.Root.RightChild = new Node<int>(3);
            tree.Root.LeftChild.LeftChild = new Node<int>(4);
            tree.Root.LeftChild.RightChild = new Node<int>(5);
            tree.Root.RightChild.LeftChild = new Node<int>(6);
            tree.Root.RightChild.RightChild = new Node<int>(7);
            tree.Root.RightChild.RightChild.RightChild = new Node<int>(8);
            tree.Root.RightChild.RightChild.RightChild.RightChild = new Node<int>(9);
            tree.Root.RightChild.RightChild.RightChild.RightChild.RightChild = new Node<int>(10);            tree.Root.RightChild.RightChild.RightChild.RightChild.RightChild.LeftChild = new Node<int>(11);
            Assert.Equal(6, Program.CalculateBinaryTreeHeight(tree.Root));
        }
        [Fact]
        public void ReturnsZeroWhenTreeIsEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Equal(0, Program.CalculateBinaryTreeHeight(tree.Root));
        }
    }
}
