using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    public interface IDAL
    {
        /// <summary>
        /// הוספת חדר
        /// </summary>
        /// <param name="room">חדר</param>
        /// <returns>אישור</returns>
        bool AddRoom(Room room);
        /// <summary>
        /// הסרת חדר
        /// </summary>
        /// <param name="code">מספר חדר</param>
        /// <returns>אישור הסרה</returns>
        bool RemoveRoom(int code);
        /// <summary>
        /// עדכון חדר
        /// </summary>
        /// <param name="room">אישור עדכון</param>
        void UpdateRoom(Room room);

        /// <summary>
        /// הוספת הזמנה
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        bool AddReservation(Reservation reservation);
        /// <summary>
        /// הסרת הזמנה
        /// </summary>
        /// <param name="Reservation_Number">מספר חדר</param>
        /// <returns></returns>
        bool RemoveReservation(int Reservation_Number);
        /// <summary>
        /// עדכון הזמנה
        /// </summary>
        /// <param name="reservation"></param>
        void UpdateReservation(Reservation reservation);


        /// <summary>
        /// הוספת סוכנות
        /// </summary>
        /// <param name="tour_agency"></param>
        /// <returns></returns>
        bool AddTourAgency(TourAgency tour_agency);
        /// <summary>
        /// הסרת סוכנות
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        bool RemoveTourAgency(int Code);
        /// <summary>
        /// עדכון סוכנות
        /// </summary>
        /// <param name="tour_agency"></param>
        void UpdateTourAgency(TourAgency tour_agency);
    

        List<Reservation> GetAllReservation();
        List<TourAgency> GetAllTourAgency();
        List<Room> GetAllRooms();

    }
}
