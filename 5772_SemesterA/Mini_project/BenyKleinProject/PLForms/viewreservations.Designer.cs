namespace PLForms
{
    partial class viewreservations
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
            this.reservationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortOrder_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCheck_In_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCheck_Out_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourAgencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tourAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourAgencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource1)).BeginInit();
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
            this.reservationNumberDataGridViewTextBoxColumn,
            this.ShortOrder_Date,
            this.ShortCheck_In_Date,
            this.ShortCheck_Out_Date,
            this.tourAgencyCodeDataGridViewTextBoxColumn,
            this.numberofdaysDataGridViewTextBoxColumn,
            this.calculatePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(808, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // reservationNumberDataGridViewTextBoxColumn
            // 
            this.reservationNumberDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Number";
            this.reservationNumberDataGridViewTextBoxColumn.HeaderText = "מספר הזמנה";
            this.reservationNumberDataGridViewTextBoxColumn.Name = "reservationNumberDataGridViewTextBoxColumn";
            this.reservationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ShortOrder_Date
            // 
            this.ShortOrder_Date.DataPropertyName = "ShortOrder_Date";
            this.ShortOrder_Date.HeaderText = "תאריך הזמנה";
            this.ShortOrder_Date.Name = "ShortOrder_Date";
            this.ShortOrder_Date.ReadOnly = true;
            // 
            // ShortCheck_In_Date
            // 
            this.ShortCheck_In_Date.DataPropertyName = "ShortCheck_In_Date";
            this.ShortCheck_In_Date.HeaderText = "כניסה";
            this.ShortCheck_In_Date.Name = "ShortCheck_In_Date";
            this.ShortCheck_In_Date.ReadOnly = true;
            // 
            // ShortCheck_Out_Date
            // 
            this.ShortCheck_Out_Date.DataPropertyName = "ShortCheck_Out_Date";
            this.ShortCheck_Out_Date.HeaderText = "יציאה";
            this.ShortCheck_Out_Date.Name = "ShortCheck_Out_Date";
            this.ShortCheck_Out_Date.ReadOnly = true;
            // 
            // tourAgencyCodeDataGridViewTextBoxColumn
            // 
            this.tourAgencyCodeDataGridViewTextBoxColumn.DataPropertyName = "Tour_Agency_Code";
            this.tourAgencyCodeDataGridViewTextBoxColumn.HeaderText = "סוכנות";
            this.tourAgencyCodeDataGridViewTextBoxColumn.Name = "tourAgencyCodeDataGridViewTextBoxColumn";
            this.tourAgencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberofdaysDataGridViewTextBoxColumn
            // 
            this.numberofdaysDataGridViewTextBoxColumn.DataPropertyName = "Number_of_days";
            this.numberofdaysDataGridViewTextBoxColumn.HeaderText = "ימים";
            this.numberofdaysDataGridViewTextBoxColumn.Name = "numberofdaysDataGridViewTextBoxColumn";
            this.numberofdaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calculatePriceDataGridViewTextBoxColumn
            // 
            this.calculatePriceDataGridViewTextBoxColumn.DataPropertyName = "Calculate_Price";
            this.calculatePriceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.calculatePriceDataGridViewTextBoxColumn.Name = "calculatePriceDataGridViewTextBoxColumn";
            this.calculatePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(BE.Reservation);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "בחר ומחק הזמנה/ות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.reservationBindingSource1;
            this.comboBox1.DisplayMember = "Reservation_Number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(526, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataSource = typeof(BE.Reservation);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(694, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(126, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "הצג את כל ההזמנות";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(711, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "בחר מספר הזמנה";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(659, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(161, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "הצג הזמנות עתידיות בלבד";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(355, 56);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton4.Size = new System.Drawing.Size(137, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "הצג לפי תאריך כניסה";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(226, 119);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "מתאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "עד תאריך";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 104);
            this.button2.TabIndex = 13;
            this.button2.Text = "הצג תוצאות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tourAgencyBindingSource
            // 
            this.tourAgencyBindingSource.DataSource = typeof(BE.TourAgency);
            // 
            // tourAgencyBindingSource1
            // 
            this.tourAgencyBindingSource1.DataSource = typeof(BE.TourAgency);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 53);
            this.button3.TabIndex = 14;
            this.button3.Text = "בחר וערוך הזמנה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 53);
            this.button4.TabIndex = 15;
            this.button4.Text = "יציאה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewreservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 478);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewreservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מציג ההזמנות";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tourAgencyBindingSource1;
        private System.Windows.Forms.BindingSource tourAgencyBindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortOrder_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCheck_In_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCheck_Out_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourAgencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatePriceDataGridViewTextBoxColumn;
    }
}