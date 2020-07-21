using System;
using System.Resources;

namespace _8_RemainingAfterDividing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int Remaining(int num1, int num2)
            {
                int remaining = num1 % num2;
                return remaining;
            }
            int result = Remaining(firstNumber, secondNumber);
            Console.WriteLine(result);
        }
    }
}
