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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblPeopleManagement = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            lblFilterBy = new Label();
            comPeopleColumns = new ComboBox();
            lblRecords = new Label();
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
            cmsPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataPersonsView).BeginInit();
            cmsPeople.SuspendLayout();
            SuspendLayout();
            // 
            // lblPeopleManagement
            // 
            lblPeopleManagement.AutoSize = true;
            lblPeopleManagement.Font = new Font("Simple Bold Jut Out", 50F, FontStyle.Bold);
            lblPeopleManagement.ForeColor = Color.Red;
            lblPeopleManagement.Location = new Point(383, 9);
            lblPeopleManagement.Name = "lblPeopleManagement";
            lblPeopleManagement.Size = new Size(734, 98);
            lblPeopleManagement.TabIndex = 0;
            lblPeopleManagement.Text = "People Management";
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
            btnClose.Click += btnClose_Click;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 20F);
            lblFilterBy.Location = new Point(12, 148);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(124, 37);
            lblFilterBy.TabIndex = 4;
            lblFilterBy.Text = "Filter By :";
            // 
            // comPeopleColumns
            // 
            comPeopleColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            comPeopleColumns.Font = new Font("Segoe UI", 13F);
            comPeopleColumns.FormattingEnabled = true;
            comPeopleColumns.Items.AddRange(new object[] { "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Gender", "Birthdate", "Nationality", "Phone", "Email" });
            comPeopleColumns.Location = new Point(131, 154);
            comPeopleColumns.Name = "comPeopleColumns";
            comPeopleColumns.Size = new Size(180, 31);
            comPeopleColumns.TabIndex = 5;
            comPeopleColumns.SelectedIndexChanged += comPesonColumns_SelectedIndexChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 20F);
            lblRecords.Location = new Point(12, 710);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(168, 37);
            lblRecords.TabIndex = 6;
            lblRecords.Text = "# Records : 0";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
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
            dataPersonsView.CellMouseDown += dataPersonsView_CellMouseDown;
            // 
            // colPersonID
            // 
            colPersonID.DataPropertyName = "PersonID";
            colPersonID.HeaderText = "Person ID";
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 80;
            // 
            // colNationalNumber
            // 
            colNationalNumber.DataPropertyName = "NationalNo";
            colNationalNumber.HeaderText = "National No.";
            colNationalNumber.Name = "colNationalNumber";
            colNationalNumber.ReadOnly = true;
            colNationalNumber.Width = 140;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 140;
            // 
            // colSecondName
            // 
            colSecondName.DataPropertyName = "SecondName";
            colSecondName.HeaderText = "Second Name";
            colSecondName.Name = "colSecondName";
            colSecondName.ReadOnly = true;
            colSecondName.Width = 140;
            // 
            // colThirdName
            // 
            colThirdName.DataPropertyName = "ThirdName";
            colThirdName.HeaderText = "Third Name";
            colThirdName.Name = "colThirdName";
            colThirdName.ReadOnly = true;
            colThirdName.Width = 140;
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 140;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Gender";
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 60;
            // 
            // colBirthdate
            // 
            colBirthdate.DataPropertyName = "Birthdate";
            colBirthdate.HeaderText = "Birthdate";
            colBirthdate.Name = "colBirthdate";
            colBirthdate.ReadOnly = true;
            colBirthdate.Width = 140;
            // 
            // colNationality
            // 
            colNationality.DataPropertyName = "NationalityCountryID";
            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            colNationality.Width = 140;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 140;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 158;
            // 
            // cmsPeople
            // 
            cmsPeople.Font = new Font("Segoe UI", 13F);
            cmsPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(217, 218);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(216, 30);
            showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(216, 30);
            addNewToolStripMenuItem.Text = "Add New Person";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(216, 30);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(216, 30);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = SystemColors.ControlText;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(213, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(216, 30);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(216, 30);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1484, 761);
            Controls.Add(dataPersonsView);
            Controls.Add(txtSearch);
            Controls.Add(lblRecords);
            Controls.Add(comPeopleColumns);
            Controls.Add(lblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(lblPeopleManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeople";
            Text = "People Management";
            ((System.ComponentModel.ISupportInitialize)dataPersonsView).EndInit();
            cmsPeople.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPeopleManagement;
        private Button btnAdd;
        private Button btnClose;
        private Label lblFilterBy;
        private ComboBox comPeopleColumns;
        private Label lblRecords;
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
        private ContextMenuStrip cmsPeople;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}