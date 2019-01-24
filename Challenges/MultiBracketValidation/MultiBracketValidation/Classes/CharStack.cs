using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class CharStack
    {
        public CharNode Top { get; set; }

        public CharStack()
        {
            Top = null;
        }

        public CharStack(CharNode node)
        {
            Top = node;
        }

        /// <summary>
        /// Adds new node to top of stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(char value)
        {
            CharNode node = new CharNode(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes top node from stack
        /// </summary>
        /// <returns>returns the node that was on top of stack</returns>
        public CharNode Pop()
        {
            CharNode temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Allows you to view top of stack
        /// </summary>
        /// <returns>returns the node at top of stack</returns>
        public CharNode Peek()
        {
            return Top;
        }
    }
}
