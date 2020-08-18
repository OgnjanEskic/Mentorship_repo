using System;
using System.Collections.Generic;
using System.Text;

namespace _25_CountLetters
{
    class RemoveLetters
    {
        public static void AddRemoveLettersFromString(string str)
        {
            List<char> charList = new List<char>();
            int numOfLetters = 1;
            str = str.ToLower();

            foreach (var character in str)
            {
                charList.Add(character);
            }

            int countOfChars = charList.Count;

            for (int i = 0; i < countOfChars; i++)
            {
                if (charList[i] == ' ')
                {
                    continue;
                }
                for (int j = i+1; j < countOfChars; j++)
                {
                    if (charList[i] == charList[j])
                    {
                        numOfLetters++;
                        charList.RemoveAt(j);
                    }
                    countOfChars = charList.Count;
                }

                Console.WriteLine(charList[i] + "- " + numOfLetters);
                numOfLetters = 1;
            }
        }
    }
}
