using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClasses
{
    static class MyFunctions
    {
        public static int StringToInt(string mystring) // This function converts string to int, without run-time errors...
        {
            if (string.IsNullOrWhiteSpace(mystring))
            {
                return 0;
            }
            else
            {
                mystring = mystring.Trim();
            }
            int myint = 0;
            for (int index = (mystring[0] == '-') ? 1 : 0; index < mystring.Length; ++index)
                if (char.IsNumber(mystring, index))
                    myint = myint * 10 + CharToInt(mystring[index]);
                else
                {
                    if (mystring[index] == '.' && CharToInt(mystring[index + 1]) >= 5)
                        ++myint;
                    break;
                }
            if (mystring[0] == '-') myint *= -1;
            return myint;
        }
        public static int CharToInt(char c)
        {
            int myint = (int)c - (int)'0';
            return (0 < myint && myint < 10) ? myint : 0;
        }
    }
}
