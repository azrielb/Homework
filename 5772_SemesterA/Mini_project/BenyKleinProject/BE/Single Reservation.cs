using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    //הזמנת יחיד
    public class Single_Reservation : Reservation
    {
        /// <summary>
        /// חדר בודד
        /// </summary>
        public Room reservation_room { get; set; }               

        /// <summary>
        /// חישוב מחיר
        /// </summary>
        public override int Calculate_Price                     
        {
            get { return reservation_room.Cost * Number_of_days; }

        }

        

        public override string ToString()
        {
            return Reservation_Number.ToString();
        }
    }
}
