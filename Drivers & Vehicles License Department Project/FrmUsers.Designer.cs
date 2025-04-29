namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmUsers {
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            comSearchGender = new ComboBox();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            dataUsersView = new DataGridView();
            txtSearch = new TextBox();
            lblRecords = new Label();
            comUsersColumns = new ComboBox();
            lblFilterBy = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            cmsUsers = new ContextMenuStrip(components);
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            lblUsersManagement = new Label();
            ((System.ComponentModel.ISupportInitialize)dataUsersView).BeginInit();
            cmsUsers.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.Location = new Point(926, 699);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 50);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(224, 30);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(224, 30);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = SystemColors.ControlText;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(224, 30);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(224, 30);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(224, 30);
            addNewToolStripMenuItem.Text = "Add New User";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // comSearchGender
            // 
            comSearchGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comSearchGender.Font = new Font("Segoe UI", 13F);
            comSearchGender.FormattingEnabled = true;
            comSearchGender.Items.AddRange(new object[] { "Male", "Female" });
            comSearchGender.Location = new Point(326, 155);
            comSearchGender.Name = "comSearchGender";
            comSearchGender.Size = new Size(180, 31);
            comSearchGender.TabIndex = 11;
            comSearchGender.SelectedIndexChanged += comSearchGender_SelectedIndexChanged;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(224, 30);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // dataUsersView
            // 
            dataUsersView.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataUsersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataUsersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataUsersView.DefaultCellStyle = dataGridViewCellStyle12;
            dataUsersView.Location = new Point(12, 192);
            dataUsersView.Name = "dataUsersView";
            dataUsersView.ReadOnly = true;
            dataUsersView.ScrollBars = ScrollBars.Vertical;
            dataUsersView.Size = new Size(1160, 500);
            dataUsersView.TabIndex = 7;
            dataUsersView.CellClick += dataUsersView_CellClick;
            dataUsersView.CellMouseDown += dataUsersView_CellMouseDown;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.Location = new Point(326, 155);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 31);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 20F);
            lblRecords.Location = new Point(12, 708);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(168, 37);
            lblRecords.TabIndex = 15;
            lblRecords.Text = "# Records : 0";
            // 
            // comUsersColumns
            // 
            comUsersColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            comUsersColumns.Font = new Font("Segoe UI", 13F);
            comUsersColumns.FormattingEnabled = true;
            comUsersColumns.Items.AddRange(new object[] { "User ID", "Person ID", "UserName", "Full Name", "IsActive" });
            comUsersColumns.Location = new Point(140, 155);
            comUsersColumns.Name = "comUsersColumns";
            comUsersColumns.Size = new Size(180, 31);
            comUsersColumns.TabIndex = 9;
            comUsersColumns.SelectedIndexChanged += comUsersColumns_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 20F);
            lblFilterBy.Location = new Point(12, 149);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(124, 37);
            lblFilterBy.TabIndex = 12;
            lblFilterBy.Text = "Filter By :";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(1052, 699);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(1102, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmsUsers
            // 
            cmsUsers.Font = new Font("Segoe UI", 13F);
            cmsUsers.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsUsers.Name = "cmsPeople";
            cmsUsers.Size = new Size(225, 248);
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(224, 30);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // lblUsersManagement
            // 
            lblUsersManagement.Font = new Font("Simple Bold Jut Out", 50F, FontStyle.Bold);
            lblUsersManagement.ForeColor = Color.Red;
            lblUsersManagement.Location = new Point(251, 9);
            lblUsersManagement.Name = "lblUsersManagement";
            lblUsersManagement.Size = new Size(696, 98);
            lblUsersManagement.TabIndex = 8;
            lblUsersManagement.Text = "Users Management";
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnRefresh);
            Controls.Add(comSearchGender);
            Controls.Add(dataUsersView);
            Controls.Add(txtSearch);
            Controls.Add(lblRecords);
            Controls.Add(comUsersColumns);
            Controls.Add(lblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(lblUsersManagement);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users Management";
            Load += FrmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataUsersView).EndInit();
            cmsUsers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ComboBox comSearchGender;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private DataGridView dataUsersView;
        private TextBox txtSearch;
        private Label lblRecords;
        private ComboBox comUsersColumns;
        private Label lblFilterBy;
        private Button btnClose;
        private Button btnAdd;
        private ContextMenuStrip cmsUsers;
        private Label lblUsersManagement;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}