using System;

namespace _16_SwitchingNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true)
            {
                Console.WriteLine("Enter a natural number between 1 and 9");
                num = int.Parse(Console.ReadLine());
                if(num > 0 && num < 10)
                {
                    break;
                }
            }
            switch(num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(num);
                    break;
            }

        }
    }
}
