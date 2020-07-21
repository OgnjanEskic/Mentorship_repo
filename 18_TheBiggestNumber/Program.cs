using System;

namespace _18_TheBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int theBiggestNumber = firstNumber;
            if(firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                theBiggestNumber = firstNumber;
            } else if(secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                theBiggestNumber = secondNumber;
            } else
            {
                theBiggestNumber = thirdNumber;
            }
            Console.WriteLine($"Thi largest number of three entered numbers is number {theBiggestNumber}.");
        }
    }
}
