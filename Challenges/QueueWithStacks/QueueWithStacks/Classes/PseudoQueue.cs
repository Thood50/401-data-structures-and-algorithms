using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack Main { get; set; }
        public Stack Temp { get; set; }         

        /// <summary>
        /// Constructor for PseudoQueue
        /// </summary>
        public PseudoQueue()
        {
            Main = new Stack();
            Temp = new Stack();
        }

        /// <summary>
        /// Constructor for PseudoQueue on a already created stack
        /// </summary>
        /// <returns></returns>
        public PseudoQueue(Stack stack)
        {
            Main = stack;
            Temp = new Stack();
        }

        /// <summary>
        /// Returns the front of the queue
        /// </summary>
        /// <returns>Returns the top of main stack</returns>
        public Node Peek()
        {
            if (Temp.Top == null)
            {
                while(Main.Top != null)
                {
                    Temp.Push(Main.Pop().Value);
                }
                return Temp.Peek();
            }
            else
            {
                return Temp.Peek();
            }
        }

        /// <summary>
        /// Removes the front from the top of temp stack
        /// </summary>
        /// <returns> Returns what was front of queue or top of temp stack</returns>
        public Node Dequeue()
        {
            if (Temp.Top == null)
            {
                while(Main.Top != null)
                {
                    Temp.Push(Main.Pop().Value);
                }                
            }

            Node temp = Temp.Top;
            Temp.Top = Temp.Top.Next;
            temp.Next = null;
            return temp;            
        }

        /// <summary>
        /// Adds a new node with inputed value to end of queue or top of main stack
        /// </summary>
        /// <param name="val"></param>
        public void Enqueue(int val)
        {
            Node node = new Node(val);
            node.Next = Main.Top;
            Main.Top = node;
        }

    }
}
