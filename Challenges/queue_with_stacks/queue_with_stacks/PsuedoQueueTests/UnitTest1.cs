using System;
using Xunit;
using queue_with_stacks;
using queue_with_stacks.Classes;

namespace PsuedoQueueTests
{
    public class UnitTest1
    {

        // enqueue tests

        [Fact]
        public void CanEnqueueIntoAnEmptyQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);

            Assert.Equal(5, pQ.Front.Value);

        }
        [Fact]
        public void LastInNodeIsLastInQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(6);
            pQ.Enqueue(7);

            Assert.Equal(7, pQ.Rear.Value);
        }

        [Fact]
        public void FirstInNodeIsFirstInQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(7);
            pQ.Enqueue(9);
            Assert.Equal(5, pQ.Front.Value);
        }

        //Dequeue tests

        [Fact]
        public void CannotDequeueEmptyQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();

            Assert.Null(pQ.Dequeue());
        }

        [Fact]
        public void FirstInIsFirstOut()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(7);
            pQ.Enqueue(9);
            Assert.Equal(5, pQ.Dequeue().Value);
        }

        [Fact]
        public void LastInIsLastOut()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(7);
            pQ.Enqueue(9);
            pQ.Dequeue();
            pQ.Dequeue();
            Assert.Equal(9, pQ.Dequeue().Value);

        }
    }
}
