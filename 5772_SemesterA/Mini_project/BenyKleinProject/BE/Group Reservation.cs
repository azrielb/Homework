using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{   //מחלקה להזמנה קבוצתית
    public class Group_Reservation : Reservation
    {
        /// <summary>
        /// רשימת חדרים
        /// </summary>
        public List<Room> reservation_rooms { get; set; } 
        /// <summary>
        /// /אחוזי ההנחה להזמנה זו
        /// </summary>
        public int OrderDiscount { get; set; }                     
  
        /// <summary>
        /// חישוב מחיר
        /// </summary>
        public override int Calculate_Price                        
        {
            get
            {
                int sum = new int();

                foreach (var item in reservation_rooms)             
                {
                    sum += item.Cost * Number_of_days;
                }
                double s = Convert.ToDouble(sum) - Convert.ToDouble(sum) * Convert.ToDouble(OrderDiscount) / Convert.ToDouble(100);
                return Convert.ToInt32(s);
            }
        }

        public override string ToString()
        {
            return Reservation_Number.ToString();
        }

        /// <summary>
        /// בנאי
        /// מאתחל רשימת חדרים
        /// </summary>
        public Group_Reservation()
        {
            reservation_rooms = new List<Room>();
        }
    }
}
