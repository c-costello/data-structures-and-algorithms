using System;
using Xunit;
using LinkedList;
using LinkedList.classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void WillCreateAList()
        {
            Assert.NotNull(Program.CreateAList());
        }

        [Fact]
        public void CanInsertOneNumbers()
        {
            LList list = new LList();
            list.Insert(5);
            LList expectedList = new LList
            {
                Current = null,
                Head = new Node(5) { Next = null, Value = 5 }
            };
            Assert.Equal(list.Head.Value, expectedList.Head.Value);
        }
    }
}
