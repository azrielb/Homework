using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using BE;

namespace PLForms
{
    public partial class MainForm : Form
    {
        IBL bl;

        public MainForm()
        {
            bl = FactoryBL.getBL();

            InitializeComponent();
            label2.Text = DateTime.Now.ToShortDateString();

            this.tabControl1.Click +=new EventHandler(tabControl1Click);
       
            
        }

        private void tabControl1Click(object sender, EventArgs e)
        {
            this.Numericaldata();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void viewroom_Click(object sender, EventArgs e)
        {
            DisplayRooms d = new DisplayRooms(bl);
            d.ShowDialog();
        }

        private void Addroom_Click(object sender, EventArgs e)
        {
            addroom a = new addroom(bl);
            a.ShowDialog();
        }

        private void Updateroom_Click(object sender, EventArgs e)
        {
            updateroom u = new updateroom(bl);
            u.ShowDialog();
        }

        private void remuveroom_Click(object sender, EventArgs e)
        {
            DisplayRooms u = new DisplayRooms(bl);
            u.ShowDialog();
        }

        private void Addreservation_Click(object sender, EventArgs e)
        {
            addreservation a = new addreservation(bl, false);
            a.ShowDialog();
        }

        private void Viewreservation_Click(object sender, EventArgs e)
        {
            viewreservations v = new viewreservations(bl);
            v.ShowDialog();
        }

        private void Removereservation_Click(object sender, EventArgs e)
        {
            viewreservations v = new viewreservations(bl);
            v.ShowDialog();
        }

        private void addtour_Click(object sender, EventArgs e)
        {
            addtourangecy a = new addtourangecy(bl);
            a.ShowDialog();
        }

        private void remuvetour_Click(object sender, EventArgs e)
        {
            updatetour u = new updatetour(bl);
            u.ShowDialog();
        }

        private void updatetourangec_Click(object sender, EventArgs e)
        {
            updatetour u = new updatetour(bl);
            u.ShowDialog();
        }

        private void viewtourangecy_Click(object sender, EventArgs e)
        {
            viewtour v = new viewtour(bl);
            v.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addreservation a = new addreservation(bl, true);
            a.ShowDialog();
        }

        private void Updatereservation_Click(object sender, EventArgs e)
        {
            viewreservations v = new viewreservations(bl);
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Numericaldata();
        }

        private void Numericaldata()
        {
            label1.Text = "מספר החדרים הכולל במלון:   " + bl.GetAllRooms().Count.ToString();
            label5.Text = "מספר הסוויטות:   " + bl.GetAllRooms().Where(r => r.level_of_room == BE.Level_of_room.סוויטה).Count().ToString();
            label4.Text = "מספר חדרי גן:   " + bl.GetAllRooms().Where(r => r.level_of_room == BE.Level_of_room.גן).Count().ToString();
            label3.Text = "מספר חדרי משפחה:   " + bl.GetAllRooms().Where(r => r.level_of_room == BE.Level_of_room.משפחה).Count().ToString();
            label7.Text = "מספר החדרים הרגילים:   " + bl.GetAllRooms().Where(r => r.level_of_room == BE.Level_of_room.סטנדרט).Count().ToString();

            label6.Text = "מספר ההזמנות הכולל:   " + bl.GetAllReservation().Count.ToString();
            label8.Text = "מספר ההזמנות למעט הזמנות שבוצעו בעבר:   " + bl.GetAllActivityReservation().Count().ToString();
            label9.Text = "ההכנסות מכל ההזמנות:   " + bl.SummaryOrders().ToString();
            label10.Text = "הזמנות שבוצעו היום:   " + bl.GetAllReservation().Where(r => r.Order_Date.ToShortDateString() == DateTime.Now.ToShortDateString()).Count().ToString();
            label11.Text = "הזמנות למימוש היום:   " + bl.GetAllReservation().Where(r => r.ShortCheck_In_Date == DateTime.Now.ToShortDateString()).Count().ToString();

            label12.Text = "תפוסת המלון באחוזים:   " + bl.tonnage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                 Room room1 = new Room();
            room1.Cost = i*100 +100;
            room1.exposures = BE.Exposures.דרום;
            room1.level_of_room = BE.Level_of_room.סטנדרט;
            room1.BadsNumberAdults = 1 + i % 3;
            room1.Room_Code = i+1;
            bl.AddRoom(room1);
            }
            TourAgency t = new TourAgency();
            t.Contact = "plony";
            t.Tour_Agency_Code = 1;
            t.Tour_Agency_Name = "British";
            t.type_of_tour_agency = type_of_tour_agency.בינלאומי;

            bl.AddTourAgency(t);


            t = new TourAgency();
            t.Contact =  "plony";
            t.Tour_Agency_Code = 2;
            t.Tour_Agency_Name = "America";
            t.type_of_tour_agency = type_of_tour_agency.בינלאומי;

            bl.AddTourAgency(t);

           
           
        }

        



      

    }

}
