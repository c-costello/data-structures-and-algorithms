using hashtablesApp.Classes;
using System;

namespace hashtablesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(5);

            Console.WriteLine(hashtable.Hash("zeus"));
            Console.WriteLine(hashtable.Hash("daisy"));
            Console.ReadLine();

        }
    }
}
