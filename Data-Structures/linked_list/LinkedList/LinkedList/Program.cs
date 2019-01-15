using System;
using LinkedList.classes;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateAList();
        }

        public static LList CreateAList()
        {

            LList list = new LList();
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.InsertAfter(5, 7);
            int expectedValue = 7;
            int actualValue = 0;
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                Console.WriteLine(list.Current.Value);
                if (list.Current.Value == 5)
                {
                    actualValue = list.Current.Next.Value;
                    //break;
                }
                list.Current = list.Current.Next;
            }
            int actual = actualValue;
            Console.WriteLine(actual);
            Console.WriteLine(list);

            return list;


        }

        
    }
}
