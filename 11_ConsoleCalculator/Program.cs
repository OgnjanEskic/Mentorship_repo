using System;

namespace _11_ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number for calculation!");
            double firstNum = Math.Round(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Enter the second number for calculation!");
            double secondNum = Math.Round(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Enter one of the operators for calculation. Operators are +, -, * or / .");
            char operatorForCalc = char.Parse(Console.ReadLine());
            switch(operatorForCalc)
            {
                case '*':
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case '/':
                    Console.WriteLine(firstNum / secondNum);
                    break;
                case '+':
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case '-':
                    Console.WriteLine(firstNum - secondNum);
                    break;
            }
            
        }
    }
}
