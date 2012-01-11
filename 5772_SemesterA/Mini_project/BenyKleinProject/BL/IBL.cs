using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BL
{
    public interface IBL
    {

        bool AddRoom(Room room);
        bool RemoveRoom(int Code);
        bool UpdateRoom(Room room);
        List<int> getallroomcode();
        Room getRoom(int Code);
      
        bool AddReservation(Reservation reservation);
        bool RemoveReservation(int Reservation_Number);
        void UpdateReservation(Reservation reservation);
        Reservation getreservation(int code);
        /// <summary>
        /// מחזירה את מספר המיטות בהזמנה
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns> 
        int gettotalbeds(Reservation reservation);
    
        bool AddTourAgency(TourAgency tour_agency);
        bool RemoveTourAgency(int Code);
        void UpdateTourAgency(TourAgency tour_agency);
        TourAgency gettourangecy(string name);
        TourAgency gettourangecy(int code);
     
        /// <summary>
        /// מחזירה את מספר ההזמנות שבוצעו על ידי הסוכנות
        /// </summary>
        /// <param name="code_tour"></param>
        /// <returns></returns>
        int NumReservationByTourangecy(int code_tour);


        List<Reservation> GetAllReservation();
        List<TourAgency> GetAllTourAgency();
        List<Room> GetAllRooms();
        List<Room> GetAllRoomsInReservation();


        List<Room> GetAllRoomsInReservation(DateTime start, DateTime end);
        List<Room> GetAllRoomsLevel(BE.Level_of_room level, List<Room> of);
        List<Room> GetAllRoomsprice(int min, int max, List<Room> of);

        /// <summary>
        /// מחזירה רשימת הזמנות לפי שני תנאים שהתקבלו כפרמטרים
        /// </summary>
        /// <param name="predic1"></param>
        /// <param name="predic2"></param>
        /// <returns></returns>
        List<Reservation> ReservationByDeliget(Func<Reservation, bool> predic1, Func<Reservation, bool> predic2);
    
        /// <summary>
        /// מקבלת רשימת חדרים ומחזירה רשימת חדרים פחות החדרים התפוסים
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="ToTest"></param>
        /// <returns></returns>
        List<Room> TestFreeRomm(DateTime start, DateTime end, List<Room> ToTest);
     
        /// <summary>
       /// מחזירה רשימת הזמנות פעילות
       /// </summary>
       /// <returns></returns>
        List<Reservation> GetAllActivityReservation();
       
        /// <summary>
        /// מחזירה רשימת חדרים לפי רשימת מספרי חדרים
        /// </summary>
        /// <param name="lisint"></param>
        /// <returns></returns>
        List<Room> getroomint(List<int> lisint);

        /// <summary>
        /// מחזיר סכום מכל ההזמנות
        /// </summary>
        /// <returns></returns>
        int SummaryOrders();

        /// <summary>
        /// ביטול הזמנות שבוצעו בין תאריכים
        /// </summary>
        /// <param name="fro"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        int CancelReservation(DateTime fro, DateTime to);

        /// <summary>
        /// מחזירה רשימת חדרים פנויים בין תאריכים
        /// </summary>
        /// <param name="fro"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        List<Room> FreeRooms(DateTime fro, DateTime to);
        
        /// <summary>
        /// רשימת חדרים פנויים לפי תאריכים 
        /// עם פרמטר נוסף
        /// </summary>
        /// <param name="fro"></param>
        /// <param name="to"></param>
        /// <param name="predic"></param>
        /// <returns></returns>
        List<Room> RoomsAnyParameters( DateTime fro, DateTime to, Func<Room,bool> predic);
        
        /// <summary>
        /// מספר לחדר חדש
        /// </summary>
        /// <returns></returns>
        int GetNewRoomNumber();

        /// <summary>
        /// מספר לסוכנות חדשה
        /// </summary>
        /// <returns></returns>
        int GetNewTourAnNumber();

        /// <summary>
        /// מספר להזמנה חדשה
        /// </summary>
        /// <returns></returns>
        int GetNewReservationNumber();

        /// <summary>
        /// מחזירה את תפוסת המלון הנוכחים באחוזים
        /// </summary>
        /// <returns></returns>
        int tonnage();
      
    }
}
