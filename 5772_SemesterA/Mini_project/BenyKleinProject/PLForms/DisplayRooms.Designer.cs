namespace PLForms
{
    partial class DisplayRooms
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
            this.roomCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelofroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badsNumberAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badsNumberChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exposuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seaviewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.airConditioningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hafradaYeuditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.miniBarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomCodeDataGridViewTextBoxColumn,
            this.levelofroomDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.badsNumberAdultsDataGridViewTextBoxColumn,
            this.badsNumberChildrenDataGridViewTextBoxColumn,
            this.exposuresDataGridViewTextBoxColumn,
            this.seaviewDataGridViewCheckBoxColumn,
            this.airConditioningDataGridViewCheckBoxColumn,
            this.hafradaYeuditDataGridViewCheckBoxColumn,
            this.miniBarDataGridViewCheckBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomBindingSource, "Room_Code", true));
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(577, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomCodeDataGridViewTextBoxColumn
            // 
            this.roomCodeDataGridViewTextBoxColumn.DataPropertyName = "Room_Code";
            this.roomCodeDataGridViewTextBoxColumn.HeaderText = "מספר חדר";
            this.roomCodeDataGridViewTextBoxColumn.Name = "roomCodeDataGridViewTextBoxColumn";
            this.roomCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomCodeDataGridViewTextBoxColumn.Width = 82;
            // 
            // levelofroomDataGridViewTextBoxColumn
            // 
            this.levelofroomDataGridViewTextBoxColumn.DataPropertyName = "level_of_room";
            this.levelofroomDataGridViewTextBoxColumn.HeaderText = "קטגוריה";
            this.levelofroomDataGridViewTextBoxColumn.Name = "levelofroomDataGridViewTextBoxColumn";
            this.levelofroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelofroomDataGridViewTextBoxColumn.Width = 75;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.ToolTipText = "מחיר חדר ללילה";
            this.costDataGridViewTextBoxColumn.Width = 57;
            // 
            // badsNumberAdultsDataGridViewTextBoxColumn
            // 
            this.badsNumberAdultsDataGridViewTextBoxColumn.DataPropertyName = "BadsNumberAdults";
            this.badsNumberAdultsDataGridViewTextBoxColumn.HeaderText = "מבוגרים";
            this.badsNumberAdultsDataGridViewTextBoxColumn.Name = "badsNumberAdultsDataGridViewTextBoxColumn";
            this.badsNumberAdultsDataGridViewTextBoxColumn.ReadOnly = true;
            this.badsNumberAdultsDataGridViewTextBoxColumn.ToolTipText = "מספר מיטות מבוגרים";
            this.badsNumberAdultsDataGridViewTextBoxColumn.Width = 75;
            // 
            // badsNumberChildrenDataGridViewTextBoxColumn
            // 
            this.badsNumberChildrenDataGridViewTextBoxColumn.DataPropertyName = "BadsNumberChildren";
            this.badsNumberChildrenDataGridViewTextBoxColumn.HeaderText = "ילדים";
            this.badsNumberChildrenDataGridViewTextBoxColumn.Name = "badsNumberChildrenDataGridViewTextBoxColumn";
            this.badsNumberChildrenDataGridViewTextBoxColumn.ReadOnly = true;
            this.badsNumberChildrenDataGridViewTextBoxColumn.ToolTipText = "מספר מיטות ילדים";
            this.badsNumberChildrenDataGridViewTextBoxColumn.Width = 63;
            // 
            // exposuresDataGridViewTextBoxColumn
            // 
            this.exposuresDataGridViewTextBoxColumn.DataPropertyName = "exposures";
            this.exposuresDataGridViewTextBoxColumn.HeaderText = "כיוונים";
            this.exposuresDataGridViewTextBoxColumn.Name = "exposuresDataGridViewTextBoxColumn";
            this.exposuresDataGridViewTextBoxColumn.ReadOnly = true;
            this.exposuresDataGridViewTextBoxColumn.Width = 71;
            // 
            // seaviewDataGridViewCheckBoxColumn
            // 
            this.seaviewDataGridViewCheckBoxColumn.DataPropertyName = "Seaview";
            this.seaviewDataGridViewCheckBoxColumn.HeaderText = "S";
            this.seaviewDataGridViewCheckBoxColumn.Name = "seaviewDataGridViewCheckBoxColumn";
            this.seaviewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.seaviewDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seaviewDataGridViewCheckBoxColumn.ToolTipText = "מול הים";
            this.seaviewDataGridViewCheckBoxColumn.Width = 20;
            // 
            // airConditioningDataGridViewCheckBoxColumn
            // 
            this.airConditioningDataGridViewCheckBoxColumn.DataPropertyName = "AirConditioning";
            this.airConditioningDataGridViewCheckBoxColumn.HeaderText = "A";
            this.airConditioningDataGridViewCheckBoxColumn.Name = "airConditioningDataGridViewCheckBoxColumn";
            this.airConditioningDataGridViewCheckBoxColumn.ReadOnly = true;
            this.airConditioningDataGridViewCheckBoxColumn.ToolTipText = "מיזוג אוויר";
            this.airConditioningDataGridViewCheckBoxColumn.Width = 20;
            // 
            // hafradaYeuditDataGridViewCheckBoxColumn
            // 
            this.hafradaYeuditDataGridViewCheckBoxColumn.DataPropertyName = "HafradaYeudit";
            this.hafradaYeuditDataGridViewCheckBoxColumn.HeaderText = "H";
            this.hafradaYeuditDataGridViewCheckBoxColumn.Name = "hafradaYeuditDataGridViewCheckBoxColumn";
            this.hafradaYeuditDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hafradaYeuditDataGridViewCheckBoxColumn.ToolTipText = "הפרדה יהודית";
            this.hafradaYeuditDataGridViewCheckBoxColumn.Width = 21;
            // 
            // miniBarDataGridViewCheckBoxColumn
            // 
            this.miniBarDataGridViewCheckBoxColumn.DataPropertyName = "MiniBar";
            this.miniBarDataGridViewCheckBoxColumn.HeaderText = "M";
            this.miniBarDataGridViewCheckBoxColumn.Name = "miniBarDataGridViewCheckBoxColumn";
            this.miniBarDataGridViewCheckBoxColumn.ReadOnly = true;
            this.miniBarDataGridViewCheckBoxColumn.ToolTipText = "מיני בר";
            this.miniBarDataGridViewCheckBoxColumn.Width = 22;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(BE.Room);
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataSource = typeof(BE.Room);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "מחק";
            this.toolTip2.SetToolTip(this.button2, "בחר חדר ומחק");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "ערוך";
            this.toolTip1.SetToolTip(this.button3, "בחר חדר וערוך פרטים");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(35, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "הצג תוצאות";
            this.toolTip1.SetToolTip(this.button1, "Enter הקלק או הקש ");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "בחר סינון";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "הצג הכול",
            "הצג חדרים שהוזמנו",
            "סנן לפי מחיר",
            "סנן לפי סוג החדר"});
            this.comboBox1.Location = new System.Drawing.Point(383, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(35, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(542, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "מתאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(249, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "עד תאריך";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(550, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ממחיר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(387, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "עד מחיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(539, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "רמת חדר";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(403, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(460, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(307, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(35, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(123, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = " או בחר מספר חדר";
            // 
            // DisplayRooms
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(631, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DisplayRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הצג חדרים";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelofroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badsNumberAdultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badsNumberChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exposuresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seaviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn airConditioningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hafradaYeuditDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn miniBarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
    }
}