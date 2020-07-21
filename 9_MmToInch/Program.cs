using System;

namespace _9_MmToInch
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INCH = 3.14;
            int length = 297;
            int width = 210;
            double lengthInch = Math.Round(length / INCH /10, 2);
            double widthInch = Math.Round(width / INCH / 10, 2);
            Console.WriteLine("Length of A4 paper in inches is {0} and a width of A4 paper in inches is {1}", lengthInch, widthInch);
        }
    }
}
