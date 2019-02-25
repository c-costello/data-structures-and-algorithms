using System;
using UniqueCharacterApp;
using Xunit;

namespace NoDuplicatesTest
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnFalseIfThereAreDuplicateCharacters()
        {
            Assert.False(Program.NoDuplicates("This string has repeat characters"));
        }

        [Fact]
        public void WillReturnTrueIfThereAreNoDuplcateCharacters()
        {
            Assert.True(Program.NoDuplicates("no duplicates"));
        }

        [Fact]
        public void WillReturnTrueIfStringIsEmpty()
        {
            Assert.True(Program.NoDuplicates(""));
        }
    }
}
