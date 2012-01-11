using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLForms
{
    public partial class viewtour : Form
    {
        BL.IBL bl;

        public viewtour(BL.IBL bl)
        {
            this.bl = bl;
            InitializeComponent();
            dataGridView1.DataSource = bl.GetAllTourAgency();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int code = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                dataGridView1.Rows[i].Cells[5].Value = bl.NumReservationByTourangecy(code);
            }
        }

        
    }
}
