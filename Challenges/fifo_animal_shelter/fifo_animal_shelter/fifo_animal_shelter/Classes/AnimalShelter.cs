using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public AnimalShelter()
        {
            Front = null;
            Rear = null;
        }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        public void Enqueue(Animal pet)
        {
            Animal animal = pet;
            if (Front == null)
            {
                Front = animal;
                Rear = animal;
            }
            Rear.Next = animal;
            Rear = animal;
        }

        public Animal Dequeue(Animal pref)
        {
            if (Front == null)
            {
                Console.WriteLine("Your Shelter is Empty!! There's Nothing to Adopt!");
                return null;
            }
            AnimalShelter newShelter = new AnimalShelter();
            while (Front != pref)
            {
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;
                newShelter.Enqueue(temp);
                               
            }

            Animal adopted = Front;
            Front = Front.Next;
            adopted.Next = null;
            //newShelter.Rear.Next = Front;

            return adopted;

        }
    }
}
