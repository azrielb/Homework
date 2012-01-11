using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;

namespace PLForms
{
    public partial class addreservation : Form
    {
        BL.IBL bl;
        List<Room> selectedroom;            ///חדרים שנבחרו
        List<Room> PossibleRoom;            ///חדרים אפשריים לבחירה
        int Code;                           /// עבור עדכון הזמנה מספר ההזמנה יתקבל כפרמטר
        bool IsSingel;                      ///האם זו הזמנת יחיד

        /// <summary>
        /// בנאי
        /// </summary>
        /// <param name="bl">מופע של bl</param>
        /// <param name="is_singel">האם הזמנת יחיד</param>
        /// <param name="code">מספר הזמנה - עבור עדכון</param>
        public addreservation(BL.IBL bl, bool is_singel, int code = 0)
        {
            this.bl = bl;
            this.selectedroom = new List<Room>();
            this.PossibleRoom = new List<Room>();

            InitializeComponent();
            ///עדכון השדות בחלון
            label2.Text = bl.GetNewReservationNumber().ToString();
            comboBox1.DataSource = bl.GetAllTourAgency();
            numericUpDowndiscount.Maximum = 100;
            numericUpDowndiscount.Minimum = 0;
            check_Out_DateDateTimePicker.Value = check_In_DateDateTimePicker.Value.AddDays(1);
            comboBox2.DataSource = Enum.GetValues(typeof(BE.Level_of_room));
            comboBox3.SelectedIndex = 0;
            IsSingel = is_singel;
            label4.Text = (check_Out_DateDateTimePicker.Value.Date - check_In_DateDateTimePicker.Value.Date).Days.ToString();
            if (IsSingel == true) label11.Text = "הזמנת יחיד";
            else label11.Text = "הזמנה קבוצתית";
            label12.Text = DateTime.Now.ToShortDateString();
            button7.Enabled = false;

            if (IsSingel == true) numericUpDowndiscount.Enabled = false;

            /// עבור עדכון הזמנה קיימת טוען את הפרטים הקיימים בהזמנה
            /// ניתן לשנות חדרים ולא תאריכים
            if (code != 0)
            {
                Code = code;
                label2.Text = bl.getreservation(Code).Reservation_Number.ToString();
                if (IsSingel == false) numericUpDowndiscount.Value = Convert.ToDecimal((bl.getreservation(Code) as Group_Reservation).OrderDiscount.ToString());

                comboBox1.Enabled = false;
                check_In_DateDateTimePicker.Value = bl.getreservation(Code).Check_In_Date;
                check_Out_DateDateTimePicker.Value = bl.getreservation(Code).Check_Out_Date;
                check_In_DateDateTimePicker.Enabled = false;
                check_Out_DateDateTimePicker.Enabled = false;
                if (IsSingel == true) selectedroom.Add((bl.getreservation(Code) as Single_Reservation).reservation_room);
                if (IsSingel == false) selectedroom.AddRange((bl.getreservation(Code) as Group_Reservation).reservation_rooms);

                dataGridView2.DataSource = selectedroom;

                button7.Enabled = true;

            }

        }

        /// <summary>
        /// מתבצע בשינוי התאריך
        /// מעדכן רשימת חדרים מתאימה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_In_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ///מונע תאריך יציאה לפני תאריך כניסה
            check_Out_DateDateTimePicker.Value = check_In_DateDateTimePicker.Value.AddDays(1);
            if (check_In_DateDateTimePicker.Value < DateTime.Now)
                check_In_DateDateTimePicker.Value = DateTime.Now;
            label4.Text = (check_Out_DateDateTimePicker.Value.Date - check_In_DateDateTimePicker.Value.Date).Days.ToString();

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            selectedroom.Clear();
            PossibleRoom.Clear();
        }

        /// <summary>
        /// מתבצע בשינוי התאריך
        /// מעדכן רשימת חדרים מתאימה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_Out_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (check_In_DateDateTimePicker.Value >= check_Out_DateDateTimePicker.Value)
                check_In_DateDateTimePicker.Value = check_Out_DateDateTimePicker.Value.AddDays(-1);
       
            label4.Text = (check_Out_DateDateTimePicker.Value.Date - check_In_DateDateTimePicker.Value.Date).Days.ToString();


            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            selectedroom.Clear();
            PossibleRoom.Clear();
        }


        /// <summary>
        /// הוספת חדרים לרשימה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("בחר חדרים");
                    return;
                }

                if (dataGridView1.SelectedRows.Count > 1 && this.IsSingel == true)
                {
                    MessageBox.Show("בחר חדר בודד");
                    return;
                }

                List<int> roomcode = new List<int>();

                ///מוסיף לרשימה את המספרים של החדרים שנבחרו
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    roomcode.Add(int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));
                }

                if (IsSingel == true)
                {
                    PossibleRoom.AddRange(selectedroom);
                    selectedroom.Clear();
                }

                ///מוסיף אותם לרשימת החדרים שנבחרו
                selectedroom.AddRange(bl.getroomint(roomcode));


                ///מסיר כפילויות
                selectedroom = selectedroom.Distinct().ToList();

                ///מסיר את החדרים מרשימת החדרים האפשריים
                PossibleRoom.RemoveAll(p => selectedroom.Any(s => s == p));


                selectedroom.Sort((a, b) => a.Room_Code.CompareTo(b.Room_Code));
                PossibleRoom.Sort((a, b) => a.Room_Code.CompareTo(b.Room_Code));

                ///מעדכן תצוגה
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PossibleRoom;

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = selectedroom;

            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }


        }

        /// <summary>
        /// הסרה מרשימת החדרים שנבחרו
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("בחר חדרים");
                    return;
                }

                List<int> roomcode = new List<int>();

                ///רשימת מספרי חדרים להסרה
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    roomcode.Add(int.Parse(dataGridView2.SelectedRows[i].Cells[0].Value.ToString()));
                }

                ///מסיר אותם מרשימת החדרים שנבחרו ומוסיף לרשימת חדרים אפשריים לבחירה
                foreach (var item in roomcode)
                {
                    this.selectedroom.Remove(bl.getRoom(item));
                    this.PossibleRoom.Add(bl.getRoom(item));
                }

                selectedroom = selectedroom.Distinct().ToList();
                PossibleRoom = PossibleRoom.Distinct().ToList();
                selectedroom.Sort((a,b) => a.Room_Code.CompareTo(b.Room_Code));
                PossibleRoom.Sort((a,b) => a.Room_Code.CompareTo(b.Room_Code));

                ///מעדכן תצוגה
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PossibleRoom;

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = selectedroom;

            }

            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }

        }


        /// <summary>
        /// חישוב מחיר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = (check_Out_DateDateTimePicker.Value.Date - check_In_DateDateTimePicker.Value.Date).Days.ToString();
                int days = int.Parse(label4.Text);
                int sum = 0;

                foreach (Room item in selectedroom)
                {
                    sum += item.Cost * days;
                }

                ///מחשב הנחה
                if (IsSingel == false)
                {
                    double s = Convert.ToDouble(sum) - Convert.ToDouble(sum) * Convert.ToDouble(numericUpDowndiscount.Value) / Convert.ToDouble(100);
                    sum = Convert.ToInt32(s);
                }
                ///מציג
                label8.Text = sum.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("חסרים נתונים");
            }
        }


        /// <summary>
        /// סגירת חלון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            addreservation.ActiveForm.Close();
        }


        /// <summary>
        /// /הוסת הזמנה או עדכון הזמנה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ///לא נבחרה סוכנות
                if (bl.GetAllTourAgency().Count == 0 || !bl.GetAllTourAgency().Any(r => r.Tour_Agency_Name == comboBox1.SelectedValue.ToString()) )
                {
                    MessageBox.Show("בחר סוכנות מתוך רשימה");
                    return;
                }

               
                BE.Reservation reservation;

                ///לא נבחרו חדרים
                if (this.selectedroom.Count == 0)
                    throw new Exception();

                 ///יוצר הזמנה חדשה 
                if (IsSingel == true)
                {
                    reservation = new Single_Reservation();
                    (reservation as Single_Reservation).reservation_room = selectedroom[0];

                }
                else
                {
                    reservation = new Group_Reservation();
                    (reservation as Group_Reservation).reservation_rooms = selectedroom;
                    (reservation as Group_Reservation).OrderDiscount = int.Parse(numericUpDowndiscount.Value.ToString());
                }


                ///עבור הזמנה חדשה
                if (Code == 0)
                {
                    reservation.Order_Date = DateTime.Now;
                    reservation.Reservation_Number = bl.GetNewReservationNumber();
                    reservation.Check_In_Date = check_In_DateDateTimePicker.Value;
                    reservation.Check_Out_Date = check_Out_DateDateTimePicker.Value;
                    reservation.Tour_Agency_Code = bl.gettourangecy((comboBox1.SelectedValue.ToString())).Tour_Agency_Code;
                    reservation.Total_Bads_Number = bl.gettotalbeds(reservation);
                    reservation.Number_of_days = int.Parse(label4.Text);


                    if (bl.AddReservation(reservation))
                        MessageBox.Show("הזמנה נוספה");
                    else MessageBox.Show("הזמנה לא נוספה");

                    addreservation.ActiveForm.Close();
                }


                ///עבור עדכון הזמנה
                if (Code != 0)
                {
                    reservation.Order_Date = bl.getreservation(Code).Order_Date;
                    reservation.Reservation_Number = bl.getreservation(Code).Reservation_Number;
                    reservation.Check_In_Date = bl.getreservation(Code).Check_In_Date;
                    reservation.Check_Out_Date = bl.getreservation(Code).Check_Out_Date;
                    reservation.Tour_Agency_Code = bl.getreservation(Code).Tour_Agency_Code;
                    reservation.Total_Bads_Number = bl.getreservation(Code).Total_Bads_Number;
                    reservation.Number_of_days = bl.getreservation(Code).Number_of_days;


                    bl.UpdateReservation(reservation);
                    MessageBox.Show("הזמנה עודכנה");

                    addreservation.ActiveForm.Close();
                }

            }


            catch (Exception)
            {
                MessageBox.Show("לא הוזנו נתונים");
            }
        }



        /// <summary>
        /// מסנן
        /// מאפשר בחירה של פרמטר אחד
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Enabled = label7.Enabled = label9.Enabled = textBox1.Enabled = textBox2.Enabled = comboBox2.Enabled = button6.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.ResetText();

            if (comboBox3.SelectedIndex == 0)
            {
                button6.Enabled = true;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                label7.Enabled = label9.Enabled = textBox1.Enabled = textBox2.Enabled = button6.Enabled = true;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                label6.Enabled = comboBox2.Enabled = button6.Enabled = true;
            }
        }


        /// <summary>
        /// מציג תוצאות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = null;
                ///מוסיף לרשימת חדרים אפשריים את החדרים האפשריים לפי התאריך
                PossibleRoom.AddRange(bl.FreeRooms(check_In_DateDateTimePicker.Value, check_Out_DateDateTimePicker.Value));
                PossibleRoom.RemoveAll(r => selectedroom.Any(x => x == r));
                selectedroom = selectedroom.Distinct().ToList();
                PossibleRoom = PossibleRoom.Distinct().ToList();
                PossibleRoom.Sort((a, b) => a.Room_Code.CompareTo(b.Room_Code));
                dataGridView1.DataSource = PossibleRoom;


                ///סינון לפי מחיר
                if (comboBox3.SelectedIndex == 1)
                {
                    int min;
                    if (!int.TryParse(textBox1.Text, out min))
                    {
                        MessageBox.Show("מחיר חדר מינימום לא הוזן או לא תקין");
                        dataGridView1.DataSource = null;
                        return;
                    }
                    int max;
                    if (!int.TryParse(textBox2.Text, out max) || (min > max))
                    {
                        MessageBox.Show("מחיר חדר מקסימום לא הוזן או לא תקין");
                        dataGridView1.DataSource = null;
                        return;
                    }

                    PossibleRoom = bl.GetAllRoomsprice(min, max, PossibleRoom);
                    dataGridView1.DataSource = null;
                    PossibleRoom.Sort((a, b) => a.Room_Code.CompareTo(b.Room_Code));
                    dataGridView1.DataSource = PossibleRoom;

                }

                ///חדרים לפי רמת חדר
                if (comboBox3.SelectedIndex == 2)
                {
                    PossibleRoom = bl.RoomsAnyParameters(check_In_DateDateTimePicker.Value, check_Out_DateDateTimePicker.Value, r => r.level_of_room == (Level_of_room)comboBox2.SelectedItem);
                    dataGridView1.DataSource = null;
                    PossibleRoom.Sort((a, b) => a.Room_Code.CompareTo(b.Room_Code));
                    dataGridView1.DataSource = PossibleRoom;
                }
               
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("לא נמצאו חדרים מתאימים לתנאים שהזנת");
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }
        }

        /// <summary>
        /// משחזר פרטי הזמנה מקורית
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            selectedroom.Clear();

            if (IsSingel == true) selectedroom.Add((bl.getreservation(Code) as Single_Reservation).reservation_room);
            if (IsSingel == false) selectedroom.AddRange((bl.getreservation(Code) as Group_Reservation).reservation_rooms);

            PossibleRoom.RemoveAll(p => selectedroom.Any(s => s == p));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PossibleRoom;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = selectedroom;
        }

    }
}
