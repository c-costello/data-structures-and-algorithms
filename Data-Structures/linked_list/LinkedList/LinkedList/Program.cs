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

            list.Print();
            return list;


        }

        
    }
}
