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
    }
}
