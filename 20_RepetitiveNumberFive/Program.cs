using System;

namespace _20_RepetitiveNumberFive
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = { 1, 6, 2, 5, 8, 5, 20, 12, 90, 5.8 };
            int counter =  0;
            for(int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                if(arrayOfNumbers[i] == 5)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Count of number five is {counter}.");
        }
    }
}
