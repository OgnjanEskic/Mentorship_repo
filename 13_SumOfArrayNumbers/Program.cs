using System;

namespace _13_SumOfArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result = 0;
            while(true)
            {
                Console.WriteLine("Enter a single digit number");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");
                if(number.ToString().Length == 1)
                {
                    break;
                }
            }
            for (int i = 0; i <= number; i++)
            {
                if (i <= number)
                {
                    Console.WriteLine(i);
                }
                result += i; 
            }
            Console.WriteLine($"The sum of all numbers between 0 and {number} is {result}");
        }
    }
}
