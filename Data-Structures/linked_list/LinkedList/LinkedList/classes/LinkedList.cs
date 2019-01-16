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
            if (Head == null)
            {
                Console.WriteLine("There is nothing in this List");
            } 
            else
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

        //append
        public void Append(int value)
        {
            if (Head == null)
            {
                Insert(value);
            }
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node newNode = new Node(value);
            Current.Next = newNode;
        }

        //insert before
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            while (Current.Next != null )
            {
                if (Current.Next.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
            
        }


        //insert after
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }

        }

    }    

}
