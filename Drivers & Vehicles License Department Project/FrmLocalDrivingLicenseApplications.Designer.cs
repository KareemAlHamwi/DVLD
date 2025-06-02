namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmLocalDrivingLicenseApplications {
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            comSearchStatus = new ComboBox();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            dataLDLApplicationsView = new DataGridView();
            txtSearch = new TextBox();
            lblRecords = new Label();
            comLDLApplicationsColumns = new ComboBox();
            lblFilterBy = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            cmsLDLApplications = new ContextMenuStrip(components);
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            showToolStripMenuItem = new ToolStripMenuItem();
            lblLocalDrivingLicenseApplications = new Label();
            ((System.ComponentModel.ISupportInitialize)dataLDLApplicationsView).BeginInit();
            cmsLDLApplications.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.Location = new Point(1223, 699);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 50);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Enabled = false;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(338, 30);
            phoneCallToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(338, 30);
            sendEmailToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = SystemColors.ControlText;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(335, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(338, 30);
            deleteToolStripMenuItem.Text = "Delete Application";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(338, 30);
            editToolStripMenuItem.Text = "Edit Application";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(335, 6);
            // 
            // comSearchStatus
            // 
            comSearchStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comSearchStatus.Font = new Font("Segoe UI", 13F);
            comSearchStatus.FormattingEnabled = true;
            comSearchStatus.Items.AddRange(new object[] { "New", "Completed", "Cancelled" });
            comSearchStatus.Location = new Point(323, 154);
            comSearchStatus.Name = "comSearchStatus";
            comSearchStatus.Size = new Size(180, 31);
            comSearchStatus.TabIndex = 11;
            comSearchStatus.SelectedIndexChanged += comSearchStatus_SelectedIndexChanged;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(338, 30);
            showDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // dataLDLApplicationsView
            // 
            dataLDLApplicationsView.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataLDLApplicationsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataLDLApplicationsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataLDLApplicationsView.DefaultCellStyle = dataGridViewCellStyle4;
            dataLDLApplicationsView.Location = new Point(9, 191);
            dataLDLApplicationsView.Name = "dataLDLApplicationsView";
            dataLDLApplicationsView.ReadOnly = true;
            dataLDLApplicationsView.ScrollBars = ScrollBars.Vertical;
            dataLDLApplicationsView.Size = new Size(1460, 500);
            dataLDLApplicationsView.TabIndex = 7;
            dataLDLApplicationsView.CellClick += dataLDLApplicationsView_CellClick;
            dataLDLApplicationsView.CellMouseDown += dataLDLApplicationsView_CellMouseDown;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.Location = new Point(323, 154);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 31);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 20F);
            lblRecords.Location = new Point(9, 712);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(168, 37);
            lblRecords.TabIndex = 15;
            lblRecords.Text = "# Records : 0";
            // 
            // comLDLApplicationsColumns
            // 
            comLDLApplicationsColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            comLDLApplicationsColumns.Font = new Font("Segoe UI", 13F);
            comLDLApplicationsColumns.FormattingEnabled = true;
            comLDLApplicationsColumns.Items.AddRange(new object[] { "L.D.L AppID", "National No.", "Full Name", "Status" });
            comLDLApplicationsColumns.Location = new Point(128, 154);
            comLDLApplicationsColumns.Name = "comLDLApplicationsColumns";
            comLDLApplicationsColumns.Size = new Size(180, 31);
            comLDLApplicationsColumns.TabIndex = 9;
            comLDLApplicationsColumns.SelectedIndexChanged += comLDLApplicationsColumns_SelectedIndexChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 20F);
            lblFilterBy.Location = new Point(9, 148);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(124, 37);
            lblFilterBy.TabIndex = 12;
            lblFilterBy.Text = "Filter By :";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(1349, 699);
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
            btnAdd.Location = new Point(1399, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmsLDLApplications
            // 
            cmsLDLApplications.Font = new Font("Segoe UI", 13F);
            cmsLDLApplications.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, cancelApplicationToolStripMenuItem, toolStripSeparator3, sendEmailToolStripMenuItem, toolStripSeparator4, phoneCallToolStripMenuItem, toolStripSeparator5, showLicenseToolStripMenuItem, toolStripSeparator6, showToolStripMenuItem });
            cmsLDLApplications.Name = "cmsPeople";
            cmsLDLApplications.Size = new Size(339, 280);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(338, 30);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(335, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(335, 6);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(335, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(338, 30);
            showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(335, 6);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(338, 30);
            showToolStripMenuItem.Text = "Show Person License History";
            // 
            // lblLocalDrivingLicenseApplications
            // 
            lblLocalDrivingLicenseApplications.Font = new Font("Simple Bold Jut Out", 30F, FontStyle.Bold);
            lblLocalDrivingLicenseApplications.ForeColor = Color.Red;
            lblLocalDrivingLicenseApplications.Location = new Point(400, 30);
            lblLocalDrivingLicenseApplications.Name = "lblLocalDrivingLicenseApplications";
            lblLocalDrivingLicenseApplications.Size = new Size(720, 72);
            lblLocalDrivingLicenseApplications.TabIndex = 8;
            lblLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            // 
            // FrmLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 761);
            Controls.Add(btnRefresh);
            Controls.Add(comSearchStatus);
            Controls.Add(dataLDLApplicationsView);
            Controls.Add(txtSearch);
            Controls.Add(lblRecords);
            Controls.Add(comLDLApplicationsColumns);
            Controls.Add(lblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(lblLocalDrivingLicenseApplications);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLocalDrivingLicenseApplications";
            Text = "Local Driving License Applications";
            Load += FrmLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dataLDLApplicationsView).EndInit();
            cmsLDLApplications.ResumeLayout(false);
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
        private ToolStripSeparator toolStripSeparator1;
        private ComboBox comSearchStatus;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private DataGridView dataLDLApplicationsView;
        private TextBox txtSearch;
        private Label lblRecords;
        private ComboBox comLDLApplicationsColumns;
        private Label lblFilterBy;
        private Button btnClose;
        private Button btnAdd;
        private ContextMenuStrip cmsLDLApplications;
        private Label lblLocalDrivingLicenseApplications;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
    }
}