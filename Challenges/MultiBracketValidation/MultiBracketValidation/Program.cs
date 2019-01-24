using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        /// <summary>
        /// This method takes in a string and checks for proper Bracket notation
        /// </summary>
        /// <param name="str"></param>
        /// <returns>returns false if proper bracket notation is not met, return true if it has been met</returns>
        public static bool MBV(string str)
        {
            CharStack stack = new CharStack();
            foreach (char c in str)
            {
                string check = c.ToString();
                if (check == "(" || check == "[" || check == "{")
                {
                    stack.Push(c);
                }
                if (check == ")")
                {
                    if (stack.Pop().Value.ToString() != "(")
                    {
                        return false;
                    }
                }
                if (check == "]")
                {
                    if (stack.Pop().Value.ToString() != "[")
                    {
                        return false;
                    }
                }
                if (check == "}")
                {
                    if (stack.Pop().Value.ToString() != "{")
                    {
                        return false;
                    }
                }
            }
            if (stack.Peek() != null)
            {
                return false;
            }
            return true;
        }
    }
}
