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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            lblFilterBylblFilterBy = new Label();
            comPesonColumns = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            dataPersonsView = new DataGridView();
            colPersonID = new DataGridViewTextBoxColumn();
            colNationalNumber = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colSecondName = new DataGridViewTextBoxColumn();
            colThirdName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBirthdate = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataPersonsView).BeginInit();
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
            // comPesonColumns
            // 
            comPesonColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            comPesonColumns.Font = new Font("Segoe UI", 13F);
            comPesonColumns.FormattingEnabled = true;
            comPesonColumns.Items.AddRange(new object[] { "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Gender", "Birthdate", "Nationality", "Phone", "Email" });
            comPesonColumns.Location = new Point(131, 154);
            comPesonColumns.Name = "comPesonColumns";
            comPesonColumns.Size = new Size(180, 31);
            comPesonColumns.TabIndex = 5;
            comPesonColumns.SelectedIndexChanged += comPesonColumns_SelectedIndexChanged;
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
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.Location = new Point(326, 154);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 31);
            txtSearch.TabIndex = 7;
            // 
            // dataPersonsView
            // 
            dataPersonsView.BackgroundColor = Color.White;
            dataPersonsView.BorderStyle = BorderStyle.None;
            dataPersonsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPersonsView.Columns.AddRange(new DataGridViewColumn[] { colPersonID, colNationalNumber, colFirstName, colSecondName, colThirdName, colLastName, colGender, colBirthdate, colNationality, colPhone, colEmail });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPersonsView.DefaultCellStyle = dataGridViewCellStyle1;
            dataPersonsView.Location = new Point(12, 191);
            dataPersonsView.Name = "dataPersonsView";
            dataPersonsView.ReadOnly = true;
            dataPersonsView.ScrollBars = ScrollBars.Vertical;
            dataPersonsView.Size = new Size(1460, 500);
            dataPersonsView.TabIndex = 8;
            // 
            // colPersonID
            // 
            colPersonID.HeaderText = "Person ID";
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 80;
            // 
            // colNationalNumber
            // 
            colNationalNumber.HeaderText = "National No.";
            colNationalNumber.Name = "colNationalNumber";
            colNationalNumber.ReadOnly = true;
            colNationalNumber.Width = 140;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 140;
            // 
            // colSecondName
            // 
            colSecondName.HeaderText = "Second Name";
            colSecondName.Name = "colSecondName";
            colSecondName.ReadOnly = true;
            colSecondName.Width = 140;
            // 
            // colThirdName
            // 
            colThirdName.HeaderText = "Third Name";
            colThirdName.Name = "colThirdName";
            colThirdName.ReadOnly = true;
            colThirdName.Width = 140;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 140;
            // 
            // colGender
            // 
            colGender.HeaderText = "Gender";
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 60;
            // 
            // colBirthdate
            // 
            colBirthdate.HeaderText = "Birthdate";
            colBirthdate.Name = "colBirthdate";
            colBirthdate.ReadOnly = true;
            colBirthdate.Width = 140;
            // 
            // colNationality
            // 
            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            colNationality.Width = 140;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 140;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 158;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1484, 761);
            Controls.Add(dataPersonsView);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(comPesonColumns);
            Controls.Add(lblFilterBylblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeople";
            Text = "People Management";
            ((System.ComponentModel.ISupportInitialize)dataPersonsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnClose;
        private Label lblFilterBylblFilterBy;
        private ComboBox comPesonColumns;
        private Label label2;
        private TextBox txtSearch;
        private DataGridView dataPersonsView;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colNationalNumber;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colSecondName;
        private DataGridViewTextBoxColumn colThirdName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthdate;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
    }
}