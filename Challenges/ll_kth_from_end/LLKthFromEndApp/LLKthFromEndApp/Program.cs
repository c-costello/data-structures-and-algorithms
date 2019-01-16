using LinkedList.classes;
using System;

namespace LLKthFromEndApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        public static int FindKthFromEnd(int k, LList list)
        {
            int counter = 1;
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                counter++;
                list.Current = list.Current.Next;
            }
            int n = counter - k + 1;
            int newCounter = 0;
            list.Current = list.Head;
            while (list.Current.Next != null)
            {
                newCounter++;
                if (newCounter == n)
                {
                    return list.Current.Value;
                }
                list.Current = list.Current.Next;
            }
            return -1;

        }
    }
}
