using System;
using Linked_List;

namespace LL_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


           
            LinkedList LL1 = new LinkedList();
            LL1.Insert(100);
            LL1.Insert(200);
            LL1.Insert(300);
            LL1.Insert(400);
            LL1.Print();
            

            
            LinkedList LL2 = new LinkedList();
            LL2.Insert(10);
            LL2.Insert(20);          
            LL2.Print();            
          
            LinkedList head = MergeLL(LL1, LL2);
            head.Print();            
            Console.WriteLine();
            Console.ReadLine();
        }

        public static LinkedList MergeLL(LinkedList LL1, LinkedList LL2)
        {
            Node H1 = LL1.Head;
            Node H2 = LL2.Head;
            Node C1 = LL1.Head;
            Node C2 = LL2.Head;

            while ((C1.Next != null) && (C2.Next != null))
            {
                
                H1 = C1.Next;                
                C1.Next = C2;
                H2 = C2.Next;
                C2.Next = H1;
                C1 = H1;
                C2 = H2;
            }

            if ((C2.Next == null) && (C1.Next != null))
            {
                C2.Next = C1.Next;
                C1.Next = C2;
            }
            else
            {
                C1.Next = C2;
            }

            return LL1;
        }
    }
}
