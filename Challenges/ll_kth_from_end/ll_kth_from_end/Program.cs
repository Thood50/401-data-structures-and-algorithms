using Linked_List;
using System;

namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList ll = new LinkedList();
            ll.Insert(1);
            ll.Insert(10);
            ll.Insert(100);
            ll.Insert(1000);
            ll.Print();
            Console.WriteLine(LLFromEnd(1,ll));
            Console.ReadLine();
        }

        public static int LLFromEnd(int num, LinkedList list)
        {
            int count = 0;
            Node current = list.Head;

            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }

            if (count < num)
            {
                return -1;
            }

            int length = count - num;
            count = 0;
            current = list.Head;

            while (count < length)
            {
                count++;
                current = current.Next;
            }

            return current.Value;
        }
    }
}
