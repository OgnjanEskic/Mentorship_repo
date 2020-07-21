using System;

namespace _15_SumOfFirstFiveNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int result = 0;
            while(number < 6)
            {
                result += number;
                number++;
            }
            Console.WriteLine(result);
        }
    }
}
