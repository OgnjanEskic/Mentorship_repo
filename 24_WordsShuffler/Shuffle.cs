using System;
using System.Collections.Generic;
using System.Text;

namespace _24_WordsShuffler
{
    class Shuffle
    {
        private static List<string> inputArray = new List<string> { "Endava", "C#", "Test", "Automation", "Trening" };
        private static Random random = new Random();

        public static void ArrayReader()
        {
            for (int i = 0; i < inputArray.Count; i++)
            {
                Console.Write(inputArray[i]);
                if (i != inputArray.Count - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static void ArrayShuffler()
        {
            while (inputArray.Count > 0)
            {
                int arrayElement = random.Next(0, inputArray.Count - 1);
                Console.Write(inputArray[arrayElement]);
                if (inputArray.Count != 1)
                {
                    Console.Write(" ");
                }
                inputArray.RemoveAt(arrayElement);
            }
        }
    }
}
