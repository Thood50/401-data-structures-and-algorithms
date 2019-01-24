using System;
using System.Collections.Generic;
using System.Text;

namespace Fifo_Animal_Shelter.Classes
{
    public class ShelterNode
    {
        public Animal Obj { get; set; }
        public int SerialNumber { get; set; }
        public ShelterNode Next { get; set; }
        public ShelterNode Head { get; set; }

        public ShelterNode(Animal obj, int num)
        {
            Obj = obj;
            SerialNumber = num;
            Next = null;
        }
    }
}
