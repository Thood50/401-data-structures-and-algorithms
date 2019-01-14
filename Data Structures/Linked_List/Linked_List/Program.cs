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
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
