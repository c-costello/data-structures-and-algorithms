using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class Node 
    {
        public KeyValuePair Value { get; set; }
        public Node Next { get; set; }

        public Node(KeyValuePair keyValuePair)
        {
            Value = keyValuePair;
        }

    }
}
