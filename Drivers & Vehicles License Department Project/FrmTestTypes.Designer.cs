namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmTestTypes {
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
            lblApplicationTypesManagement = new Label();
            cmsTestTypes = new ContextMenuStrip(components);
            editTestToolStripMenuItem = new ToolStripMenuItem();
            dataTestTypesView = new DataGridView();
            lblRecords = new Label();
            btnClose = new Button();
            cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTestTypesView).BeginInit();
            SuspendLayout();
            // 
            // lblApplicationTypesManagement
            // 
            lblApplicationTypesManagement.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblApplicationTypesManagement.ForeColor = Color.Red;
            lblApplicationTypesManagement.Location = new Point(297, 9);
            lblApplicationTypesManagement.Name = "lblApplicationTypesManagement";
            lblApplicationTypesManagement.Size = new Size(453, 52);
            lblApplicationTypesManagement.TabIndex = 28;
            lblApplicationTypesManagement.Text = "Test Types Management";
            // 
            // cmsTestTypes
            // 
            cmsTestTypes.Font = new Font("Segoe UI", 13F);
            cmsTestTypes.Items.AddRange(new ToolStripItem[] { editTestToolStripMenuItem });
            cmsTestTypes.Name = "cmsPeople";
            cmsTestTypes.Size = new Size(192, 34);
            // 
            // editTestToolStripMenuItem
            // 
            editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            editTestToolStripMenuItem.Size = new Size(191, 30);
            editTestToolStripMenuItem.Text = "Edit Test Type";
            editTestToolStripMenuItem.Click += editTestToolStripMenuItem_Click;
            // 
            // dataTestTypesView
            // 
            dataTestTypesView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataTestTypesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataTestTypesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataTestTypesView.DefaultCellStyle = dataGridViewCellStyle2;
            dataTestTypesView.Location = new Point(12, 78);
            dataTestTypesView.Name = "dataTestTypesView";
            dataTestTypesView.ReadOnly = true;
            dataTestTypesView.ScrollBars = ScrollBars.Vertical;
            dataTestTypesView.Size = new Size(1060, 500);
            dataTestTypesView.TabIndex = 2;
            dataTestTypesView.CellClick += dataTestTypesView_CellClick;
            dataTestTypesView.CellMouseDown += dataTestTypesView_CellMouseDown;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 20F);
            lblRecords.Location = new Point(12, 597);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(168, 37);
            lblRecords.TabIndex = 29;
            lblRecords.Text = "# Records : 0";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(952, 590);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 652);
            Controls.Add(lblApplicationTypesManagement);
            Controls.Add(dataTestTypesView);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTestTypes";
            Text = "Test Types Management";
            Load += FrmTestTypes_Load;
            cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTestTypesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApplicationTypesManagement;
        private ContextMenuStrip cmsTestTypes;
        private DataGridView dataTestTypesView;
        private Label lblRecords;
        private Button btnClose;
        private ToolStripMenuItem editTestToolStripMenuItem;
    }
}