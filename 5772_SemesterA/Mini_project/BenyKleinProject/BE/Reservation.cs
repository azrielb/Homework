using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    //מחלקה אבסטרקטית להזמנות
    public abstract class Reservation
    {
        /// <summary>
        /// מספר הזמנה
        /// </summary>
        public int Reservation_Number { get; set; }   
        /// <summary>
        /// מספר סוכנות
        /// </summary>
        public int Tour_Agency_Code { get; set; }   
        /// <summary>
        /// מספר מיטות
        /// </summary>
        public int Total_Bads_Number { get; set; } 
        /// <summary>
        /// תאריך הזמנה
        /// </summary>
        public DateTime Order_Date { get; set; }             
        /// <summary>
        /// תאריך כניסה
        /// </summary>
        public DateTime Check_In_Date { get; set; }     
        /// <summary>
        /// תאריך יציאה
        /// </summary>
        public DateTime Check_Out_Date { get; set; }     
        /// <summary>
        /// ימי שהות
        /// </summary>
        public int Number_of_days { get; set; }   
        /// <summary>
        /// פונקציה לא ממומשת לחישוב מחיר
        /// </summary>
        public abstract int Calculate_Price { get; }                 
   
       /// <summary>
       /// מחזירה תאריך ללא שעה
       /// </summary>
        public string ShortOrder_Date { get { return Order_Date.ToShortDateString(); } }            
        public string ShortCheck_In_Date { get { return Check_In_Date.ToShortDateString(); } }
        public string ShortCheck_Out_Date { get { return Check_Out_Date.ToShortDateString(); } }
        
        public override string ToString()
        {
            return Reservation_Number.ToString();
        }
    }
}
