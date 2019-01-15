using System;

namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MakeLL();
        }

        public static void MakeLL()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(16);
            list.Print();
            list.Append(3);
            list.Append(5);
            list.Append(7);
            list.Append(9);
            list.Print();
            list.InsertBefore(5, 15);
            list.InsertBefore(8, 20);
            list.Print();
            list.InsertAfter(3, 30);
            list.InsertAfter(9, 90);
            list.Print();            
            Console.ReadLine();

        }
    }
}
