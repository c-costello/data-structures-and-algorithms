using queue_with_stacks.Classes;
using System;

namespace queue_with_stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PsuedoQueue psuedoQueue = new PsuedoQueue();
            //psuedoQueue.Enqueue(5);
            psuedoQueue.Enqueue(7);
            psuedoQueue.Enqueue(9);

            Console.WriteLine("First In " + psuedoQueue.Front.Value);
            Console.WriteLine(psuedoQueue.Front.Next.Value);
            Console.WriteLine("Last in" + psuedoQueue.Top.Next.Next.Value);
            Console.WriteLine("Last in" + psuedoQueue.Rear.Value);

            Console.WriteLine("First Out" + psuedoQueue.Dequeue().Value);
            Console.WriteLine("Next" + psuedoQueue.Front.Value);

        }
    }
}
