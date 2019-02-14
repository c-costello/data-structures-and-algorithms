using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class Hashtable
    {
        public KeyValuePair[] Array {get; set;} 
        
        /// <summary>
        /// Given a key and value, creates a key value pair, hashes the key, and inserts the key into the Hashtable
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">string</param>
        public void Add(string key, string value)
        {
            KeyValuePair keyValuePair = new KeyValuePair(key, value);
            int index = Hash(key);
            keyValuePair.Index = index;
            Array[index] = keyValuePair;
        }
        /// <summary>
        /// Given a Key, hashes the key, retreives the corresponding Value 
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string value</returns>
        public string Get(string key)
        {
            int index = Hash(key);
            KeyValuePair keyValuePair = Array[index];
            return keyValuePair.Value;
        }
        /// <summary>
        /// Checks if hashtable contains that key;
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>bool</returns>
        public bool Contains(string key)
        {
            int index = Hash(key);
            if (Array[index].Key == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Hashes a string key to determine it's index in the hashtable.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>int index</returns>
        public int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += Convert.ToInt32(key[0]) * (i + 1);
            }
            index = index % 599;
            return index;
        }

        public Hashtable()
        {
            Array = new KeyValuePair[599];
        }
    }
}
