using System;
using Xunit;
using IsAncestorApp;
using Tree.Classes;

namespace IsAncestoryTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnFalseIfBDoesNotExist
        {
            Tree tree = new BinaryTree();
        }

        [Fact]
        public void WillReturnFalseIfBComesFirst
        {

        }

        [Fact]
        public void WillReturnFalseIfBIsNotDescendant
        {

        }

        [Fact]
        public void WillReturnTrueIfBIsDescendant
        {

        }
    }
}
