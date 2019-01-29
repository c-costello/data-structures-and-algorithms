using System;
using Xunit;
using Tree.Classes;

namespace treeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddValueToTreeWithOneNode()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);

            Assert.Equal(25, tree.Root.LeftChild.Value);
        }

        [Fact]
        public void CanAddSecondValue()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            Assert.Equal(75, tree.Root.RightChild.Value);
        }

        [Fact]
        public void CanAdd35()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            tree.Add(tree.Root, 35);

            Assert.Equal(35, tree.Root.LeftChild.RightChild.Value);

        }

        [Fact]
        public void CanAdd65()
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            tree.Add(tree.Root, 35);
            tree.Add(tree.Root, 65);

            Assert.Equal(65, tree.Root.RightChild.LeftChild.Value);

        }

        [Fact]
        public void DoesNotAddRepeatNumbers()
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            tree.Add(tree.Root, 35);
            tree.Add(tree.Root, 65);
            tree.Add(tree.Root, 65);

            Assert.Null(tree.Root.RightChild.LeftChild.RightChild);
        }
    }
}
