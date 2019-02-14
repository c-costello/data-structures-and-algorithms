using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class KeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Pair { get; set; }
        public int Index { get; set; }

        public KeyValuePair(string key, string value)
        {
            Key = key;
            Value = value;
            Pair = $"{key} : {value}";
        }
    }
}
