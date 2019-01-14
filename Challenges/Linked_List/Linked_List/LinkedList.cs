using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node thing = new Node(value);
            thing.Next = Head;
            Head = thing;
        }

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

        public void Print(Node head)
        {
            Current = head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }
}
