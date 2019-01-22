using System;
using Xunit;
using StacksAndQueues;

namespace StackAndQueuesTests
{
    public class UnitTest1
    {

        //Stack tests

        //Constructor test
        [Fact]
        public void CanCreateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.Top);
        }

        [Fact]
        public void CanCreateStackWithOneNode()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanCreateStackWithNullNode()
        {
            Node node = new Node(5);
            node = null;
            Stack stack = new Stack(node);
            Assert.Null(stack.Top);
        }

        //Push tests
        [Fact]
        public void CanAddNodeToEmptyStack()
        {
            Stack stack = new Stack();
            Node node = new Node(5);
            stack.Push(node);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanAddValueToEmptyStack()
        {
            Stack stack = new Stack();
            stack.Push(5);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanAddValueToOccupiedStack()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);
            stack.Push(10);

            Assert.Equal(10, stack.Top.Value);
        }

        //pop tests
        [Fact]
        public void CanPopNode()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);
            stack.Push(6);
            stack.Push(7);
            Assert.Equal(7, stack.Pop().Value);
        }

        [Fact]
        public void CanPopOnlyNode()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);

            Assert.Equal(5, stack.Pop().Value);
        }
    }
}
