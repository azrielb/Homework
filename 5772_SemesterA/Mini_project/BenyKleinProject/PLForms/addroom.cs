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
    public partial class addroom : Form
    {
        BL.IBL bl;
        public addroom(BL.IBL bl)
        {

            this.bl = bl;

            InitializeComponent();
            level_of_roomComboBox.DataSource = Enum.GetValues(typeof(BE.Level_of_room));
            exposuresComboBox.DataSource = Enum.GetValues(typeof( BE.Exposures));

            numbadsAdultNumeric.Minimum = 0;
            numbadsAdultNumeric.Maximum = 4;
            numberbadscildnumeric.Minimum = 0;
            numberbadscildnumeric.Maximum = 4;
            
            numbadsAdultNumeric.Value = 2;
        
        }

  
        /// <summary>
        /// הוספת חדר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int cost;
                if (!int.TryParse(costTextBox.Text,out cost))
                {
                    MessageBox.Show("מחיר חדר לא הוזן או לא תקין");
                    return;
                }

                if (cost < 1 || cost > 10000)
                {
                     MessageBox.Show("מחיר חדר לא תקין");
                    return;
                }


                Room r = new Room();
                r.Room_Code = bl.GetNewRoomNumber();
                r.level_of_room = (Level_of_room)level_of_roomComboBox.SelectedValue;
                r.exposures = (Exposures)exposuresComboBox.SelectedValue;
                r.Cost = cost;
                r.Seaview = seaviewCheckBox.Checked;
                r.BadsNumberAdults = int.Parse(numbadsAdultNumeric.Value.ToString());
                r.BadsNumberChildren = int.Parse(numberbadscildnumeric.Value.ToString());
                r.MiniBar = checkBoxminibar.Checked;
                r.HafradaYeudit = checkBoxjueish.Checked;
                r.AirConditioning = aircondishenchekbox.Checked;

                if (r.BadsNumberAdults == 0 && r.BadsNumberChildren == 0)
                {
                    MessageBox.Show("לא הוזן מספר מיטות");
                    return;
                }

                if (r.exposures == BE.Exposures.בחר)
                {
                    throw new Exception("לא נבחר כיוון אוויר");
                }
               if (!bl.AddRoom(r)) throw new Exception();


               addroom.ActiveForm.Close();

               MessageBox.Show("נוסף, חדר מספר: " + r.Room_Code.ToString());
               

                
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה");
            }

        }

        private void button1cancel_Click(object sender, EventArgs e)
        {
            addroom.ActiveForm.Close();
        }

       


     

      
    }
}
