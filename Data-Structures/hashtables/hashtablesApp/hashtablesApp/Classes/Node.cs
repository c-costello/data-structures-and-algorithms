using System;
using System.Collections.Generic;
using System.Text;

namespace hashtablesApp.Classes
{
    public class Node 
    {
        //properties
        public KeyValuePair Value { get; set; }
        public Node Next { get; set; }

        //Constructors
        /// <summary>
        /// Creates a new node with a Value of a keyValuePair
        /// </summary>
        /// <param name="keyValuePair">KeyValuePair</param>
        public Node(KeyValuePair keyValuePair)
        {
            Value = keyValuePair;
        }

    }
}
