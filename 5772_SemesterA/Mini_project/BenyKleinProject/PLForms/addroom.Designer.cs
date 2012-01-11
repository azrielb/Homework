namespace PLForms
{
    partial class addroom
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label level_of_roomLabel;
            System.Windows.Forms.Label seaviewLabel;
            System.Windows.Forms.Label exposuresLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_of_roomComboBox = new System.Windows.Forms.ComboBox();
            this.seaviewCheckBox = new System.Windows.Forms.CheckBox();
            this.exposuresComboBox = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numbadsAdultNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numberbadscildnumeric = new System.Windows.Forms.NumericUpDown();
            this.checkBoxjueish = new System.Windows.Forms.CheckBox();
            this.checkBoxminibar = new System.Windows.Forms.CheckBox();
            this.aircondishenchekbox = new System.Windows.Forms.CheckBox();
            this.button1cancel = new System.Windows.Forms.Button();
            costLabel = new System.Windows.Forms.Label();
            level_of_roomLabel = new System.Windows.Forms.Label();
            seaviewLabel = new System.Windows.Forms.Label();
            exposuresLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbadsAdultNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberbadscildnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(149, 77);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(68, 13);
            costLabel.TabIndex = 1;
            costLabel.Text = "מחיר ללילה";
            // 
            // level_of_roomLabel
            // 
            level_of_roomLabel.AutoSize = true;
            level_of_roomLabel.Location = new System.Drawing.Point(149, 52);
            level_of_roomLabel.Name = "level_of_roomLabel";
            level_of_roomLabel.Size = new System.Drawing.Size(50, 13);
            level_of_roomLabel.TabIndex = 3;
            level_of_roomLabel.Text = "קטגוריה";
            // 
            // seaviewLabel
            // 
            seaviewLabel.AutoSize = true;
            seaviewLabel.Location = new System.Drawing.Point(150, 189);
            seaviewLabel.Name = "seaviewLabel";
            seaviewLabel.Size = new System.Drawing.Size(46, 13);
            seaviewLabel.TabIndex = 4;
            seaviewLabel.Text = "נוף לים";
            // 
            // exposuresLabel
            // 
            exposuresLabel.AutoSize = true;
            exposuresLabel.Location = new System.Drawing.Point(149, 158);
            exposuresLabel.Name = "exposuresLabel";
            exposuresLabel.Size = new System.Drawing.Size(66, 13);
            exposuresLabel.TabIndex = 6;
            exposuresLabel.Text = "כיוון אוויר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(151, 233);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 13);
            label4.TabIndex = 15;
            label4.Text = "מיני בר";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(151, 211);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 13);
            label5.TabIndex = 17;
            label5.Text = "הפרדה יהודית";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(151, 256);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 13);
            label6.TabIndex = 19;
            label6.Text = "מיזוג";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(38, 74);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 2;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(BE.Room);
            // 
            // level_of_roomComboBox
            // 
            this.level_of_roomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "level_of_room", true));
            this.level_of_roomComboBox.FormattingEnabled = true;
            this.level_of_roomComboBox.Location = new System.Drawing.Point(38, 47);
            this.level_of_roomComboBox.Name = "level_of_roomComboBox";
            this.level_of_roomComboBox.Size = new System.Drawing.Size(100, 21);
            this.level_of_roomComboBox.TabIndex = 4;
            // 
            // seaviewCheckBox
            // 
            this.seaviewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomBindingSource, "Seaview", true));
            this.seaviewCheckBox.Location = new System.Drawing.Point(125, 184);
            this.seaviewCheckBox.Name = "seaviewCheckBox";
            this.seaviewCheckBox.Size = new System.Drawing.Size(20, 24);
            this.seaviewCheckBox.TabIndex = 5;
            this.seaviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // exposuresComboBox
            // 
            this.exposuresComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "exposures", true));
            this.exposuresComboBox.FormattingEnabled = true;
            this.exposuresComboBox.Location = new System.Drawing.Point(38, 155);
            this.exposuresComboBox.Name = "exposuresComboBox";
            this.exposuresComboBox.Size = new System.Drawing.Size(100, 21);
            this.exposuresComboBox.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(50, 294);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 100);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "מספר מיטות  מבוגרים\r\n";
            // 
            // numbadsAdultNumeric
            // 
            this.numbadsAdultNumeric.Location = new System.Drawing.Point(89, 100);
            this.numbadsAdultNumeric.Name = "numbadsAdultNumeric";
            this.numbadsAdultNumeric.Size = new System.Drawing.Size(48, 20);
            this.numbadsAdultNumeric.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "מספר מיטות ילדים";
            // 
            // numberbadscildnumeric
            // 
            this.numberbadscildnumeric.Location = new System.Drawing.Point(89, 127);
            this.numberbadscildnumeric.Name = "numberbadscildnumeric";
            this.numberbadscildnumeric.Size = new System.Drawing.Size(48, 20);
            this.numberbadscildnumeric.TabIndex = 14;
            // 
            // checkBoxjueish
            // 
            this.checkBoxjueish.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomBindingSource, "Seaview", true));
            this.checkBoxjueish.Location = new System.Drawing.Point(125, 206);
            this.checkBoxjueish.Name = "checkBoxjueish";
            this.checkBoxjueish.Size = new System.Drawing.Size(20, 24);
            this.checkBoxjueish.TabIndex = 16;
            this.checkBoxjueish.UseVisualStyleBackColor = true;
            // 
            // checkBoxminibar
            // 
            this.checkBoxminibar.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomBindingSource, "Seaview", true));
            this.checkBoxminibar.Location = new System.Drawing.Point(125, 228);
            this.checkBoxminibar.Name = "checkBoxminibar";
            this.checkBoxminibar.Size = new System.Drawing.Size(20, 24);
            this.checkBoxminibar.TabIndex = 18;
            this.checkBoxminibar.UseVisualStyleBackColor = true;
            // 
            // aircondishenchekbox
            // 
            this.aircondishenchekbox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.roomBindingSource, "Seaview", true));
            this.aircondishenchekbox.Location = new System.Drawing.Point(125, 251);
            this.aircondishenchekbox.Name = "aircondishenchekbox";
            this.aircondishenchekbox.Size = new System.Drawing.Size(20, 24);
            this.aircondishenchekbox.TabIndex = 20;
            this.aircondishenchekbox.UseVisualStyleBackColor = true;
            // 
            // button1cancel
            // 
            this.button1cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1cancel.Location = new System.Drawing.Point(160, 294);
            this.button1cancel.Name = "button1cancel";
            this.button1cancel.Size = new System.Drawing.Size(75, 23);
            this.button1cancel.TabIndex = 21;
            this.button1cancel.Text = "ביטול";
            this.button1cancel.UseVisualStyleBackColor = true;
            this.button1cancel.Click += new System.EventHandler(this.button1cancel_Click);
            // 
            // addroom
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1cancel;
            this.ClientSize = new System.Drawing.Size(292, 354);
            this.Controls.Add(this.button1cancel);
            this.Controls.Add(label6);
            this.Controls.Add(this.aircondishenchekbox);
            this.Controls.Add(label5);
            this.Controls.Add(this.checkBoxminibar);
            this.Controls.Add(label4);
            this.Controls.Add(this.checkBoxjueish);
            this.Controls.Add(this.numberbadscildnumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numbadsAdultNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(exposuresLabel);
            this.Controls.Add(this.exposuresComboBox);
            this.Controls.Add(seaviewLabel);
            this.Controls.Add(this.seaviewCheckBox);
            this.Controls.Add(level_of_roomLabel);
            this.Controls.Add(this.level_of_roomComboBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Name = "addroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת חדר חדש";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbadsAdultNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberbadscildnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox level_of_roomComboBox;
        private System.Windows.Forms.CheckBox seaviewCheckBox;
        private System.Windows.Forms.ComboBox exposuresComboBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numbadsAdultNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberbadscildnumeric;
        private System.Windows.Forms.CheckBox checkBoxjueish;
        private System.Windows.Forms.CheckBox checkBoxminibar;
        private System.Windows.Forms.CheckBox aircondishenchekbox;
        private System.Windows.Forms.Button button1cancel;

    }
}