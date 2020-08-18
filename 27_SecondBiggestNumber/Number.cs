using System;
using System.Collections.Generic;
using System.Text;

namespace _27_SecondBiggestNumber
{
    class Number
    {
        private static int biggest;
        private static int second;
        private static int[] arrayOfints = new[] {1, 3, 4, 6, 8, 24, 11};
        public static void SecondBiggestNum()
        {
            biggest = arrayOfints[0];
            for (int i = 1; i < arrayOfints.Length; i++)
            {
                if (biggest < arrayOfints[i])
                {
                    second = biggest;
                    biggest = arrayOfints[i];
                }

                if (second < arrayOfints[i] && biggest != arrayOfints[i])
                {
                    second = arrayOfints[i];
                }
            }

            Console.WriteLine(second);
        }
    }
}
