using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class KeyValuePair
    {
        //Properties
        public string Key { get; set; }
        public string Value { get; set; }
        public string Pair { get; set; }
        public int Index { get; set; }


        //Constructors

        /// <summary>
        /// Creates new KeyValuePair given a key and a value
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">string</param>
        public KeyValuePair(string key, string value)
        {
            Key = key;
            Value = value;
            Pair = $"{key} : {value}";
        }
        /// <summary>
        /// Creates an empty key value pair
        /// </summary>
        public KeyValuePair()
        {

        }
    }
}
