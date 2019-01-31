using System;
using Tree.Classes;
using Xunit;
using FindMaxApp;

namespace FindMaxTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMaxValue()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(7);
            tree.Root.LeftChild = new Node<int>(45);
            tree.Root.LeftChild.LeftChild = new Node<int>(11);
            tree.Root.LeftChild.RightChild = new Node<int>(27);
            tree.Root.RightChild = new Node<int>(2);
            tree.Root.RightChild.LeftChild = new Node<int>(100);
            tree.Root.RightChild.RightChild = new Node<int>(4);

            Assert.Equal(100, Program.FindMaxValue(tree));
        }

        [Fact]
        public void CanFindMaxValueWithNegativeNumbers()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(-7);
            tree.Root.LeftChild = new Node<int>(-45);
            tree.Root.LeftChild.LeftChild = new Node<int>(-11);
            tree.Root.LeftChild.RightChild = new Node<int>(-27);
            tree.Root.RightChild = new Node<int>(-2);
            tree.Root.RightChild.LeftChild = new Node<int>(-100);
            tree.Root.RightChild.RightChild = new Node<int>(-4);

            Assert.Equal(-2, Program.FindMaxValue(tree));
        }

        [Fact]
        public void CannotFindMaxValueOfEmptyTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Throws<NullReferenceException>(() => Program.FindMaxValue(tree));
        }
    }
}
