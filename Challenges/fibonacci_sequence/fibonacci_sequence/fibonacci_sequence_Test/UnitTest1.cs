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
    }
}
