namespace Drivers___Vehicles_License_Department_Project {
    partial class FrmPeople {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            liViPeople = new ListView();
            cohPersonID = new ColumnHeader();
            cohNationalNumber = new ColumnHeader();
            cohFirstName = new ColumnHeader();
            cohSecondName = new ColumnHeader();
            cohThirdName = new ColumnHeader();
            cohLastName = new ColumnHeader();
            cohGender = new ColumnHeader();
            cohBirthDate = new ColumnHeader();
            cohNationality = new ColumnHeader();
            cohPhone = new ColumnHeader();
            cohEmail = new ColumnHeader();
            btnAdd = new Button();
            btnClose = new Button();
            lblFilterBylblFilterBy = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simple Bold Jut Out", 50F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(383, 9);
            label1.Name = "label1";
            label1.Size = new Size(734, 98);
            label1.TabIndex = 0;
            label1.Text = "People Management";
            // 
            // liViPeople
            // 
            liViPeople.Columns.AddRange(new ColumnHeader[] { cohPersonID, cohNationalNumber, cohFirstName, cohSecondName, cohThirdName, cohLastName, cohGender, cohBirthDate, cohNationality, cohPhone, cohEmail });
            liViPeople.Font = new Font("Segoe UI", 13F);
            liViPeople.Location = new Point(12, 191);
            liViPeople.Name = "liViPeople";
            liViPeople.Size = new Size(1460, 500);
            liViPeople.TabIndex = 1;
            liViPeople.UseCompatibleStateImageBehavior = false;
            liViPeople.View = View.Details;
            // 
            // cohPersonID
            // 
            cohPersonID.Text = "Person ID";
            cohPersonID.Width = 90;
            // 
            // cohNationalNumber
            // 
            cohNationalNumber.Text = "National No.";
            cohNationalNumber.Width = 150;
            // 
            // cohFirstName
            // 
            cohFirstName.Text = "First Name";
            cohFirstName.Width = 140;
            // 
            // cohSecondName
            // 
            cohSecondName.Text = "Second Name";
            cohSecondName.Width = 140;
            // 
            // cohThirdName
            // 
            cohThirdName.Text = "Third Name";
            cohThirdName.Width = 140;
            // 
            // cohLastName
            // 
            cohLastName.Text = "Last Name";
            cohLastName.Width = 140;
            // 
            // cohGender
            // 
            cohGender.Text = "Gender";
            cohGender.Width = 75;
            // 
            // cohBirthDate
            // 
            cohBirthDate.Text = "Birth Date";
            cohBirthDate.Width = 140;
            // 
            // cohNationality
            // 
            cohNationality.Text = "Nationality";
            cohNationality.Width = 140;
            // 
            // cohPhone
            // 
            cohPhone.Text = "Phone";
            cohPhone.Width = 150;
            // 
            // cohEmail
            // 
            cohEmail.Text = "Email";
            cohEmail.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(1402, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(1352, 699);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblFilterBylblFilterBy
            // 
            lblFilterBylblFilterBy.AutoSize = true;
            lblFilterBylblFilterBy.Font = new Font("Segoe UI", 20F);
            lblFilterBylblFilterBy.Location = new Point(12, 148);
            lblFilterBylblFilterBy.Name = "lblFilterBylblFilterBy";
            lblFilterBylblFilterBy.Size = new Size(124, 37);
            lblFilterBylblFilterBy.TabIndex = 4;
            lblFilterBylblFilterBy.Text = "Filter By :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 710);
            label2.Name = "label2";
            label2.Size = new Size(168, 37);
            label2.TabIndex = 6;
            label2.Text = "# Records : 0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 7;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(lblFilterBylblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(liViPeople);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeople";
            Text = "People Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView liViPeople;
        private Button btnAdd;
        private Button btnClose;
        private Label lblFilterBylblFilterBy;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private ColumnHeader cohPersonID;
        private ColumnHeader cohNationalNumber;
        private ColumnHeader cohFirstName;
        private ColumnHeader cohSecondName;
        private ColumnHeader cohThirdName;
        private ColumnHeader cohLastName;
        private ColumnHeader cohGender;
        private ColumnHeader cohBirthDate;
        private ColumnHeader cohNationality;
        private ColumnHeader cohPhone;
        private ColumnHeader cohEmail;
    }
}