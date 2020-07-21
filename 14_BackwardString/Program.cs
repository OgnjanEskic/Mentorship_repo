using System;
using System.Linq;

namespace _14_BackwardString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            string inputString = Console.ReadLine();
            string backwardString;
            for(int i = inputString.Length; i > 0; i--)
            {
                Console.Write(inputString[i-1]);
            }
        }
    }
}
