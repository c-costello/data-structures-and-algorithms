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

        [Fact]
        public void CanPopEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.Pop());
        }

        //Peak 
        [Fact]
        public void CanPeakStackWithOneNode()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);
            Assert.Equal(5, stack.Peek().Value);
        }

        [Fact]
        public void CanPeakStackWithMultipleNodes()
        {
            Node node = new Node(5);
            Stack stack = new Stack(node);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            Assert.Equal(8, stack.Peek().Value);
        }

        [Fact]
        public void EmptyStacksReturnNullWhenPeeked()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        //Queue tests

        ///Constructor tests
        [Fact]
        public void CanCreateEmptyQueue()
        {
            Queue queue = new Queue();

            Assert.Null(queue.Front);
        }

        [Fact]
        public void CanCreateQueueWithOneNode()
        {
            Node node = new Node(5);
            Queue queue = new Queue(node);
            Assert.Equal(5, queue.Front.Value);
        }

        [Fact]
        public void CanCreateQueueWithNullNode()
        {
            Node node = null;
            Queue queue = new Queue(node);
            Assert.Null(queue.Front);
        }

        //Enqueue tests
        [Fact]
        public void CanAddNodeToEmptyQueue()
        {
            Queue queue = new Queue();
            Node node = new Node(5);
            queue.Enqueue(node);

            Assert.Equal(5, queue.Rear.Value);
        }

        [Fact]
        public void CanAddValueToEmptyQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Rear.Value);
        }

        [Fact]
        public void CanAddValueToOccupiedQueue()
        {
            Node node = new Node(5);
            Queue queue = new Queue(node);
            queue.Enqueue(10);

            Assert.Equal(10, queue.Rear.Value);
        }

        //Dequeue 
        [Fact]
        public void CanDequeueFromFullQueue()
        {
            Node node = new Node(5);
            Queue queue = new Queue(node);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            Assert.Equal(5, queue.Dequeue().Value);
        }

        [Fact]
        public void CanDequeueFromQueueWithOneNode()
        {
            Node node = new Node(5);
            Queue queue = new Queue(node);

            Assert.Equal(5, queue.Dequeue().Value);

        }

        [Fact]
        public void CanDequeueFromQueueWithOneTestTwo()
        {
            Node node = new Node(5);
            Queue queue = new Queue(node);
            queue.Dequeue();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void CannotDequeueEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Dequeue());


        }

    }
}
