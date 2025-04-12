namespace Drivers_And_Vehicles_License_Department_Project {
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblPeopleManagement = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            lblFilterBy = new Label();
            comPeopleColumns = new ComboBox();
            lblRecords = new Label();
            txtSearch = new TextBox();
            dataPeopleView = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            comSearchGender = new ComboBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPeopleView).BeginInit();
            cmsPeople.SuspendLayout();
            SuspendLayout();
            // 
            // lblPeopleManagement
            // 
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
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(1352, 699);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 6;
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
            comPeopleColumns.Items.AddRange(new object[] { "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Birthdate", "Gender", "Phone", "Email", "Nationality" });
            comPeopleColumns.Location = new Point(131, 154);
            comPeopleColumns.Name = "comPeopleColumns";
            comPeopleColumns.Size = new Size(180, 31);
            comPeopleColumns.TabIndex = 1;
            comPeopleColumns.SelectedIndexChanged += comPeopleColumns_SelectedIndexChanged;
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
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // dataPeopleView
            // 
            dataPeopleView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPeopleView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataPeopleView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPeopleView.DefaultCellStyle = dataGridViewCellStyle2;
            dataPeopleView.Location = new Point(12, 191);
            dataPeopleView.Name = "dataPeopleView";
            dataPeopleView.ReadOnly = true;
            dataPeopleView.ScrollBars = ScrollBars.Vertical;
            dataPeopleView.Size = new Size(1460, 500);
            dataPeopleView.TabIndex = 0;
            dataPeopleView.CellClick += dataPersonsView_CellClick;
            dataPeopleView.CellMouseDown += dataPersonsView_CellMouseDown;
            // 
            // cmsPeople
            // 
            cmsPeople.Font = new Font("Segoe UI", 13F);
            cmsPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(217, 196);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(216, 30);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
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
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(216, 30);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
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
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(216, 30);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // comSearchGender
            // 
            comSearchGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comSearchGender.Font = new Font("Segoe UI", 13F);
            comSearchGender.FormattingEnabled = true;
            comSearchGender.Items.AddRange(new object[] { "Male", "Female" });
            comSearchGender.Location = new Point(326, 154);
            comSearchGender.Name = "comSearchGender";
            comSearchGender.Size = new Size(180, 31);
            comSearchGender.TabIndex = 3;
            comSearchGender.SelectedIndexChanged += comSearchGender_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.Location = new Point(1226, 699);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1484, 761);
            Controls.Add(btnRefresh);
            Controls.Add(comSearchGender);
            Controls.Add(dataPeopleView);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "People Management";
            Load += FrmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dataPeopleView).EndInit();
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
        private DataGridView dataPeopleView;
        private ContextMenuStrip cmsPeople;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox comSearchGender;
        private Button btnRefresh;
    }
}
