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
        /// creates a new node with the inputed value and addes it to the front of the LL
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Node thing = new Node(value);
            thing.Next = Head;
            Head = thing;
        }

        /// <summary>
        /// Takes a value and iterates over checking if the LL has a node with that value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>returns true if value is found false if not</returns>
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
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value} => null");
            
        }

        /// <summary>
        /// Iterates over the LL and adds a new node with inputed value at the end of the LL
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Current = Head;
            while (Current.Next!= null)
            {
                Current = Current.Next;
            }
            Node node = new Node(value);
            Current.Next = node;
        }

        /// <summary>
        /// Iterates over the LL and adds inputed newValue into a new node right before selected node value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }
            while (Current.Next != null)
            {                
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
            
        }

        /// <summary>
        /// Iterates over the LL and adds inputed newValue into a new node right after selected node value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Node node = new Node(newValue);
                node.Next = Current.Next;
                Current.Next = node;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                Node node = new Node(newValue);
                node.Next = Current.Next;
                Current.Next = node;
                return;
            }
        }

    }
}
