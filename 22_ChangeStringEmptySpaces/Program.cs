using System;

namespace _22_ChangeStringEmptySpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Good morning! Today is Monday.";
            string myNewString = myString.Replace(" ", "_");
            Console.WriteLine(myNewString);
        }
    }
}
