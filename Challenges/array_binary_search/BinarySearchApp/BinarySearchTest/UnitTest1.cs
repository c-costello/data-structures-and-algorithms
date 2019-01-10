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
            int[] arr = { 1, 2, 3, 4, 5};
            int num = 11;
            Assert.Equal(-1, Program.BinarySearch(arr, num));
        }
        [Fact]
        public void CanReturnMidpoint()
        {
            int[] arr = { 1, 2, 3, 4, 5};
            int num = 3;
            Assert.Equal(2, Program.BinarySearch(arr, num));
        }
    }
}
