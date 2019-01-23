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

            Assert.Equal(5, pQ.Top.Value);

        }
        [Fact]
        public void LastInNodeIsLastInQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(6);
            pQ.Enqueue(7);

            Assert.Equal(7, pQ.Top.Next.Value);
        }

        [Fact]
        public void FirstInNodeIsFirstInQueue()
        {
            PsuedoQueue pQ = new PsuedoQueue();
            pQ.Enqueue(5);
            pQ.Enqueue(7);
            pQ.Enqueue(9);
            Assert.Equal(5, pQ.Top.Value);
        }
    }
}
