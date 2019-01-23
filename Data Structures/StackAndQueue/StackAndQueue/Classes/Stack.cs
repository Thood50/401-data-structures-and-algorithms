using System;
using System.Collections.Generic;
using System.Text;
using Linked_List;
using ll_kth_from_end;
using LL_merge;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Adds new node to top of stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes top node from stack
        /// </summary>
        /// <returns>returns the node that was on top of stack</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Allows you to view top of stack
        /// </summary>
        /// <returns>returns the node at top of stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
