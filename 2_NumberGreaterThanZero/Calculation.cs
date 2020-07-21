using _1_ZbirDvaBroja;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_NumberGreaterThanZero
{
    class Calculation : Summation
    {
        public bool CheckForPositive(double number)
        {
            if(number >= 0)
            {
                return true;
            }
            else 
            return false;
        }
    }
}
