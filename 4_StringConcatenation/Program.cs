using System;

namespace _4_StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();
            string Concatenation(string firstName, string lastname)
            {
                string fullname = lastname + ", " + firstName;
                return fullname;
            }
            string fullname = Concatenation(name, surname);
            Console.WriteLine(fullname);
        }
    }
}
