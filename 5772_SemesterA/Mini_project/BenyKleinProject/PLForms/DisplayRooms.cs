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
    /// <summary>
    /// מציג חדרים
    /// </summary>
    public partial class DisplayRooms : Form
    {
        BL.IBL bl;
        public DisplayRooms(BL.IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            comboBox2.DataSource = Enum.GetValues(typeof(BE.Level_of_room));
            comboBox2.ResetText();
            comboBox3.DataSource = bl.getallroomcode();
            dataGridView1.DataSource = bl.GetAllRooms();

        }

        /// <summary>
        /// מחיקת חדרים שנבחרו
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("בחר לפחות חדר אחד");
                    return;
                }

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int x = (int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));

                    if (!bl.RemoveRoom(x))
                    {
                        MessageBox.Show("חדר מספר " + x + " קיים בהזמנה ");
                    }
                }

                comboBox3.DataSource = null;
                comboBox3.DataSource = bl.getallroomcode();
                dataGridView1.DataSource = new List<Room>();
                dataGridView1.DataSource = bl.GetAllRooms();
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }
        }

        /// <summary>
        /// עריכת חדר
        /// פותח חלון של עריכת חדר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("בחר חדר אחד");
                    return;
                }

                updateroom up = new updateroom(bl, int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                up.ShowDialog();
                this.button1_Click(sender, e);
                
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה");
            }
        }

        /// <summary>
        /// סינון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Enabled = comboBox2.Enabled = button1.Enabled = label4.Enabled = 
                label5.Enabled = textBox1.Enabled = textBox2.Enabled = label2.Enabled = label3.Enabled =
                    dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;

            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.ResetText();

            if (comboBox1.SelectedIndex == 0)
            {
                button1.Enabled = true;
                return;
            }
            if (comboBox1.SelectedIndex == 1)
            {

                label2.Enabled = label3.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = button1.Enabled = true;
                return;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label4.Enabled = label5.Enabled = textBox1.Enabled = textBox2.Enabled = button1.Enabled = true;
                return;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label6.Enabled = comboBox2.Enabled = button1.Enabled = true;
                return;
            }


        }

        /// <summary>
        ///סינון חדרים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bl.GetAllRooms().ToList();
                
                ///חדרים בהזמנות פעילות
                if (comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = bl.GetAllRoomsInReservation(dateTimePicker1.Value, dateTimePicker2.Value);
                }
                ///לפי מחיר
                if (comboBox1.SelectedIndex == 2)
                {
                    int min;
                    if (!int.TryParse(textBox1.Text, out min))
                    {
                        MessageBox.Show("מחיר חדר מינימום לא הוזן או לא תקין");
                        return;
                    }
                    int max;
                    if (!int.TryParse(textBox2.Text, out max)  || (min > max))
                    {
                        MessageBox.Show("מחיר חדר מקסימום לא הוזן או לא תקין");
                        return;
                    }

                    dataGridView1.DataSource = bl.GetAllRoomsprice(min, max, bl.GetAllRooms());
                   
                }

                ///חדרים שמזומנים לתאריכים מסויימים
                if (comboBox1.SelectedIndex == 3) 
                {
                    dataGridView1.DataSource = bl.GetAllRoomsLevel((Level_of_room)comboBox2.SelectedValue, bl.GetAllRooms());
                   
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
        /// בחירת תאריך התחלה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
        }

        /// <summary>
        /// תאריך סיום
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
                dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
        }

        /// <summary>
        /// מציג
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Room> temp = new List<Room>();
            temp.Add(bl.getRoom(Convert.ToInt32(comboBox3.SelectedValue)));
            dataGridView1.DataSource = temp;
        }





    }
}
