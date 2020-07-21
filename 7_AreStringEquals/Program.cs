using System;

namespace _7_AreStringEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            bool result = firstString.Equals(secondString);
            if(result == true)
            {
                Console.WriteLine("Strings are equal.");
            }
            else
            {
                Console.WriteLine("Strings are not equal.");
            }
        }
    }
}
