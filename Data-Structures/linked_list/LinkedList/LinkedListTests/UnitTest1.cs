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
    }
}
