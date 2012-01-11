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
    public partial class addtourangecy : Form
    {
        BL.IBL bl;
      
        public addtourangecy( BL.IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            try
            {
                tour_Agency_CodeLabel1.Text = bl.GetNewTourAnNumber().ToString();
                type_of_tour_agencyComboBox.DataSource = Enum.GetValues(typeof(BE.type_of_tour_agency));
            }
            catch (Exception)
            {
                
                MessageBox.Show("שגיאה");
            }
           
        }

        /// <summary>
        /// הוספת סוכנות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1add_Click(object sender, EventArgs e)
        {
            try
            {
                TourAgency t = new TourAgency();
                t.Tour_Agency_Code = bl.GetNewTourAnNumber();
                t.Contact = contactTextBox.Text;
                t.PhoneNum = phoneNumTextBox.Text;
                t.Tour_Agency_Name = tour_Agency_NameTextBox.Text;
                t.type_of_tour_agency = (type_of_tour_agency)type_of_tour_agencyComboBox.SelectedValue;
                t.website = websiteTextBox.Text;

               
                if (t.Tour_Agency_Name == "")
                {
                    
                    MessageBox.Show("לא הוזן שם סוכנות");
                    return;
                }

                if (t.type_of_tour_agency == BE.type_of_tour_agency.בחר)
                {
                    MessageBox.Show("לא נבחר סוג סוכנות");
                    return;
                }


                if (!bl.AddTourAgency(t)) throw new Exception();

                addtourangecy.ActiveForm.Close();
                MessageBox.Show("סוכנות נוספה בהצלחה");

                
            }
            catch (Exception)
            {

                MessageBox.Show("שגיאה, שם סוכנות קיים במאגר");
            }
        }

        private void button1cancel_Click(object sender, EventArgs e)
        {
            addtourangecy.ActiveForm.Close();
        }

    }
}
