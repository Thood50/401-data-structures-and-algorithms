using System;
using System.Collections.Generic;
using System.Text;
using Fifo_Animal_Shelter.Classes;

namespace Fifo_Animal_Shelter.Classes
{
    public class AnimalShelter
    {
        public Queue Cats { get; set; }
        public Queue Dogs { get; set; }
        public int SerialNumber = 0;

        /// <summary>
        /// Adds a Dog to the Dog queue or Cat to Cat queue
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>true if successful add else returns false</returns>
        public bool Enqueue (Animal animal)
        {
            if (animal is Dog)
            {               
                Dogs.Enqueue(animal, SerialNumber);
                SerialNumber++;
                return true;
            }
            if (animal is Cat)
            {
                Cats.Enqueue(animal, SerialNumber);
                SerialNumber++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Takes a Dog or Cat depending on user input
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>Returns selected animal or null if not possible</returns>
        public Animal Dequeue (string animal)
        {
            if (animal is "dog")
            {
                ShelterNode dog = Dogs.Dequeue();
                return dog.Obj;
            }
            if (animal is "cat")
            {
                ShelterNode cat = Cats.Dequeue();
                return cat.Obj;
            }
            return null;
        }

        /// <summary>
        /// Gives away whichever animal has been in the shelter longest to user with no preference
        /// </summary>
        /// <returns>returns null if no animals in shelter, else returns longest animal in shelter</returns>
        public Animal Dequeue()
        {
            if (Dogs.Peek() == null && Cats.Peek() == null)
            {
                return null;
            }

            if (Dogs.Peek() != null && Cats.Peek() == null)
            {
                return Dogs.Dequeue().Obj;
            }

            if (Dogs.Peek() == null && Cats.Peek() != null)
            {
                return Cats.Dequeue().Obj;
            }

            else
            {
                if (Dogs.Peek().SerialNumber < Cats.Peek().SerialNumber)
                {
                    return Dogs.Dequeue().Obj;
                }
                else
                {
                    return Cats.Dequeue().Obj;
                }
            }
        }
    }
}
