using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class Hashtable
    {
        //Properties
        public Node[] Array {get; set;} 
        
        //Methods
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
            if (Array[index] == null)
            {
                Array[index] = new Node(keyValuePair);
            }
            if (Array[index] != null)
            {
                Node Current = Array[index];
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = new Node(keyValuePair);
            }
        }
        /// <summary>
        /// Given a Key, hashes the key, retreives the corresponding Value 
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string value</returns>
        public string Get(string key)
        {
            if (Contains(key) == false)
            {
                return null;
            }
            int index = Hash(key);
            KeyValuePair keyValuePair = new KeyValuePair();
            if (Array[index].Next == null)
            {
                keyValuePair = Array[index].Value;
            }
            if (Array[index].Next != null)
            {
                Node Current = Array[index];
                while (Current.Next != null)
                {
                    if (Current.Value.Key == key)
                    {
                        keyValuePair = Current.Value;
                    }
                    Current = Current.Next;
                }
                if (Current.Value.Key == key)
                {
                    keyValuePair = Current.Value;
                }
            }
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
            if (Array[index] == null)
            {
                return false;
            }
            if (Array[index].Next == null)
            {
                if(Array[index].Value.Key == key)
                {
                    return true;
                }
            }
            if (Array[index].Next != null)
            {
                Node Current = Array[index];
                while (Current.Next != null)
                {
                    if (Current.Value.Key == key)
                    {
                        return true;
                    }

                    Current = Current.Next;
                }
                if (Current.Value.Key == key)
                {
                    return true;
                }
            }
                return false;
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
            index = index % Array.Length;
            return index;
        }


        //Constructors
        /// <summary>
        /// Creates a hashtable of a specified length
        /// </summary>
        /// <param name="length">int</param>
        public Hashtable(int length)
        {
            Array = new Node[length];
        }
        /// <summary>
        /// Creates a hashtable of a default length, 599;
        /// </summary>
        public Hashtable()
        {
            Array = new Node[599];
        }
    }
}
