using System;

namespace _21_SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int swapStoredNumber;
            Console.WriteLine("For now x = 5 and y = 10.");
            void Swap(int num1, int num2)
            {
                swapStoredNumber = num1;
                num1 = num2;
                num2 = swapStoredNumber;
                Console.WriteLine($"And now x = {num1} and y = {num2}.");
            }
            Swap(x, y);
        }
    }
}
