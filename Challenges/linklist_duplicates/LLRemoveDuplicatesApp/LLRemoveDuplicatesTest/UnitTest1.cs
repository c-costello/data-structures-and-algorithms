using System;
using Xunit;
using LLRemoveDuplicatesApp;
using LinkedList.classes;

namespace LLRemoveDuplicatesTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanRemoveOneDuplicate()
        {
            LList list = new LList();
            list.Head = new Node(1);
            list.Append(2);
            list.Append(3);
            list.Append(2);
            list.Append(4);
            Program.RemoveDuplicatens(list);
            LList checkList = new LList();
            checkList.Head = new Node(1);
            checkList.Append(2);
            checkList.Append(3);
            checkList.Append(4);
            Assert.Equal(checkList.Head.Next.Next.Next.Value, list.Head.Next.Next.Next.Value);
        }
        [Fact]
        public void CanRemoveMultipleDuplicate()
        {
            LList list = new LList();
            list.Head = new Node(1);
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(3);
            list.Append(4);
            list.Append(2);
            list.Append(5);
            Program.RemoveDuplicatens(list);
            LList checkList = new LList();
            checkList.Head = new Node(1);
            checkList.Append(2);
            checkList.Append(3);
            checkList.Append(4);
            Assert.Equal(checkList.Head.Next.Next.Next.Value, list.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void ReturnsSameListIfNoDuplcates()
        {
            LList list = new LList();
            list.Head = new Node(1);
            list.Append(2);
            list.Append(3);
            Assert.Equal(list.Head.Next, Program.RemoveDuplicatens(list).Head.Next);
        }
    }
}
