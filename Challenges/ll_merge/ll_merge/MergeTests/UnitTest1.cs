using ll_merge;
using LinkedList.classes;
using System;
using Xunit;

namespace MergeTests
{
    public class UnitTest1
    {
        [Fact]
        public void ListOneIncludesListTwoNodes()
        {
            LList listOne = new LList();
            LList listTwo = new LList();

            listOne.Insert(4);
            listOne.Insert(3);
            listOne.Insert(2);
            listOne.Insert(1);
            listTwo.Insert(7);
            listTwo.Insert(6);
            listTwo.Insert(5);
            listTwo.Insert(4);
            LList list = Program.Merge(listOne, listTwo);

            Assert.True(listOne.Includes(7));

        }

        [Fact]
        public void CanZipListsOfEqualLength()
        {
            LList listOne = new LList();
            LList listTwo = new LList();

            listOne.Insert(4);
            listOne.Insert(3);
            listOne.Insert(2);
            listOne.Insert(1);
            listTwo.Insert(7);
            listTwo.Insert(6);
            listTwo.Insert(5);
            listTwo.Insert(4);
            LList list = Program.Merge(listOne, listTwo);
            int[] expected = { 1, 4, 2, 5 };
            listOne.Current = listOne.Head.Next;
            int[] actual = { listOne.Head.Value, listOne.Current.Value, listOne.Current.Next.Value, listOne.Current.Next.Next.Value };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanZipListsWhenListOneIsLonger()
        {
            LList listOne = new LList();
            LList listTwo = new LList();
            listOne.Insert(3);
            listOne.Insert(2);
            listOne.Insert(1);
            listTwo.Insert(5);
            listTwo.Insert(4);
            LList list = Program.Merge(listOne, listTwo);
            int[] expected = { 1, 4, 2, 5, 3 };
            listOne.Current = listOne.Head.Next;
            int[] actual = { listOne.Head.Value, listOne.Current.Value, listOne.Current.Next.Value, listOne.Current.Next.Next.Value, listOne.Current.Next.Next.Next.Value };

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanZipListsWhenListTwoIsLonger()
        {
            LList listOne = new LList();
            LList listTwo = new LList();

            listOne.Insert(2);
            listOne.Insert(1);
            listTwo.Insert(6);
            listTwo.Insert(5);
            listTwo.Insert(4);
            LList list = Program.Merge(listOne, listTwo);
            int[] expected = { 1, 4, 2, 5, 6 };
            listOne.Current = listOne.Head.Next;
            int[] actual = { listOne.Head.Value, listOne.Current.Value, listOne.Current.Next.Value, listOne.Current.Next.Next.Value, listOne.Current.Next.Next.Next.Value };

            Assert.Equal(expected, actual);
        }
    }
}
