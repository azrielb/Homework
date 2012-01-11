using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

namespace BL
{
    public class BL_Basic : IBL
    {
        IDAL dal = FactoryDal.getDal();

        /// <summary>הוספת חדר
        /// 
        /// </summary>
        /// <param name="room">חדר</param>
        /// <returns>האם בוצע</returns>
        public bool AddRoom(Room room)
        {
            return dal.AddRoom(room);
        }

        /// <summary> הסרת חדר
        ///
        /// בודק שהחדר לא קיים בהזמנות
        /// </summary>
        /// <param name="Code">מספר חדר</param>
        /// <returns>האם הוסר</returns>
        public bool RemoveRoom(int Code)
        {
            if (GetAllRoomsInReservation().Any(r => r.Room_Code == Code))
                return false;
            return dal.RemoveRoom(Code);
        }

        /// <summary>עדכון חדר
        /// 
        /// בודק שהחדר לא קיים באחת ההזמנות
        /// </summary>
        /// <param name="room">חדר</param>
        /// <returns>האם עודכן</returns>
        public bool UpdateRoom(Room room)
        {

             if (GetAllRoomsInReservation().Any(r => r.Room_Code == room.Room_Code))
                return false;
            dal.UpdateRoom(room);
            return true;
        }

        /// <summary>הוספת הזמנה
        /// 
        /// </summary>
        /// <param name="reservation">הזמנה</param>
        /// <returns>האם נוסף</returns>
        public bool AddReservation(Reservation reservation)
        {
            return dal.AddReservation(reservation);
        }

        /// <summary>
        /// הסרת הזמנה
        /// </summary>
        /// <param name="Reservation_Number">מספר הזמנה</param>
        /// <returns>האם הוסר</returns>
        public bool RemoveReservation(int Reservation_Number)
        {
            return dal.RemoveReservation(Reservation_Number);
        }

        /// <summary>
        /// עדכון הזמנה
        /// </summary>
        /// <param name="reservation">הזמנה</param>
        public void UpdateReservation(Reservation reservation)
        {
            dal.UpdateReservation(reservation);
        }

        /// <summary>
        /// מחזירה הזמנה אחת
        /// </summary>
        /// <param name="code">מספר הזמנה</param>
        /// <returns>הזמנה</returns>
        public Reservation getreservation(int code)
        {
            return GetAllReservation().Find(r => r.Reservation_Number == code);
        }

        /// <summary>
        /// הוספת סוכנות
        /// </summary>
        /// <param name="tour">סוכנות</param>
        /// <returns></returns>
        public bool AddTourAgency(TourAgency tour)
        {
            if (GetAllTourAgency().Any(t => t.Tour_Agency_Name == tour.Tour_Agency_Name)) 
                return false;    
            return dal.AddTourAgency(tour);
        }

        /// <summary>
        /// הסרת סוכנות
        /// </summary>
        /// <param name="Code">מספר סוכנות</param>
        /// <returns></returns>
        public bool RemoveTourAgency(int Code)
        {
            return dal.RemoveTourAgency(Code);
        }

        /// <summary>
        /// עדכון סוכנות
        /// </summary>
        /// <param name="tour_agency"></param>
        public void UpdateTourAgency(TourAgency tour_agency)
        {
            dal.UpdateTourAgency(tour_agency);
        }

        /// <summary>
        /// מחזירה סוכנות אחת
        /// לפי מספר סוכנות
        /// </summary>
        /// <param name="code">מספר סוכנות</param>
        /// <returns>סוכנות</returns>
        public TourAgency gettourangecy(int code)
        {
            return GetAllTourAgency().Find(t => t.Tour_Agency_Code == code);
        }

        /// <summary>
        /// מחזירה סוכנות אחת
        /// לפי שם הסוכנות
        /// </summary>
        /// <param name="name">שם הסוכנות</param>
        /// <returns></returns>
        public TourAgency gettourangecy(string name)
        {
            return gettourangecy(this.GetAllTourAgency().Find(t => t.Tour_Agency_Name == name).Tour_Agency_Code);
        }

        /// <summary>
        /// כל ההזמנות
        /// </summary>
        /// <returns></returns>
        public List<Reservation> GetAllReservation()
        {
            List<Reservation> r = dal.GetAllReservation().ToList();
            r.Sort((a, b) => a.Reservation_Number.CompareTo(b.Reservation_Number));
            return r;
        }

        /// <summary>
        /// רשימת סוכנויות
        /// </summary>
        /// <returns></returns>
        public List<TourAgency> GetAllTourAgency()
        {
            List<TourAgency> t = dal.GetAllTourAgency().ToList();
            t.Sort((a, b) => a.Tour_Agency_Name.CompareTo(b.Tour_Agency_Name));
            return t;
        }

        /// <summary>
        /// רשימת חדרים
        /// </summary>
        /// <returns></returns>
        public List<Room> GetAllRooms()
        {
            List<Room> r = dal.GetAllRooms().ToList();
            r.Sort((a,b) => a.Room_Code.CompareTo(b.Room_Code));
            return r;
            
        }

        /// <summary>
        /// הכנסות מכל ההזמנות
        /// </summary>
        /// <returns>עלות כוללת</returns>
        public int SummaryOrders()
        {
            List<Reservation> temp = dal.GetAllReservation();
            int summmaryorder = new int();
            
            foreach (var item in temp)
            {
                summmaryorder += item.Calculate_Price;
            }

            return summmaryorder;
        }

        /// <summary>
        /// נחיקת הזמנות שבוצעו בין תאריכים
        /// </summary>
        /// <param name="fro">תאריך התחלה</param>
        /// <param name="to">תאריך סיום</param>
        /// <returns>מספר ההזמנות שבוטלו</returns>
        public int CancelReservation(DateTime fro, DateTime to)
        {
            IEnumerable<Reservation> c = from item in dal.GetAllReservation()
                                         where item.Order_Date.Date > fro && item.Order_Date.Date < to
                                         select item;

            foreach (var item in c)
            {
                RemoveReservation(item.Reservation_Number);    
            }

            return c.Count();
        }


        /// <summary>
        /// מחזירה רשימת חדרים פנויים בין תאריכים
        /// </summary>
        /// <param name="fro">תאריך התחלה</param>
        /// <param name="to">תאריך סיום</param>
        /// <returns></returns>
        public List<Room> FreeRooms(DateTime fro, DateTime to)
        {
            List<Room> freeroom = dal.GetAllRooms().ToList();

            IEnumerable<Reservation> reservations = from item in dal.GetAllReservation()
                                         where item.Check_In_Date.Date < to
                                         where item.Check_Out_Date.Date > fro
                                         select item;

            foreach (var item in reservations)
            {
                if (item is Single_Reservation)
                    freeroom.Remove(((Single_Reservation)item).reservation_room);
                if (item is Group_Reservation)
                    foreach (var it in ((Group_Reservation)item).reservation_rooms)
                    {
                        freeroom.Remove(it);
                    }
            }

            return freeroom;
        }


        /// <summary>
        /// רשימת חדרים לפי תאריכים 
        /// ותנאי נוסף
        /// </summary>
        /// <param name="fro"></param>
        /// <param name="to"></param>
        /// <param name="predic"></param>
        /// <returns></returns>
        public List<Room> RoomsAnyParameters(DateTime fro, DateTime to, Func<Room, bool> predic)
        {
            return FreeRooms(fro, to).Where(predic).ToList();
        }
        
        /// <summary>
        /// מספר לחדר חדש
        /// </summary>
        /// <returns></returns>
        public int GetNewRoomNumber()
        {
            if (GetAllRooms().Count == 0) return 100;
            return GetAllRooms().Select(room => room.Room_Code).Max() + 1;
        }

        /// <summary>
        /// מספר לסוכנות חדשה
        /// </summary>
        /// <returns></returns>
        public int GetNewTourAnNumber()
        {
            if (GetAllTourAgency().Count == 0) return 100;
            return GetAllTourAgency().Select(tour => tour.Tour_Agency_Code).Max() + 1;
        }

        /// <summary>
        /// מספר להזמנה חדשה
        /// </summary>
        /// <returns></returns>
        public int GetNewReservationNumber()
        {
            if (GetAllReservation().Count == 0) return 100;
            return GetAllReservation().Select(r => r.Reservation_Number).Max() + 1;
        }

        /// <summary>
        /// רשימת חדרים שנמצאים בהזמנות פעילות  
        /// הזמנות שמבוצעות בפועל או שתבוצענה בעתיד
        /// </summary>
        /// <returns></returns>
        public List<Room> GetAllRoomsInReservation()
        {
            List<Room> RoomsInReservation = new List<Room>();

            foreach (var item in GetAllActivityReservation())
            {
                if (item is Single_Reservation)
                    RoomsInReservation.Add(((Single_Reservation)item).reservation_room);
                if (item is Group_Reservation)
                    RoomsInReservation.AddRange(((Group_Reservation)item).reservation_rooms);
            }

            return RoomsInReservation;
        }


       /// <summary>
       /// רשימת הזמנות פעילות
       /// </summary>
       /// <returns></returns>
        public List<Reservation> GetAllActivityReservation()
        {
            IEnumerable<Reservation> ActivityReservation = from item in GetAllReservation()
                                                           where item.Check_Out_Date > DateTime.Now
                                                           select item;
            return ActivityReservation.ToList();
                                                            
        }

        /// <summary>
        /// מקבלת רשימת מספרי חדרים
        /// ומחזירה רשימה של החדרים המתאימים
        /// </summary>
        /// <param name="lisint"></param>
        /// <returns></returns>
        public List<Room> getroomint(List<int> lisint)
        {
            return GetAllRooms().Where(room => lisint.Any(x => x == room.Room_Code)).ToList();
        }

        /// <summary>
        /// מחזירה את מספר המיטות בהזמנה
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public int gettotalbeds(Reservation reservation)
        {
            if (reservation is Single_Reservation)
            {
                return (reservation as Single_Reservation).reservation_room.BadsNumberAdults + 
                    (reservation as Single_Reservation).reservation_room.BadsNumberChildren;
            }
            if (reservation is Group_Reservation)
            {
                int SUM = 0;
                foreach (var item in (reservation as Group_Reservation).reservation_rooms)
                {
                    SUM += (item.BadsNumberAdults + item.BadsNumberChildren);
                }
                return SUM;
            }
            return 0;
        }

        /// <summary>
        /// מחזירה רשימת חדרים בהזמנות לפי תאריכי ההזמנות
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<Room> GetAllRoomsInReservation(DateTime start, DateTime end)
        {
            IEnumerable<Room> v = from item in GetAllRooms()
                                              where !(FreeRooms(start, end).Any(x => x == item))
                                              select item;
            return v.ToList();
        }

        /// <summary>
        /// מקבלת רשימת חדרים 
        /// ורמת חדר
        /// ומחזירה רשימת חדרים מתאימה
        /// </summary>
        /// <param name="level"></param>
        /// <param name="of"></param>
        /// <returns></returns>
        public List<Room> GetAllRoomsLevel(BE.Level_of_room level, List<Room> of)
        {
            IEnumerable<Room> l = from item in of
                                  where item.level_of_room == level
                                  select item;
            return l.ToList();
        }

        /// <summary>
        /// מחזירה רשימת חדרים לפי מחיר
        /// </summary>
        /// <param name="min">מינימום</param>
        /// <param name="max">מקסימום</param>
        /// <param name="of"></param>
        /// <returns></returns>
        public List<Room> GetAllRoomsprice(int min, int max, List<Room> of)
        {
            IEnumerable<Room> p = from item in of
                                  where item.Cost >= min
                                  where item.Cost <= max
                                  select item;
            return p.ToList();

        }

        /// <summary>
        /// רשימת מספרי החדרים
        /// </summary>
        /// <returns></returns>
        public List<int> getallroomcode()
        {
            return GetAllRooms().Select(room => room.Room_Code).ToList();
        }

        /// <summary>
        /// מחזירה חדר לפי מספר חדר
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
      public Room getRoom(int Code)
      {
            return GetAllRooms().Find(r => r.Room_Code == Code);
      }

        /// <summary>
        ///מחזירה את מספר ההזמנות ביצעה סוכנות מסויימת
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
      public int NumReservationByTourangecy(int code)
      {
          return GetAllReservation().Where(r => r.Tour_Agency_Code == code).Count();
      }

        /// <summary>
        ///מחזירה רשימת הזמנות לפי תנאים
        /// </summary>
        /// <param name="predic1"></param>
        /// <param name="predic2"></param>
        /// <returns></returns>
      public List<Reservation> ReservationByDeliget(Func<Reservation, bool> predic1, Func<Reservation, bool> predic2 )
      {
          IEnumerable<Reservation> r = from item in GetAllReservation()
                                       where predic1(item)
                                       where predic2(item)
                                       select item;
          return r.ToList();


      }

        /// <summary>
        /// מקבלת רשימת חדרים ומנפה את החדרים שקיימים בהזמנות בתאריכים מסויימים
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="ToTest"></param>
        /// <returns></returns>
      public List<Room> TestFreeRomm(DateTime start, DateTime end, List<Room> ToTest)
      {
          return ToTest.Where(r => FreeRooms(start, end).Any(t => t == r)).ToList();
      }

        /// <summary>
        /// תפוסת המלון באחוזים
        /// </summary>
        /// <returns></returns>
      public int tonnage()
      {

          if (GetAllRooms().Count == 0) return 0;

          int t = GetAllRooms().Count - FreeRooms(DateTime.Now, DateTime.Now).Count;

          return Convert.ToInt32((Convert.ToDouble(t) / Convert.ToDouble(GetAllRooms().Count)) * Convert.ToDouble(100));
      }

    }
}
