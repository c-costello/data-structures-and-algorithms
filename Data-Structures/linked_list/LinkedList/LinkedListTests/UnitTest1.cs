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
            LList list = new LList();
            Assert.NotNull(list);
        }

        [Fact]
        public void CreatedListHeadIsNull()
        {
            LList list = new LList();


            Assert.Null(list.Head);
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
            Assert.Equal(expectedList.Head.Value, list.Head.Value);
        }

        [Fact] 
        public void CanInsertThreeNumbers()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            int[] expectedListValues = { 6, 5, 4 };
            int[] actualListValues = new int[3];
            int i = 0;
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                actualListValues[i] = list.Current.Value;
                list.Current = list.Current.Next;
                i++;
            }
            actualListValues[2] = list.Current.Value;

            Assert.Equal(expectedListValues, actualListValues);
            
        }

        [Fact]
        public void InsertsNewNodeIntoHead()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            int expectedValue = 7;

            Assert.Equal(expectedValue, list.Head.Value);

        }

        [Fact]
        public void CanFindIncludedNumber()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            Assert.True(list.Includes(6));
        }
        [Fact]
        public void ReturnsFalseIfNumberIsNotIncluded()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            Assert.False(list.Includes(100));

        }

        [Fact]
        public void WillReturnTrueIfHeadValueIsTheCheckedValue()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);

            Assert.True(list.Includes(7));

        }

        [Fact]
        public void CanAppendValueToEndOfList()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Append(0);

            int expectedLastValue = 0;
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                list.Current = list.Current.Next;
            }
            int actualLastValue = list.Current.Value;
            Assert.Equal(expectedLastValue, actualLastValue);
        }

    }


}
