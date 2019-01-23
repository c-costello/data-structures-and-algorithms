using queue_with_stacks.Classes;
using System;

namespace queue_with_stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PsuedoQueue psuedoQueue = new PsuedoQueue(5);
            psuedoQueue.Enqueue(7);
            psuedoQueue.Enqueue(9);

            Console.WriteLine("First In " + psuedoQueue.Top.Value);
            Console.WriteLine(psuedoQueue.Top.Next.Value);
            Console.WriteLine("Last in" + psuedoQueue.Top.Next.Next.Value);

            Console.WriteLine("First Out" + psuedoQueue.Dequeue().Value);
            Console.WriteLine("Next" + psuedoQueue.Top.Value);

        }
    }
}
