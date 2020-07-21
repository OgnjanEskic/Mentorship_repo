using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_LastElementFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 22, 12, 24, 17};
            int LastElement(List<int> list)
            {
                int numberOfElements = list.Count;
                int lastNumber = list.ElementAt(numberOfElements -1);
                return lastNumber;
            }
            int lastNumberOfAList = LastElement(list);
            Console.WriteLine(lastNumberOfAList);
        }
    }
}
