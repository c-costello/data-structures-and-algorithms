using System;
using Xunit;
using fifo_animal_shelter.Classes;

namespace FifoTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            Assert.NotNull(animalShelter);
        }
        
        //Enquequeing
        [Fact]
        public void CanEnqueueIntoEmptyAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal cat = new Animal(Animal.Pet.cat);
            shelter.Enqueue(cat);

            Assert.Equal(Animal.Pet.cat, shelter.Front.Value);
        }

        [Fact]
        public void CanEnqueueIntoAnOccupiedAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            Animal dog = new Animal(Animal.Pet.dog);
            Animal cat = new Animal(Animal.Pet.cat);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);

            Assert.Equal(Animal.Pet.dog, shelter.Rear.Value);
        }

        [Fact]
        public void EnquingLinksAnimalsTogether()
        {

            AnimalShelter shelter = new AnimalShelter();
            Animal dog = new Animal(Animal.Pet.dog);
            Animal cat = new Animal(Animal.Pet.cat);
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);

            Assert.Equal(Animal.Pet.dog, shelter.Front.Next.Value);
        }   


        //Dequeueing
        [Fact]
        public void DequeueingAnEmptyObjectReturnsNull()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.Null(shelter.Dequeue(Animal.Pet.cat));
        }

        [Fact]
        public void CanDequeueFrontItemIfPref()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(Animal.Pet.cat);
            shelter.Enqueue(Animal.Pet.dog);

            Assert.Equal(Animal.Pet.cat, shelter.Dequeue(Animal.Pet.cat).Value);
        }

        [Fact]
        public void CanGetAnimalNotOnFront()
        {
            
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(Animal.Pet.cat);
            shelter.Enqueue(Animal.Pet.dog);

            Assert.Equal(Animal.Pet.dog, shelter.Dequeue(Animal.Pet.dog).Value);

        }
    }
}
