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
            LList myList = new LList();
            myList.Append(4);

            myList.Print();

            return myList;


        }

        
    }
}
