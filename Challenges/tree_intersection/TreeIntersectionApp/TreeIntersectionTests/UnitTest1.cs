using System;
using Xunit;
using Tree.Classes;
using TreeIntersectionApp;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindIntersectingValues()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Tree.Classes.Node<int>(1);
            tree1.Root.LeftChild = new Tree.Classes.Node<int>(2);
            tree1.Root.RightChild = new Tree.Classes.Node<int>(3);

            tree2.Root = new Tree.Classes.Node<int>(5);
            tree2.Root.LeftChild = new Tree.Classes.Node<int>(2);
            tree2.Root.RightChild = new Tree.Classes.Node<int>(3);

            int[] expected = {2, 3};

            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }
        [Fact]
        public void CanFindIntersectingValuesOfUnbalancedTrees()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Node<int>(1);
            tree1.Root.LeftChild = new Node<int>(7);
            tree1.Root.RightChild = new Node<int>(5);
            tree1.Root.RightChild.LeftChild = new Node<int>(11);
            tree1.Root.RightChild.LeftChild.LeftChild = new Node<int>(2);

            tree2.Root = new Node<int>(5);
            tree2.Root.LeftChild = new Node<int>(2);
            tree2.Root.RightChild = new Node<int>(3);
            tree2.Root.LeftChild.LeftChild = new Node<int>(7);

            int[] expected = { 5, 2, 7 };

            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanHandleEmptyTrees()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Tree.Classes.Node<int>(1);
            int[] expected = new int[0];

            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));

        }

        [Fact]
        public void ReturnsEmptyStringIfTreesHaveNoCommonValues()
        {
            BinaryTree<int> tree1 = new BinaryTree<int>();
            BinaryTree<int> tree2 = new BinaryTree<int>();

            tree1.Root = new Node<int>(1);
            tree2.Root = new Node<int>(7);

            int[] expected = new int[0];

            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));

        }
    }
}
