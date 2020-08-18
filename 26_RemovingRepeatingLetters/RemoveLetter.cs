using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace _26_RemovingRepeatingLetters
{
    class RemoveLetter
    {
        public static void LetterRemover(string str)
        {
            string converted = "";
            List<char> uniqueChars = new List<char>();
            foreach (var character in str)
            {
                if (!uniqueChars.Contains(character))
                {
                    uniqueChars.Add(character);
                    converted += character.ToString();
                }
            }
            Console.WriteLine(converted);
        }
    }
}
