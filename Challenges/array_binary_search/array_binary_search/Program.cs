using System;

namespace array_binary_search
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] testArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
                int testValueOne = 10;
                int testValueTwo = 3;

                Console.WriteLine("Beginning Test One");
                Console.WriteLine($"{BinarySearch(testArray, testValueOne)}");
                Console.WriteLine(" ");
                Console.WriteLine("Biginning Test Two");
                Console.WriteLine($"{BinarySearch(testArray, testValueTwo)}");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static int BinarySearch(int[] array, int value)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = 0;
            bool found = false;

            while (min <= max && found == false && mid != -1)
            {
                mid = ((min + max) / 2);
                if (array[mid] < value)
                {
                    min = mid + 1;
                }
                if (array[mid] > value)
                {
                    max = mid - 1;
                }
                if ( array[mid] == value)
                {
                    found = true;
                }
            }

            if (found == false)
            {
                return -1;
            }
            else
            {
                return mid;
            }
        }
        
    }
}
