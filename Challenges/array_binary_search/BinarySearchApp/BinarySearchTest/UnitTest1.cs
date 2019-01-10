using System;
using Xunit;
using BinarySearchApp;


namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnNegativeOne()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num = 3;
            Assert.Equal(-1, Program.BinarySearch(arr, num));
        }
        [Fact]
        public void CanReturnArrayMidpoint()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num = 5;
            Assert.Equal(5, Program.BinarySearch(arr, num));

        }
    }
}
