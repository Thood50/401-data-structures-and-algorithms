using System;
using System.Collections.Generic;
using System.Text;

namespace Fifo_Animal_Shelter.Classes
{
    public class Queue
    {
        public ShelterNode Front { get; set; }

        public ShelterNode Rear { get; set; }

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public Queue(ShelterNode node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Adds a new node to end of queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(Animal animal, int num)
        {
            ShelterNode node = new ShelterNode(animal, num);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Grabs front of queue and removes it from the queue
        /// </summary>
        /// <returns>returns what was originally the front of queue</returns>
        public ShelterNode Dequeue()
        {
            ShelterNode temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Lets you look at the front of the queue
        /// </summary>
        /// <returns>returns whatever is at front of queue</returns>
        public ShelterNode Peek()
        {
            return Front;
        }
    }
}
