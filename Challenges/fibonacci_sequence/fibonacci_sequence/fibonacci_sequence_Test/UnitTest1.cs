using System;
using Xunit;
using fibonacci_sequence;

namespace fibonacci_sequence_Test
{
    public class UnitTest1
    {
        [Fact]
        public void canReturnFifthTerm()
        {
            Assert.Equal(5, Program.FindNthTerm(5));
        }

        [Fact]
        public void canReturnTenthTerm()
        {
            Assert.Equal(55, Program.FindNthTerm(10));
        }
        [Fact]
        public void canReturn50thTerm()
        {
            Assert.Equal(12586269025, Program.FindNthTerm(50));
        }

    }
}
