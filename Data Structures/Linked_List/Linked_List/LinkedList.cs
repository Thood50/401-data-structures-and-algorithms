using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Adds a new node to front of the Linked list
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Node thing = new Node(value);
            thing.Next = Head;
            Head = thing;
        }

        /// <summary>
        /// Takes a value in and iterates over the linked list looking for this value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>returns true if found and false if not</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Iterates over the linked list and prints the value of each node
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }
}
