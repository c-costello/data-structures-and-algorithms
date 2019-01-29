using System;
using Xunit;
using MultiBracketValidationApp;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsFalseIfBraketsAreEmpty()
        {
            Assert.False(Program.MultiBracketValidation(""));

        }

        [Fact]
        public void ReturnsTrueWhenBracketsMatch()
        {
            Assert.True(Program.MultiBracketValidation("{}[()]"));
        }

        [Fact]
        public void ReturnsFalseWhenWhereIsBraketsLeftOpen()
        {
            Assert.False(Program.MultiBracketValidation("[{]()"));
        }

        [Fact]
        public void ReturnsFalseWhenExtraClosingBracket()
        {
            Assert.False(Program.MultiBracketValidation("}"));
        }
    }
}
