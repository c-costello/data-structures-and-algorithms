using System;
using LinkedList.classes;

namespace LLRemoveDuplicatesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList list = new LList();
            list.Head = new Node(1);
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(3);
            list.Append(2);
            list.Append(4);
            list.Print();
            RemoveDuplicatens(list);
            list.Print();
            LList checkList = new LList();
            checkList.Append(1);
            checkList.Append(2);
            checkList.Append(3);
            checkList.Append(4);
            checkList.Print();
        }
        public static LList RemoveDuplicatens(LList list)
        {
            Node current = list.Head;
            while (current.Next != null)
            {
                Node current2 = list.Head;
                while(current.Next != current2)
                {
                    if (current.Next.Value == current2.Value)
                    {
                        current.Next = current.Next.Next;
                    }
                    current2 = current2.Next;
                }
                current = current.Next;
            }
            return list;
        }
    }
}
