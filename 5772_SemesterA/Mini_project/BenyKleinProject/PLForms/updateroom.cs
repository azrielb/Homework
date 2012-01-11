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
    public partial class updateroom : Form
    {
        BL.IBL bl;
        BE.Room room;


        /// <summary>
        /// בנאי
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="x">עבור חדר מסויים מספר</param>
        public updateroom(BL.IBL bl, int x = 0)
        {
            this.bl = bl;

          
            InitializeComponent();
            level_of_roomComboBox.DataSource = Enum.GetValues(typeof(BE.Level_of_room));
            exposuresComboBox.DataSource = Enum.GetValues(typeof(BE.Exposures));
            numericUpDownadults.Maximum = 4;
            numericUpDownadults.Minimum = 0;
            numericUpDownchild.Maximum = 4;
            numericUpDownchild.Minimum = 0;
            comboBox1.DataSource = (bl.GetAllRooms().Select(room => room.Room_Code)).ToList();
            if (x != 0) comboBox1.SelectedItem = x;

        }


        /// <summary>
        /// עדכון החדר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.room = bl.getRoom(int.Parse(comboBox1.Text));

                if (room == null) throw new Exception();

                int cost;
                if (!int.TryParse(costTextBox.Text, out cost))
                {
                    MessageBox.Show("מחיר חדר לא הוזן או לא תקין");
                    return;
                }

                Room temp = new Room();

                temp.Room_Code = this.room.Room_Code;

               temp.level_of_room = (Level_of_room)level_of_roomComboBox.SelectedValue;
               temp.exposures = (Exposures)exposuresComboBox.SelectedValue;
               temp.Cost = cost;
               temp.Seaview = seaviewCheckBox.Checked;
               temp.BadsNumberAdults = int.Parse(numericUpDownadults.Value.ToString());
               temp.BadsNumberChildren = int.Parse(numericUpDownchild.Value.ToString());
               temp.MiniBar = miniBarCheckBox.Checked;
               temp.HafradaYeudit = hafradaYeuditCheckBox.Checked;
               temp.AirConditioning = airConditioningCheckBox.Checked;

                if (room.BadsNumberAdults == 0 && room.BadsNumberChildren == 0)
                {
                    MessageBox.Show("לא הוזן מספר מיטות");
                    return;
                }


                if (room.exposures == BE.Exposures.בחר)
                {
                    MessageBox.Show("לא נבחר כיוון אוויר");
                    return;
                }
 
                updateroom.ActiveForm.Close();

                if (!bl.UpdateRoom(temp))
                {
                    MessageBox.Show("חדר קיים בהזמנה");
                    return;
                }
                MessageBox.Show("עודכן , חדר מספר: " + room.Room_Code.ToString());



            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה");
            }
        }


        /// <summary>
        /// סגירתחלון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            updateroom.ActiveForm.Close();
        }

        /// <summary>
        /// מעדכן פרטים לפי בחירת מספר חדר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                this.room = bl.getRoom(int.Parse(comboBox1.Text));

                if (room == null) throw new Exception();

                numericUpDownadults.Value = room.BadsNumberAdults;
                numericUpDownchild.Value = room.BadsNumberChildren;

                costTextBox.Text = room.Cost.ToString();
                exposuresComboBox.SelectedItem = room.exposures;
                level_of_roomComboBox.SelectedItem = room.level_of_room;


                airConditioningCheckBox.Checked = room.AirConditioning;
                miniBarCheckBox.Checked = room.MiniBar;
                hafradaYeuditCheckBox.Checked = room.HafradaYeudit;
                seaviewCheckBox.Checked = room.Seaview;
                
            }
            catch (Exception)
            {
                MessageBox.Show("חדר לא קיים");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            updateroom.ActiveForm.Close();
            DisplayRooms d = new DisplayRooms(bl);
            d.ShowDialog();
           
        }




    }
}
