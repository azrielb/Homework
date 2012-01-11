namespace PLForms
{
    partial class updatereservation
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
            System.Windows.Forms.Label orderDiscountLabel;
            System.Windows.Forms.Label check_In_DateLabel;
            System.Windows.Forms.Label check_Out_DateLabel;
            System.Windows.Forms.Label reservation_NumberLabel;
            System.Windows.Forms.Label tour_Agency_CodeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numericUpDowndiscount = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.check_In_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.check_Out_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            orderDiscountLabel = new System.Windows.Forms.Label();
            check_In_DateLabel = new System.Windows.Forms.Label();
            check_Out_DateLabel = new System.Windows.Forms.Label();
            reservation_NumberLabel = new System.Windows.Forms.Label();
            tour_Agency_CodeLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndiscount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDiscountLabel
            // 
            orderDiscountLabel.AutoSize = true;
            orderDiscountLabel.Location = new System.Drawing.Point(216, 72);
            orderDiscountLabel.Name = "orderDiscountLabel";
            orderDiscountLabel.Size = new System.Drawing.Size(109, 13);
            orderDiscountLabel.TabIndex = 73;
            orderDiscountLabel.Text = "אחוז הנחה לקבוצות";
            // 
            // check_In_DateLabel
            // 
            check_In_DateLabel.AutoSize = true;
            check_In_DateLabel.Location = new System.Drawing.Point(595, 47);
            check_In_DateLabel.Name = "check_In_DateLabel";
            check_In_DateLabel.Size = new System.Drawing.Size(74, 13);
            check_In_DateLabel.TabIndex = 60;
            check_In_DateLabel.Text = "תאריך כניסה";
            // 
            // check_Out_DateLabel
            // 
            check_Out_DateLabel.AutoSize = true;
            check_Out_DateLabel.Location = new System.Drawing.Point(595, 73);
            check_Out_DateLabel.Name = "check_Out_DateLabel";
            check_Out_DateLabel.Size = new System.Drawing.Size(75, 13);
            check_Out_DateLabel.TabIndex = 62;
            check_Out_DateLabel.Text = "תאריך יציאה";
            // 
            // reservation_NumberLabel
            // 
            reservation_NumberLabel.AutoSize = true;
            reservation_NumberLabel.Location = new System.Drawing.Point(600, 20);
            reservation_NumberLabel.Name = "reservation_NumberLabel";
            reservation_NumberLabel.Size = new System.Drawing.Size(68, 13);
            reservation_NumberLabel.TabIndex = 64;
            reservation_NumberLabel.Text = "מספר הזמנה";
            // 
            // tour_Agency_CodeLabel
            // 
            tour_Agency_CodeLabel.AutoSize = true;
            tour_Agency_CodeLabel.Location = new System.Drawing.Point(216, 47);
            tour_Agency_CodeLabel.Name = "tour_Agency_CodeLabel";
            tour_Agency_CodeLabel.Size = new System.Drawing.Size(81, 13);
            tour_Agency_CodeLabel.TabIndex = 65;
            tour_Agency_CodeLabel.Text = "סוכנות תיירות";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(72, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 117);
            this.panel3.TabIndex = 78;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "הצג הכול",
            "סנן לפי מחיר",
            "סנן לפי סוג החדר"});
            this.comboBox3.Location = new System.Drawing.Point(374, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 21);
            this.comboBox3.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "הפעל מסנן";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(17, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 46);
            this.button6.TabIndex = 58;
            this.button6.Text = "הצג תוצאות";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(298, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(451, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 56;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(394, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(530, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "רמת חדר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(378, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "עד מחיר";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(541, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "ממחיר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(310, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = ":חדרים שנוספו להזמנה, להסרת חדר בחר חדר ולחץ על מחק חדרים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(323, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = ":חדרים פנויים בתאריכים שבחרת, בחר חדר ולחץ על הוסף חדרים";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(197, 451);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(471, 127);
            this.dataGridView2.TabIndex = 75;
            // 
            // numericUpDowndiscount
            // 
            this.numericUpDowndiscount.Location = new System.Drawing.Point(76, 69);
            this.numericUpDowndiscount.Name = "numericUpDowndiscount";
            this.numericUpDowndiscount.Size = new System.Drawing.Size(135, 20);
            this.numericUpDowndiscount.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(502, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 24);
            this.panel2.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(54, 6);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(73, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 127);
            this.button4.TabIndex = 71;
            this.button4.Text = "מחק חדרים";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(197, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(471, 127);
            this.dataGridView1.TabIndex = 70;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(78, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 69;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "הזמנה קבוצתית";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(197, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 68;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "הזמנת יחיד";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 127);
            this.button1.TabIndex = 67;
            this.button1.Text = "הוסף חדרים";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 66;
            // 
            // check_In_DateDateTimePicker
            // 
            this.check_In_DateDateTimePicker.Location = new System.Drawing.Point(389, 44);
            this.check_In_DateDateTimePicker.Name = "check_In_DateDateTimePicker";
            this.check_In_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.check_In_DateDateTimePicker.TabIndex = 61;
            // 
            // check_Out_DateDateTimePicker
            // 
            this.check_Out_DateDateTimePicker.Location = new System.Drawing.Point(389, 70);
            this.check_Out_DateDateTimePicker.Name = "check_Out_DateDateTimePicker";
            this.check_Out_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.check_Out_DateDateTimePicker.TabIndex = 63;
            // 
            // updatereservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.numericUpDowndiscount);
            this.Controls.Add(orderDiscountLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(check_In_DateLabel);
            this.Controls.Add(this.check_In_DateDateTimePicker);
            this.Controls.Add(check_Out_DateLabel);
            this.Controls.Add(this.check_Out_DateDateTimePicker);
            this.Controls.Add(reservation_NumberLabel);
            this.Controls.Add(tour_Agency_CodeLabel);
            this.Name = "updatereservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatereservation";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numericUpDowndiscount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker check_In_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker check_Out_DateDateTimePicker;
    }
}