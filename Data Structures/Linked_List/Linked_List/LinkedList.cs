﻿using System;
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
