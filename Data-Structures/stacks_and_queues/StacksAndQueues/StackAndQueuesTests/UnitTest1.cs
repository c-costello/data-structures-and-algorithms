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
    }
}
