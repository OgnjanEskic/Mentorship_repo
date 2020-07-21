using System;

namespace _1_ZbirDvaBroja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number to calculate addition of two numbers:");
            Summation summation = new Summation();
            summation.FirstNumber = summation.StoreNumber();
            Console.WriteLine("Enter the second number to calculate addition of two numbers:");
            summation.SecondNumber = summation.StoreNumber();
            Console.WriteLine($"Sumation of two given numbers is: {summation.FirstNumber + summation.SecondNumber}");
        }
    }
}
