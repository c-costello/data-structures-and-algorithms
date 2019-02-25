using System;
using System.Collections.Generic;
using System.Text;

namespace graphsApp.Classes
{
    class Node<T>
    {
        public T Value { get; set; }
        public bool Visted { get; set; }
        public int Weight { get; set; }

        public Node(T value)
        {
            Value = value;
            Visted = false;
            Weight = 0;
        }
            
    }
}
