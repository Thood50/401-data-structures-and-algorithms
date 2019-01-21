using System;
using System.Collections.Generic;
using System.Text;
using Linked_List;
using ll_kth_from_end;
using LL_merge;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }

        public Node Rear { get; set; }

        public Queue (Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Adds a new node to end of queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue (int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Grabs front of queue and removes it from the queue
        /// </summary>
        /// <returns>returns what was originally the front of queue</returns>
        public Node Dequeue ()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Lets you look at the front of the queue
        /// </summary>
        /// <returns>returns whatever is at front of queue</returns>
        public Node Peek ()
        {
            return Front;
        }
    }
}
