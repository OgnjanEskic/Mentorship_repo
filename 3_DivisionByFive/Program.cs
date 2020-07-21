using System;

namespace _3_DivisionByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool CheckDivisionWithFive(int number) {
                if (number % 5 == 0)
                {
                    Console.WriteLine("True");
                    return true;
                }
                else
                {
                    Console.WriteLine("False");
                    return false;
                }
            }
            CheckDivisionWithFive(number);
        }
    }
}
