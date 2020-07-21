using System;
using System.Runtime.ExceptionServices;
using _1_ZbirDvaBroja;

namespace _2_NumberGreaterThanZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            Calculation calculation = new Calculation();
            calculation.FirstNumber = Convert.ToDouble(Console.ReadLine());
            bool greaterOrNot = calculation.CheckForPositive(calculation.FirstNumber);
            Console.WriteLine($"Is entered number greater than zero? {greaterOrNot}!");
        }
    }
}
