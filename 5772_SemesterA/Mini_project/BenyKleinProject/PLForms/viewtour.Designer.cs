namespace PLForms
{
    partial class viewtour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tourAgencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourAgencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeoftouragencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourAgencyCodeDataGridViewTextBoxColumn,
            this.tourAgencyNameDataGridViewTextBoxColumn,
            this.typeoftouragencyDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.tourAgencyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(745, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // tourAgencyCodeDataGridViewTextBoxColumn
            // 
            this.tourAgencyCodeDataGridViewTextBoxColumn.DataPropertyName = "Tour_Agency_Code";
            this.tourAgencyCodeDataGridViewTextBoxColumn.HeaderText = "קוד סוכנות";
            this.tourAgencyCodeDataGridViewTextBoxColumn.Name = "tourAgencyCodeDataGridViewTextBoxColumn";
            this.tourAgencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tourAgencyNameDataGridViewTextBoxColumn
            // 
            this.tourAgencyNameDataGridViewTextBoxColumn.DataPropertyName = "Tour_Agency_Name";
            this.tourAgencyNameDataGridViewTextBoxColumn.HeaderText = "שם סוכנות";
            this.tourAgencyNameDataGridViewTextBoxColumn.Name = "tourAgencyNameDataGridViewTextBoxColumn";
            this.tourAgencyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeoftouragencyDataGridViewTextBoxColumn
            // 
            this.typeoftouragencyDataGridViewTextBoxColumn.DataPropertyName = "type_of_tour_agency";
            this.typeoftouragencyDataGridViewTextBoxColumn.HeaderText = "סוג סוכנות";
            this.typeoftouragencyDataGridViewTextBoxColumn.Name = "typeoftouragencyDataGridViewTextBoxColumn";
            this.typeoftouragencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "איש הקשר";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "website";
            this.Column1.HeaderText = "כמות הזמנות";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ToolTipText = "כמות ההזמנות שבוצעו על ידי הסוכנות";
            // 
            // tourAgencyBindingSource
            // 
            this.tourAgencyBindingSource.DataSource = typeof(BE.TourAgency);
            // 
            // viewtour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 362);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewtour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewtour";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tourAgencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourAgencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourAgencyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeoftouragencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;


    }
}