using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Inserts a new node with the given value into the beginning of the link list
        /// </summary>
        /// <param name="value">an integer value that will be the value of the new node</param>
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// Takes in a value and checks if any nodes in the linked list mave that value, returns a boolean
        /// if the value is included, returns true, else returns false
        /// </summary>
        /// <param name="value">int value that is being check against the link list</param>
        /// <returns>bool</returns>
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

        /// <summary>
        /// Prints out each node value in the LinkList
        /// </summary>
        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("There is nothing in this List");
            } 
            else
            {
                Current = Head;
                Console.Write("HEAD");
                while(Current.Next != null)
                {
                    Console.Write($" --> {Current.Value}");
                    Current = Current.Next;
                }
                Console.Write($" --> {Current.Value}");
                Console.WriteLine(" --> X>");
                
            }
        }

        /// <summary>
        /// creates a node with the given value and attaches it to the end of the link list
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// creates and inserts a new node of a given newValue BEFORE a given value
        /// </summary>
        /// <param name="value">the value of the node the new node will be inserted before</param>
        /// <param name="newValue">the value of the node being created and attached</param>
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


        /// <summary>
        /// creates and inserts a new node of a given newValue AFTER a given value
        /// </summary>
        /// <param name="value">the value of the node the new node will be inserted before</param>
        /// <param name="newValue">the value of the node being created and attached</param>
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
