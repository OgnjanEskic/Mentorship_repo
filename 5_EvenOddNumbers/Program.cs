using System;

namespace _5_EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string EvenOrOdd(int number) { 
                if(number % 2 == 0)
                {
                    return "paran";
                }
                else
                {
                    return "neparan";
                }
            }
            int number = int.Parse(Console.ReadLine());
            string result = EvenOrOdd(number);
            Console.WriteLine(result);
        }
    }
}
