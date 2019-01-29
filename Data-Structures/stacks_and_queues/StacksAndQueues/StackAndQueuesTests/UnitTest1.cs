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
            Stack<int> stack = new Stack<int>();

            Assert.Null(stack.Top);
        }

        [Fact]
        public void CanCreateStackWithOneNode()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanCreateStackWithNullNode()
        {
            Node<int> node = new Node<int>(5);
            node = null;
            Stack<int> stack = new Stack<int>(node);
            Assert.Null(stack.Top);
        }

        //Push tests
        [Fact]
        public void CanAddNodeToEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            Node<int> node = new Node<int>(5);
            stack.Push(node);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanAddValueToEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);

            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void CanAddValueToOccupiedStack()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);
            stack.Push(10);

            Assert.Equal(10, stack.Top.Value);
        }

        //pop tests
        [Fact]
        public void CanPopNode()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);
            stack.Push(6);
            stack.Push(7);
            Assert.Equal(7, stack.Pop().Value);
        }

        [Fact]
        public void CanPopOnlyNode()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);

            Assert.Equal(5, stack.Pop().Value);
        }

        [Fact]
        public void CanPopEmptyStack()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Null(stack.Pop());
        }

        //Peak 
        [Fact]
        public void CanPeakStackWithOneNode()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);
            Assert.Equal(5, stack.Peek().Value);
        }

        [Fact]
        public void CanPeakStackWithMultipleNodes()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>(node);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            Assert.Equal(8, stack.Peek().Value);
        }

        [Fact]
        public void EmptyStacksReturnNullWhenPeeked()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Null(stack.Peek());
        }

        //Queue tests

        ///Constructor tests
        [Fact]
        public void CanCreateEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();

            Assert.Null(queue.Front);
        }

        [Fact]
        public void CanCreateQueueWithOneNode()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);
            Assert.Equal(5, queue.Front.Value);
        }

        [Fact]
        public void CanCreateQueueWithNullNode()
        {
            Node<int> node = null;
            Queue<int> queue = new Queue<int>(node);
            Assert.Null(queue.Front);
        }

        //Enqueue tests
        [Fact]
        public void CanAddNodeToEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();
            Node<int> node = new Node<int>(5);
            queue.Enqueue(node);

            Assert.Equal(5, queue.Rear.Value);
        }

        [Fact]
        public void CanAddValueToEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Rear.Value);
        }

        [Fact]
        public void CanAddValueToOccupiedQueue()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);
            queue.Enqueue(10);

            Assert.Equal(10, queue.Rear.Value);
        }

        //Dequeue 
        [Fact]
        public void CanDequeueFromFullQueue()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            Assert.Equal(5, queue.Dequeue().Value);
        }

        [Fact]
        public void CanDequeueFromQueueWithOneNode()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);

            Assert.Equal(5, queue.Dequeue().Value);

        }

        [Fact]
        public void CanDequeueFromQueueWithOneTestTwo()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);
            queue.Dequeue();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void CannotDequeueEmptyQueue()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Dequeue());
        }

        //Peek 
        [Fact]
        public void PeekingEmptyQueueReturnsNull()
        {
            Queue<int> queue = new Queue<int>();
            Assert.Null(queue.Peek());
        }

        [Fact]
        public void CanPeekQueueWithOneNode()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);

            Assert.Equal(5, queue.Peek().Value);
        }

        [Fact]
        public void CanPeekQueueWithMultipleNodes()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>(node);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            Assert.Equal(5, queue.Peek().Value);
        }

    }
}
