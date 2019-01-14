using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.classes
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        // insert
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

    }

}
