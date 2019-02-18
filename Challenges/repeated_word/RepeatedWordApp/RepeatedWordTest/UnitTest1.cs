using System;
using Xunit;
using RepeatedWordApp;

namespace RepeatedWordTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsRepeatedWords()
        {
            string str = "cat cat";
            Assert.Equal("cat", Program.RepeatedWord(str));
        }

        [Fact]
        public void ReturnsRepeatedWordOfDifferentCases()
        {
            string str = "Cat cat";
            Assert.Equal("cat", Program.RepeatedWord(str));
        }

        [Fact]
        public void ReturnsRepeatedWordWithPunctiation()
        {
            string str = "cat. cat,";
            Assert.Equal("cat", Program.RepeatedWord(str));
        }

        [Fact]
        public void ReturnsFirstRepeatedWOrd()
        {
            string str = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            Assert.Equal("summer", Program.RepeatedWord(str));
        }

        [Fact]
        public void ReturnsEmptyStringIfNoRepeatedWords()
        {
            string str = "cat in the hat";
            Assert.Equal("", Program.RepeatedWord(str));
        }

        [Fact]
        public void ReturnsEmptyStringIfGivenStringIsEmpty()
        {
            string str = "";
            Assert.Equal("", Program.RepeatedWord(str));
        }
    }
}
