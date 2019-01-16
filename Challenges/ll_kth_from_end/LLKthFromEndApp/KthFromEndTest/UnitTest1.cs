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

        [Fact]
        public void WillReturn3rdValueFromEndReversed()
        {
            LList list = new LList();
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            Assert.Equal(5, Program.FindKthFromEnd(3, list));
        }


        [Fact]
        public void WillReturnValueFromLongList()
        {
            LList list = new LList();
            for (int i = 1; i < 101; i++)
            {
                list.Insert(i);
            }

            Assert.Equal(50, Program.FindKthFromEnd(50, list));
        }

    }
}
