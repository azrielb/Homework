using System;
//Azriel Berger Classes
namespace ABClasses
{
    //This class was taken from http://blogs.microsoft.co.il/blogs/shlomo/archive/2008/11/19/eventargs-lt-t-gt.aspx, with some changes. 
    //This is a good idea! (see the link).
    class EventArgs<T> : EventArgs
    {
        public EventArgs(T data)
        {
            Data = data;
        }
        public readonly T Data;
    }

    class Checkings
    {
        //This functions takes a number, and return true only if the number is a valid israeli ID num.
        public static bool CheckIdNum(ulong idnum)
        {
            if (idnum == 0) return false;
            int sum = 0;
            for (; idnum > 0; idnum /= 100)
            {
                int num = (int)(idnum % 100);
                int lefter = (num / 10) * 2;
                sum += (num % 10) + lefter - (lefter > 9 ? 9 : 0);
            }
            return (sum % 10 == 0);
        }
    }
}
