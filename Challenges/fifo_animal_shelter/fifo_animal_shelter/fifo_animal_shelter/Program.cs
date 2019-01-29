using fifo_animal_shelter.Classes;
using StacksAndQueues;
using System;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FifoAnimalShelter();
        }
        public static void FifoAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal(Animal.Pet.cat);
            Animal cat1 = new Animal(Animal.Pet.cat);
            Animal cat2 = new Animal(Animal.Pet.cat);
            Animal dog = new Animal(Animal.Pet.dog);
            Animal dog1 = new Animal(Animal.Pet.dog);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            shelter.Enqueue(dog1);
            shelter.Enqueue(cat1);
            shelter.Enqueue(cat2);

            Console.WriteLine(shelter.Dequeue(cat).Value);
            Console.WriteLine(shelter.Dequeue(dog).Value);

            Console.WriteLine(shelter.Front.Value);
            Console.WriteLine(shelter.Front.Next.Value);
            Console.WriteLine(shelter.Front.Next.Next.Value);


        }
    }
}
