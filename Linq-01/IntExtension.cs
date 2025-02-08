using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_01
{
    internal static class IntExtension
    {
        public static int Reverse(this int num) //Extension method 
        {
            int ReversedNumber = 0;
            int LastDigit; 
            while (num > 0)
            {
                LastDigit = num % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                num /= 10;
            }  
           return ReversedNumber; 
        }
        public static long Reverse(this long num) //Extension method 
        {
            long ReversedNumber = 0;
            long LastDigit;
            while (num > 0)
            {
                LastDigit = num % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                num /= 10;
            }
            return ReversedNumber;
        }
        // 12345
        // 12345 % 10 ==> last (digit) number ==> 5
        // 12345 / 10 ==> 1234
        // 1234  % 10 ==> 4
        // 1234 /10  ==> 123
        // 123 % 10 ==> 3
        // 123 /10 ==> 12
        // 12 % 10 ==> 2
        // 12 / 10 ==> 1
        // 1 % 10 ==> 1 
        //ReversedNumber ==> 54321
    }
}
