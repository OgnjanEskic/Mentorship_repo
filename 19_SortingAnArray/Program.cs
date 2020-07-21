using System;

namespace _19_SortingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = { 3, 17, 1, 5, 32, 74, 2, 14 };
            int saveNumber;
            for(int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfInts.Length - 1; j++)
                {
                    if(arrayOfInts[j] < arrayOfInts[i])
                    {
                        saveNumber = arrayOfInts[i];
                        arrayOfInts[i] = arrayOfInts[j];
                        arrayOfInts[j] = saveNumber;
                    }
                }
            }
            for(int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                Console.WriteLine(arrayOfInts[i]);
            }
            
        }
    }
}
