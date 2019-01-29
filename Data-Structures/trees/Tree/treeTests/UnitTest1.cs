using System;
using Xunit;
using Tree.Classes;

namespace treeTests
{
    public class UnitTest1
    {
        //Add tests
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


        //Contains tests
        [Fact]
        public void CanFindRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);

            Assert.True(tree.Contains(tree.Root, 50));

        }
        [Fact]
        public void CanFindChild()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            tree.Add(tree.Root, 35);

            Assert.True(tree.Contains(tree.Root, 25));
            Assert.True(tree.Contains(tree.Root, 75));
            Assert.True(tree.Contains(tree.Root, 35));
        }

        [Fact]
        public void ReturnsFalseIfDataIsNotIncluded()
        {
            
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Add(tree.Root, 25);
            tree.Add(tree.Root, 75);
            tree.Add(tree.Root, 35);

            Assert.False(tree.Contains(tree.Root, 15));
        }
    }


}
