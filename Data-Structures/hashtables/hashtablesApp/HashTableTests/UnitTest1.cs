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

        [Fact]
        public void CanGetKeyValue()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            hashtable.Add("zeus", "dog");
            Assert.Equal("dog", hashtable.Get("zeus"));
        }
    }
}
