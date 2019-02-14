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
            Console.WriteLine(hashtable.Hash("gill"));
            hashtable.Add("zeus", "dog");
            hashtable.Add("gill", "cat");
            Console.WriteLine(hashtable.Array[0].Next.Next.Value.Value);
            Console.WriteLine(hashtable.Get("gill"));
            Console.WriteLine(hashtable.Get("zeus"));

            Console.ReadLine();

        }
    }
}
