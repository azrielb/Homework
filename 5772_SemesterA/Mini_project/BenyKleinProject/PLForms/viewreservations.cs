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
    public partial class viewreservations : Form
    {
        BL.IBL bl;

        public viewreservations(BL.IBL bl)
        {
            this.bl = bl;

            InitializeComponent();

            dataGridView1.DataSource = bl.GetAllReservation();
            comboBox1.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;

            
        }


        /// <summary>
        /// מחיקת הזמנות שנבחרו
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("בחר לפחות הזמנה אחת");
                return;
            }

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                bl.RemoveReservation(int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));
            }

           
            comboBox1.DataSource = null;
            comboBox1.DataSource = bl.GetAllReservation().Select(r => r.Reservation_Number).ToList();
            dataGridView1.DataSource = new List<Reservation>();
            dataGridView1.DataSource = bl.GetAllReservation();
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }

        }


        /// <summary>
        /// הפעלת סינון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ///הצג הכול
                if (radioButton1.Checked)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bl.GetAllReservation();
                }
                ///לפי מספר הזמנה
                if (radioButton2.Checked)
                {
                    List<Reservation> temp = new List<Reservation>();
                    dataGridView1.DataSource = null;
                    temp.Add(bl.getreservation(int.Parse(comboBox1.SelectedValue.ToString())));
                    dataGridView1.DataSource = temp;
                }
                ///
                if (radioButton3.Checked)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bl.GetAllActivityReservation();
                }
                if (radioButton4.Checked)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource =  bl.ReservationByDeliget(r => r.Check_In_Date >= dateTimePicker1.Value.AddDays(-1), 
                        r => r.Check_In_Date <= dateTimePicker2.Value);
                }
                

            }
            catch (Exception)
            {
                
                MessageBox.Show("לא נמצאו הזמנות");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                dateTimePicker1.Value = dateTimePicker2.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewreservations.ActiveForm.Close();
        }

        /// <summary>
        /// עריכת הזמנה
        /// מועבר לדף ההזמנות עם מספר החדר כפרמטר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                 if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("בחר הזמנה אחת");
                return;
            }

            int code =  int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            addreservation a = new addreservation(bl, bl.getreservation(code) is Single_Reservation, code);
            a.ShowDialog();
                
            dataGridView1.DataSource = new List<Reservation>();
            dataGridView1.DataSource = bl.GetAllReservation();
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }
        }

        /// <summary>
        /// מציג שדות אפשריים לבחירה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.DataSource = null;
            comboBox1.DataSource = bl.GetAllReservation().Select(r => r.Reservation_Number).ToList();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
        }
    }
}
