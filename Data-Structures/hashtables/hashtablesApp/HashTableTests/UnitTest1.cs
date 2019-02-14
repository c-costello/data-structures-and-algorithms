using System;
using Xunit;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanHashKey()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();
            
            Assert.Equal(22, hashtable.Hash("zeus"));
        }

        [Fact]
        public void CanAddKeyValue()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            hashtable.Add("zeus", "dog");

            Assert.Equal("dog", hashtable.Array[22].Value);
        }
        //Get Tests

        [Fact]
        public void CanGetKeyValue()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            hashtable.Add("zeus", "dog");
            Assert.Equal("dog", hashtable.Get("zeus"));
        }

        [Fact]
        public void ReturnsNullIfKeyDoesNotExist()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            Assert.Null(hashtable.Get("zeus"));

        }

        //Contains Tests
        [Fact]
        public void ContainsReturnsTrueIfKeyExists()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            hashtable.Add("zeus", "dog");

            Assert.True(hashtable.Contains("zeus"));
        }

        [Fact]
        public void ContainsReturnsFalseIfKeyDoesNotExist()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            Assert.False(hashtable.Contains("zeus"));
        }
    }
}
