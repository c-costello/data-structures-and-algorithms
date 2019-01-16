using System;
using Xunit;
using LLKthFromEndApp;
using LinkedList.classes;

namespace KthFromEndTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturn3rdValueFromEnd()
        {
            LList list = new LList();
            list.Insert(7);
            list.Insert(6);
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);

            Assert.Equal(5, Program.FindKthFromEnd(3, list));

        }

    }
}
