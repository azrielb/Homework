namespace PLForms
{
    partial class addtourangecy
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
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label tour_Agency_CodeLabel;
            System.Windows.Forms.Label tour_Agency_NameLabel;
            System.Windows.Forms.Label type_of_tour_agencyLabel;
            System.Windows.Forms.Label websiteLabel;
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.tourAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.tour_Agency_CodeLabel1 = new System.Windows.Forms.Label();
            this.tour_Agency_NameTextBox = new System.Windows.Forms.TextBox();
            this.type_of_tour_agencyComboBox = new System.Windows.Forms.ComboBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.button1add = new System.Windows.Forms.Button();
            this.button1cancel = new System.Windows.Forms.Button();
            contactLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            tour_Agency_CodeLabel = new System.Windows.Forms.Label();
            tour_Agency_NameLabel = new System.Windows.Forms.Label();
            type_of_tour_agencyLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(180, 128);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(57, 13);
            contactLabel.TabIndex = 0;
            contactLabel.Text = ":איש קשר";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(180, 159);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(41, 13);
            phoneNumLabel.TabIndex = 2;
            phoneNumLabel.Text = ":טלפון";
            // 
            // tour_Agency_CodeLabel
            // 
            tour_Agency_CodeLabel.AutoSize = true;
            tour_Agency_CodeLabel.Location = new System.Drawing.Point(180, 27);
            tour_Agency_CodeLabel.Name = "tour_Agency_CodeLabel";
            tour_Agency_CodeLabel.Size = new System.Drawing.Size(97, 13);
            tour_Agency_CodeLabel.TabIndex = 4;
            tour_Agency_CodeLabel.Text = ":קוד חברת תיירות";
            // 
            // tour_Agency_NameLabel
            // 
            tour_Agency_NameLabel.AutoSize = true;
            tour_Agency_NameLabel.Location = new System.Drawing.Point(180, 61);
            tour_Agency_NameLabel.Name = "tour_Agency_NameLabel";
            tour_Agency_NameLabel.Size = new System.Drawing.Size(63, 13);
            tour_Agency_NameLabel.TabIndex = 6;
            tour_Agency_NameLabel.Text = ":שם החברה";
            // 
            // type_of_tour_agencyLabel
            // 
            type_of_tour_agencyLabel.AutoSize = true;
            type_of_tour_agencyLabel.Location = new System.Drawing.Point(180, 93);
            type_of_tour_agencyLabel.Name = "type_of_tour_agencyLabel";
            type_of_tour_agencyLabel.Size = new System.Drawing.Size(53, 13);
            type_of_tour_agencyLabel.TabIndex = 8;
            type_of_tour_agencyLabel.Text = ":קטגוריה";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(180, 194);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(67, 13);
            websiteLabel.TabIndex = 10;
            websiteLabel.Text = ":כתובת אתר";
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(48, 121);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // tourAgencyBindingSource
            // 
            this.tourAgencyBindingSource.DataSource = typeof(BE.TourAgency);
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(48, 152);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneNumTextBox.TabIndex = 3;
            // 
            // tour_Agency_CodeLabel1
            // 
            this.tour_Agency_CodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "Tour_Agency_Code", true));
            this.tour_Agency_CodeLabel1.Location = new System.Drawing.Point(48, 21);
            this.tour_Agency_CodeLabel1.Name = "tour_Agency_CodeLabel1";
            this.tour_Agency_CodeLabel1.Size = new System.Drawing.Size(121, 23);
            this.tour_Agency_CodeLabel1.TabIndex = 5;
            this.tour_Agency_CodeLabel1.Text = "label1";
            this.tour_Agency_CodeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tour_Agency_NameTextBox
            // 
            this.tour_Agency_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "Tour_Agency_Name", true));
            this.tour_Agency_NameTextBox.Location = new System.Drawing.Point(48, 54);
            this.tour_Agency_NameTextBox.Name = "tour_Agency_NameTextBox";
            this.tour_Agency_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.tour_Agency_NameTextBox.TabIndex = 7;
            // 
            // type_of_tour_agencyComboBox
            // 
            this.type_of_tour_agencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "type_of_tour_agency", true));
            this.type_of_tour_agencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_tour_agencyComboBox.FormattingEnabled = true;
            this.type_of_tour_agencyComboBox.Location = new System.Drawing.Point(48, 86);
            this.type_of_tour_agencyComboBox.Name = "type_of_tour_agencyComboBox";
            this.type_of_tour_agencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.type_of_tour_agencyComboBox.TabIndex = 9;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tourAgencyBindingSource, "website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(48, 187);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(121, 20);
            this.websiteTextBox.TabIndex = 11;
            // 
            // button1add
            // 
            this.button1add.Location = new System.Drawing.Point(48, 244);
            this.button1add.Name = "button1add";
            this.button1add.Size = new System.Drawing.Size(121, 29);
            this.button1add.TabIndex = 14;
            this.button1add.Text = "הוסף";
            this.button1add.UseVisualStyleBackColor = true;
            this.button1add.Click += new System.EventHandler(this.button1add_Click);
            // 
            // button1cancel
            // 
            this.button1cancel.Location = new System.Drawing.Point(183, 244);
            this.button1cancel.Name = "button1cancel";
            this.button1cancel.Size = new System.Drawing.Size(121, 29);
            this.button1cancel.TabIndex = 15;
            this.button1cancel.Text = "ביטול";
            this.button1cancel.UseVisualStyleBackColor = true;
            this.button1cancel.Click += new System.EventHandler(this.button1cancel_Click);
            // 
            // addtourangecy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 297);
            this.Controls.Add(this.button1cancel);
            this.Controls.Add(this.button1add);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(tour_Agency_CodeLabel);
            this.Controls.Add(this.tour_Agency_CodeLabel1);
            this.Controls.Add(tour_Agency_NameLabel);
            this.Controls.Add(this.tour_Agency_NameTextBox);
            this.Controls.Add(type_of_tour_agencyLabel);
            this.Controls.Add(this.type_of_tour_agencyComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "addtourangecy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addtourangecy";
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tourAgencyBindingSource;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Label tour_Agency_CodeLabel1;
        private System.Windows.Forms.TextBox tour_Agency_NameTextBox;
        private System.Windows.Forms.ComboBox type_of_tour_agencyComboBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.Button button1add;
        private System.Windows.Forms.Button button1cancel;
    }
}