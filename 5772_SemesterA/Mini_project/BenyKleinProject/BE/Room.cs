using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Room
    {
        /// <summary>
        /// מספר חדר
        /// </summary>
        public int Room_Code { get; set; }    
        /// <summary>
        /// מספר מיטות מבוגרים
        /// </summary>
        public int BadsNumberAdults { get; set; }   
        /// <summary>
        /// מספר מיטות ילדים
        /// </summary>
        public int BadsNumberChildren { get; set; }        
        /// <summary>
        /// מול הים
        /// </summary>
      
        public bool Seaview { get; set; }         
        /// <summary>
        /// מיזוג
        /// </summary>
               
        public bool AirConditioning { get; set; }    
        /// <summary>
        /// הפרדה יהודית
        /// </summary>
            
        public bool HafradaYeudit { get; set; }       
        /// <summary>
        /// מיני בר
        /// </summary>
           
        public bool MiniBar { get; set; }                
        /// <summary>
        /// רמת חדר
        /// </summary>
        
        public Level_of_room level_of_room { get; set; }   
        /// <summary>
        /// כיוונים
        /// </summary>
      
        public Exposures exposures { get; set; }     
        /// <summary>
        /// מחיר החדר ללילה
        /// </summary>
            
        public int Cost { get; set; }                                    

        public override string ToString()
        {
            return Room_Code.ToString();
        }
    }
}
