using System;

namespace _10_CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celsius value to calculate in Farenheit");
            double celsius = Math.Round(double.Parse(Console.ReadLine()), 1);
            double farenheit = Math.Round(9 * celsius / 5 + 32, 1);
            Console.WriteLine($"{celsius} of Celsius are equally {farenheit} of Farenheit");
        }
    }
}