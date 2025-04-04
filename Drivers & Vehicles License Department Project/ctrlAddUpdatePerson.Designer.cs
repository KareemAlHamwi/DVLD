namespace Drivers___Vehicles_License_Department_Project {
    partial class ctrlAddUpdatePerson {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DateTime MaxDate = DateTime.Now.AddYears(-18);

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            picboxPersonalPhoto = new PictureBox();
            linkSetImageInfo = new LinkLabel();
            groPersonInfo = new GroupBox();
            comCountries = new ComboBox();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            dateBirthdate = new DateTimePicker();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            txtAdress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtNationalNo = new TextBox();
            txtFirstName = new TextBox();
            linkRemoveImage = new LinkLabel();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picboxPersonalPhoto).BeginInit();
            groPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 7;
            label3.Text = "National No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 162);
            label4.Name = "label4";
            label4.Size = new Size(84, 34);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNESW;
            label5.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(322, 113);
            label5.Name = "label5";
            label5.Size = new Size(137, 34);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.SizeNESW;
            label6.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(383, 162);
            label6.Name = "label6";
            label6.Size = new Size(76, 34);
            label6.TabIndex = 10;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.SizeNESW;
            label7.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(369, 209);
            label7.Name = "label7";
            label7.Size = new Size(90, 34);
            label7.TabIndex = 11;
            label7.Text = "Country:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.SizeNESW;
            label8.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 257);
            label8.Name = "label8";
            label8.Size = new Size(93, 34);
            label8.TabIndex = 12;
            label8.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.SizeNESW;
            label9.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(59, 209);
            label9.Name = "label9";
            label9.Size = new Size(69, 34);
            label9.TabIndex = 13;
            label9.Text = "Email:";
            // 
            // picboxPersonalPhoto
            // 
            picboxPersonalPhoto.BorderStyle = BorderStyle.FixedSingle;
            picboxPersonalPhoto.Image = Properties.Resources.default_avatar;
            picboxPersonalPhoto.Location = new Point(680, 113);
            picboxPersonalPhoto.Name = "picboxPersonalPhoto";
            picboxPersonalPhoto.Size = new Size(189, 246);
            picboxPersonalPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picboxPersonalPhoto.TabIndex = 14;
            picboxPersonalPhoto.TabStop = false;
            // 
            // linkSetImageInfo
            // 
            linkSetImageInfo.AutoSize = true;
            linkSetImageInfo.Location = new Point(680, 362);
            linkSetImageInfo.Name = "linkSetImageInfo";
            linkSetImageInfo.Size = new Size(92, 25);
            linkSetImageInfo.TabIndex = 13;
            linkSetImageInfo.TabStop = true;
            linkSetImageInfo.Text = "Set Image";
            linkSetImageInfo.LinkClicked += linkSetImageInfo_LinkClicked;
            // 
            // groPersonInfo
            // 
            groPersonInfo.Controls.Add(comCountries);
            groPersonInfo.Controls.Add(radFemale);
            groPersonInfo.Controls.Add(radMale);
            groPersonInfo.Controls.Add(dateBirthdate);
            groPersonInfo.Controls.Add(txtLastName);
            groPersonInfo.Controls.Add(txtThirdName);
            groPersonInfo.Controls.Add(txtSecondName);
            groPersonInfo.Controls.Add(label13);
            groPersonInfo.Controls.Add(label12);
            groPersonInfo.Controls.Add(label11);
            groPersonInfo.Controls.Add(label10);
            groPersonInfo.Controls.Add(btnSave);
            groPersonInfo.Controls.Add(btnClose);
            groPersonInfo.Controls.Add(txtAdress);
            groPersonInfo.Controls.Add(txtEmail);
            groPersonInfo.Controls.Add(txtPhone);
            groPersonInfo.Controls.Add(txtNationalNo);
            groPersonInfo.Controls.Add(txtFirstName);
            groPersonInfo.Controls.Add(linkRemoveImage);
            groPersonInfo.Controls.Add(label2);
            groPersonInfo.Controls.Add(linkSetImageInfo);
            groPersonInfo.Controls.Add(picboxPersonalPhoto);
            groPersonInfo.Controls.Add(label9);
            groPersonInfo.Controls.Add(label8);
            groPersonInfo.Controls.Add(label7);
            groPersonInfo.Controls.Add(label6);
            groPersonInfo.Controls.Add(label5);
            groPersonInfo.Controls.Add(label4);
            groPersonInfo.Controls.Add(label3);
            groPersonInfo.Font = new Font("Segoe UI", 13F);
            groPersonInfo.Location = new Point(3, 3);
            groPersonInfo.Name = "groPersonInfo";
            groPersonInfo.Size = new Size(883, 418);
            groPersonInfo.TabIndex = 3;
            groPersonInfo.TabStop = false;
            // 
            // comCountries
            // 
            comCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            comCountries.FormattingEnabled = true;
            comCountries.Items.AddRange(new object[] { "Afghanistan ", "Albania  ", "Algeria ", "Andorra ", "Angola ", "Antigua", "Barbuda", "Argentina", "Armenia", "Austria", "Azerbaijan", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Channel Islands", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Côte d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "DR Congo", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Faeroe Islands", "Finland", "France", "French Guiana", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macao", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nepal", "Netherlands", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Réunion", "Romania", "Russia", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "State of Palestine", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "The Bahamas", "Timor-Leste", "Togo", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Venezuela", "Vietnam", "Western Sahara", "Yemen", "Zambia", "Zimbabwe" });
            comCountries.Location = new Point(465, 212);
            comCountries.Name = "comCountries";
            comCountries.Size = new Size(199, 31);
            comCountries.TabIndex = 11;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(218, 165);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(86, 29);
            radFemale.TabIndex = 8;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(134, 165);
            radMale.Name = "radMale";
            radMale.Size = new Size(68, 29);
            radMale.TabIndex = 7;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // dateBirthdate
            // 
            dateBirthdate.Format = DateTimePickerFormat.Short;
            dateBirthdate.Location = new Point(465, 113);
            dateBirthdate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateBirthdate.MaxDate = MaxDate;
            dateBirthdate.Name = "dateBirthdate";
            dateBirthdate.Size = new Size(199, 31);
            dateBirthdate.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(699, 63);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 31);
            txtLastName.TabIndex = 4;
            txtLastName.KeyPress += txtLastName_KeyPress;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(509, 63);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(170, 31);
            txtThirdName.TabIndex = 3;
            txtThirdName.KeyPress += txtThirdName_KeyPress;
            txtThirdName.Validating += txtThirdName_Validating;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(322, 63);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(170, 31);
            txtSecondName.TabIndex = 2;
            txtSecondName.KeyPress += txtSecondName_KeyPress;
            txtSecondName.Validating += txtSecondName_Validating;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Cursor = Cursors.SizeNESW;
            label13.Font = new Font("Simplified Arabic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(761, 26);
            label13.Name = "label13";
            label13.Size = new Size(49, 34);
            label13.TabIndex = 31;
            label13.Text = "Last";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.SizeNESW;
            label12.Font = new Font("Simplified Arabic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(571, 26);
            label12.Name = "label12";
            label12.Size = new Size(56, 34);
            label12.TabIndex = 30;
            label12.Text = "Third";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.SizeNESW;
            label11.Font = new Font("Simplified Arabic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(372, 26);
            label11.Name = "label11";
            label11.Size = new Size(76, 34);
            label11.TabIndex = 29;
            label11.Text = "Second";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.SizeNESW;
            label10.Font = new Font("Simplified Arabic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(199, 26);
            label10.Name = "label10";
            label10.Size = new Size(50, 34);
            label10.TabIndex = 28;
            label10.Text = "First";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 37);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(225, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 37);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(134, 260);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(530, 99);
            txtAdress.TabIndex = 12;
            txtAdress.Validating += txtAdress_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 31);
            txtEmail.TabIndex = 10;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(465, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(199, 31);
            txtPhone.TabIndex = 9;
            txtPhone.KeyPress += txtPhone_KeyPress;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtNationalNo
            // 
            txtNationalNo.Location = new Point(134, 116);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(170, 31);
            txtNationalNo.TabIndex = 5;
            txtNationalNo.KeyPress += txtNationalNo_KeyPress;
            txtNationalNo.Validating += txtNationalNo_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(134, 63);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 31);
            txtFirstName.TabIndex = 1;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // linkRemoveImage
            // 
            linkRemoveImage.AutoSize = true;
            linkRemoveImage.Location = new Point(796, 362);
            linkRemoveImage.Name = "linkRemoveImage";
            linkRemoveImage.Size = new Size(76, 25);
            linkRemoveImage.TabIndex = 14;
            linkRemoveImage.TabStop = true;
            linkRemoveImage.Text = "Remove";
            linkRemoveImage.LinkClicked += linkRemoveImage_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeNESW;
            label2.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 34);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ctrlAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groPersonInfo);
            Name = "ctrlAddUpdatePerson";
            Size = new Size(889, 428);
            ((System.ComponentModel.ISupportInitialize)picboxPersonalPhoto).EndInit();
            groPersonInfo.ResumeLayout(false);
            groPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox picboxPersonalPhoto;
        private LinkLabel linkSetImageInfo;
        private GroupBox groPersonInfo;
        private Label label2;
        private LinkLabel linkRemoveImage;
        private TextBox txtFirstName;
        private TextBox txtNationalNo;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAdress;
        private Button btnClose;
        private Button btnSave;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private DateTimePicker dateBirthdate;
        private RadioButton radMale;
        private RadioButton radFemale;
        private ComboBox comCountries;
        private ErrorProvider errorProvider;
    }
}
