using StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Animal 
    {
        public Pet Value { get; set; }
        public Animal Next { get; set; }
        
        public Animal(Pet pet)
        {
            Value = pet;
            Next = null;
        }
        
        public enum Pet { cat, dog}
    }

}
