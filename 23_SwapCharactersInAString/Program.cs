using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Dynamic;
using System.Linq;

namespace _23_SwapCharactersInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string StringSwapper(string myStr)
            {
                char firstLetter = myStr[0];
                char lastLetter = myStr[myStr.Length -1];
                string middleStr = myStr.Substring(1, myStr.Length - 2);
                string myNewString = lastLetter.ToString() + middleStr + firstLetter.ToString();
                return myNewString;
            }
            Console.WriteLine(StringSwapper(str));
        }
    }
}
