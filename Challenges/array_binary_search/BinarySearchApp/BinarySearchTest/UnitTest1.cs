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
        [Fact]
        public void CanReturnIndexOne()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int num = 2;
            Assert.Equal(1, Program.BinarySearch(arr, num));

        }
        [Fact]
        public void CanReturnIndexFour()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int num = 5;
            Assert.Equal(4, Program.BinarySearch(arr, num));

        }
        [Fact]
        public void CanReturnIndexZero()
        { 
            int[] arr = { 1, 2, 3, 4, 5 };
            int num = 1;
            Assert.Equal(0, Program.BinarySearch(arr, num));

        }
        [Fact]
        public void CanHandleAnEvenArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int num = 3;
            Assert.Equal(2, Program.BinarySearch(arr, num));
        }
    
    }
}
