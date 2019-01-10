using System;

namespace InsertArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 4, 5 };
            int testValue = 3;
            ArrayInsertShift(testArray, testValue);
        }

        static int[] ArrayInsertShift(int[] input, int value)
        {
            int[] oldArray = input;
            int newValue = value;
            int[] newArray = new int[oldArray.Length + 1];
            int middleIndex = oldArray.Length / 2;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < middleIndex)
                {
                    newArray[i] = oldArray[i];
                }
                if (i == middleIndex)
                {
                    newArray[i] = newValue;
                }
                if (i > middleIndex)
                {
                    newArray[i] = oldArray[i - 1];
                }
            }

            Console.WriteLine($"The New Value is {newValue}");

            for (int i = 0; i < oldArray.Length; i++)
            {
                Console.WriteLine($"The old Array is {oldArray[i]}");
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine($"The new Array is {newArray[i]}");
            }

            return newArray;
        }
    }
}
