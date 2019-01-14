using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.classes
{
    public class LList
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

        //includes
        public bool Includes(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //print
        public void Print()
        {
            Current = Head;
            while(Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }

}
