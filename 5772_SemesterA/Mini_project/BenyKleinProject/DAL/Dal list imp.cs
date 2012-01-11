using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    internal class Dal_list_imp : IDAL
    {
        private List<Room> RoomList;
        private List<Reservation> ReservationList;
        private List<TourAgency> TourAngecyList;


        /// <summary>
        /// בנאי
        /// </summary>
        public Dal_list_imp()
        {
            RoomList = new List<Room>();
            ReservationList = new List<Reservation>();
            TourAngecyList = new List<TourAgency>();
        }

        /// <summary>
        /// הוספת חדר
        /// מוודאת שלא קיים חדר עם מספר חדר זהה
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool AddRoom(Room room)
        {
            Room temp = RoomList.Find(r => r.Room_Code == room.Room_Code);
            if (temp != null) return false;
            RoomList.Add(room);
            return true;
        }

        /// <summary>
        /// הסרת חדר
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public bool RemoveRoom(int Code)
        {
            Room temp = RoomList.Find(r => r.Room_Code == Code);
            if (temp == null) return false;
            RoomList.Remove(temp);
            return true;
        }

        /// <summary>
        /// עדכון חדר
        /// מוחק חדר ישן
        /// ומוסיף את החדש
        /// </summary>
        /// <param name="room"></param>
        public void UpdateRoom(Room room)
        {
            RemoveRoom(room.Room_Code);
            AddRoom(room);
        }

        /// <summary>
        /// הוספת הזמנה
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool AddReservation(Reservation reservation)
        {
            Reservation temp = ReservationList.Find(r => r.Reservation_Number == reservation.Reservation_Number);
            if (temp != null) return false;
            ReservationList.Add(reservation);
            return true;
        }


        /// <summary>
        /// הסרת הזמנה
        /// </summary>
        /// <param name="Reservation_Number"></param>
        /// <returns></returns>
        public bool RemoveReservation(int Reservation_Number)
        {
            Reservation temp = ReservationList.Find(r => r.Reservation_Number == Reservation_Number);
            if (temp == null) return false;
            ReservationList.Remove(temp);
            return true;
        }


        /// <summary>
        /// עדכון הזמנה
        /// </summary>
        /// <param name="reservation"></param>
        public void UpdateReservation(Reservation reservation)
        {
            RemoveReservation(reservation.Reservation_Number);
            AddReservation(reservation);
        }


        /// <summary>
        /// הוספת סוכנות
        /// </summary>
        /// <param name="tour_agency"></param>
        /// <returns></returns>
        public bool AddTourAgency(TourAgency tour_agency)
        {
            TourAgency temp = TourAngecyList.Find(t => t.Tour_Agency_Code == tour_agency.Tour_Agency_Code);
            if (temp != null) return false;
            TourAngecyList.Add(tour_agency);
            return true;
        }

        /// <summary>
        /// הסרת סוכנות
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public bool RemoveTourAgency(int Code)
        {
            TourAgency temp = TourAngecyList.Find(t => t.Tour_Agency_Code == Code);
            if (temp == null) return false;
            TourAngecyList.Remove(temp);
            return true;
        }

        /// <summary>
        /// עדכון סוכנות
        /// </summary>
        /// <param name="tour_agency"></param>
        public void UpdateTourAgency(TourAgency tour_agency)
        {
            RemoveTourAgency(tour_agency.Tour_Agency_Code);
            AddTourAgency(tour_agency);
        }

        public List<Reservation> GetAllReservation()
        {
            return ReservationList;
        }

        public List<TourAgency> GetAllTourAgency()
        {
            return TourAngecyList;
        }

        public List<Room> GetAllRooms()
        {
            return RoomList;
        }

    }
}
