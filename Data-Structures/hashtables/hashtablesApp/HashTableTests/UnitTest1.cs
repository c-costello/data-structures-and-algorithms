using System;
using Xunit;

namespace HashTableTests
{
    public class UnitTest1
    {
        //Hash tests
        [Fact]
        public void CanHashKey()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();
            
            Assert.Equal(22, hashtable.Hash("zeus"));
        }
        [Fact]
        public void DifferentKeysReturnDifferentIndexes()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();
            Assert.True(hashtable.Hash("zeus") != hashtable.Hash("daisy"));
        }

        //Add tests
        [Fact]
        public void CanAddKeyValue()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable();

            hashtable.Add("zeus", "dog");

            Assert.Equal("dog", hashtable.Array[22].Value.Value);
        }

        [Fact]
        public void CanHandleCollisions()
        {
            hashtablesApp.Classes.Hashtable hashtable = new hashtablesApp.Classes.Hashtable(5);

            hashtable.Add("zeus", "dog");
            hashtable.Add("gill", "cat");
            //both have an index of zero
            Assert.Equal("catdog", hashtable.Get("gill")+hashtable.Get("zeus"));


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
