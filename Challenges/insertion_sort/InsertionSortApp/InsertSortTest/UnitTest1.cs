using System;
using Xunit;
using InsertionSortApp;

namespace InsertSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUnorderedList()
        {
            int[] array = { 3, 5, 2, 6, 1 };
            int[] expected = { 1, 2, 3, 5, 6 };

            Assert.Equal(expected, Program.InsertionSort(array));
        }
        [Fact]
        public void CanSortUnorderedListWithRepeatValues()
        {
            int[] array = { 5, 5, 4, 4, 6 };
            int[] expected = { 4, 4, 5, 5, 6 };

            Assert.Equal(expected, Program.InsertionSort(array));
        }

        [Fact]
        public void IfArrayHasAllSameValuesReturnsIdentitalArray()
        {
            int[] array = { 5, 5, 5 };

            Assert.Equal(array, Program.InsertionSort(array));
        }

        [Fact]
        public void CanSortUnorderedListWithBlanks()
        {
            int[] array = new int[5];
            array[0] = 5;
            array[2] = 9;
            array[4] = 3;

            int[] expected = new int[5];

            expected[2] = 3;
            expected[3] = 5;
            expected[4] = 9;

            Assert.Equal(expected, Program.InsertionSort(array));            
        }
        [Fact]
        public void CanSortReversedList()
        {
            int[] array = {5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5};

            Assert.Equal(expected, Program.InsertionSort(array));
        }

        [Fact]
        public void ReturnsSameArrayIfAlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, Program.InsertionSort(array));
        }

        [Fact]
        public void IfArrayIsEmptyReturnsEmptyArray()
        {
            int[] array = new int[5];

            Assert.Equal(array, Program.InsertionSort(array));
        }

        [Fact]
        public void IfArrayHasOneValueReturnSameValue()
        {
            int[] array = { 5 };
            Assert.Equal(array, Program.InsertionSort(array));
        }
    }
}
