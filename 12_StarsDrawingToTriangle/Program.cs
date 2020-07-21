using System;

namespace _12_StarsDrawingToTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                int j = i;
                while(j > 0)
                {
                    Console.Write("*");
                    j--;
                }
                Console.WriteLine();
            }
        }
    }
}
