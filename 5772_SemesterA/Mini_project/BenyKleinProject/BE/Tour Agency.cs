using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    //סוכנויות
    public class TourAgency
    {
        /// <summary>
        /// קוד סוכנות
        /// </summary>
        public int Tour_Agency_Code { get; set; }    
        /// <summary>
        /// שם סוכנות
        /// </summary>    
        public string Tour_Agency_Name { get; set; }
        /// <summary>
        /// סוג סוכנות
        /// </summary>
        public type_of_tour_agency type_of_tour_agency { get; set; }
        /// <summary>
        /// איש קשר
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// טלפון להתקשרות
        /// </summary>
        public string PhoneNum { get; set; }
        /// <summary>
        /// אתר אינטרנט
        /// </summary>
        public string website { get; set; }

        public override string ToString()
        {
            return Tour_Agency_Name;
        }

    }
}
