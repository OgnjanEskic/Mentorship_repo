using System;
using System.Threading.Channels;

namespace _29_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 0;
            int pyramidBase = 0;
            int spacesLeft, spacesRight = 0;
            int counterOfNumbersInSingleRow = 0;
            while (true)
            {
                Console.WriteLine("Enter the number for making a pyramid");
                numberOfRows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (numberOfRows > 0)
                {
                    break;
                }
            }

            if (numberOfRows == 1)
            {
                pyramidBase = 1;
            }
            else
            {
                pyramidBase = numberOfRows + (numberOfRows - 1);
            }
            spacesRight = spacesLeft = (pyramidBase - 1) / 2;

            for (int i = 1; i <= numberOfRows; i++)
            {
                counterOfNumbersInSingleRow = pyramidBase - spacesRight - spacesLeft;
                for (int k = 0; k < spacesLeft; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= counterOfNumbersInSingleRow; j++)
                {
                    Console.Write(j);
                }
                for (int k = 0; k < spacesRight; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spacesRight--;
                spacesLeft--;
            }
        }
    }
}
