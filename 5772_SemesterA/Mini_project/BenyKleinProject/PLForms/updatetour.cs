using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using BL;

namespace PLForms
{
    public partial class updatetour : Form
    {
        IBL bl;
        TourAgency tour;

        public updatetour(IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
  
            type_of_tour_agencyComboBox.DataSource = Enum.GetValues(typeof(BE.type_of_tour_agency));
            comboBox1code.DataSource = bl.GetAllTourAgency().Select(tour => tour.Tour_Agency_Code).ToList();
            comboBoxname.DataSource = bl.GetAllTourAgency().Select(tour => tour.Tour_Agency_Name).ToList();
          
            numericUpDowndiscount.Maximum = 100;
            numericUpDowndiscount.Minimum = 0;
        }


        /// <summary>
        /// הצגת סוכנות בבחירת מספר סוכנות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1code_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                this.tour = bl.gettourangecy(int.Parse(comboBox1code.Text));
                if (tour == null) throw new Exception();

                comboBoxname.Text = tour.Tour_Agency_Name;
                type_of_tour_agencyComboBox.SelectedItem = tour.type_of_tour_agency;
                contactTextBox.Text = tour.Contact;
                phoneNumTextBox.Text = tour.PhoneNum;
                websiteTextBox.Text = tour.website;

            }
            catch (Exception)
            {

                MessageBox.Show("סוכנות לא קיימת");
            }
        }

        /// <summary>
        /// הצגת סןכנות בבחירת שם סוכנות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
                this.tour = bl.gettourangecy(comboBoxname.Text);
                if (tour == null) throw new Exception();
                comboBox1code.Text = tour.Tour_Agency_Code.ToString();
                contactTextBox.Text = tour.Contact;
                phoneNumTextBox.Text = tour.PhoneNum;
                websiteTextBox.Text = tour.website;
                type_of_tour_agencyComboBox.SelectedItem = tour.type_of_tour_agency;

            }
            catch (Exception)
            {

                MessageBox.Show("סוכנות לא קיימת");
            }
        }

        private void button1cancel_Click(object sender, EventArgs e)
        {
            updatetour.ActiveForm.Close();
        }


        /// <summary>
        /// עדכון סוכנות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.gettourangecy(int.Parse(comboBox1code.Text)) == null || bl.gettourangecy(comboBoxname.Text) == null)
                    throw new Exception();
                TourAgency temp = new TourAgency();
                temp.Tour_Agency_Code = this.tour.Tour_Agency_Code;
                temp.Tour_Agency_Name = this.tour.Tour_Agency_Name;

               temp.type_of_tour_agency = (type_of_tour_agency)type_of_tour_agencyComboBox.SelectedValue;
               temp.Contact = contactTextBox.Text;
               temp.PhoneNum = phoneNumTextBox.Text;
               temp.website = websiteTextBox.Text;


                if (temp.type_of_tour_agency == BE.type_of_tour_agency.בחר)
                {
                    MessageBox.Show("לא נבחר סוג סוכנות");
                    return;
                }
                bl.UpdateTourAgency(temp);

                addtourangecy.ActiveForm.Close();
                MessageBox.Show("סוכנות עודכנה בהצלחה");
            }
            catch (Exception)
            {
                
                MessageBox.Show("לא נבחרה סוכנות");
            }
        }


        /// <summary>
        /// הסרת סוכנות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bl.RemoveTourAgency(int.Parse(comboBox1code.Text)))
                {
                    MessageBox.Show("הסוכנות הוסרה בהצלחה");
                    updatetour.ActiveForm.Close();
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                
                MessageBox.Show("לא נבחרה סוכנות");
            }
        }
    }
}
