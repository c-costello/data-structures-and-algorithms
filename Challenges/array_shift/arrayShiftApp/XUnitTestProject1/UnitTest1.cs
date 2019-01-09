using System;
using Xunit;
using arrayShiftApp;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void canInsertWithFourNumbers()
        {
            int[] givenArr = { 1, 2, 3, 4 };
            int[] returnedArr = { 1, 2, 5, 3, 4 };
            Assert.Equal(returnedArr, Program.ArrayShift(givenArr, 5));
        }
    }
}
