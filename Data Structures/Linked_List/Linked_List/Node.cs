﻿using System;
using System.Collections.Generic;
using System.Text;
using Linked_List;

namespace Linked_List
{
    public class Node
    {
        public int Value { get; set; }
        
        public Node Next { get; set; }

        /// <summary>
        /// The constructor for the a Node
        /// </summary>
        /// <param name="value"></param>
        public Node (int value)
        {
            Value = value;
        }
    }
}
