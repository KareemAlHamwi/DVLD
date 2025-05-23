﻿namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmApplicationTypes {
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
            lblApplicationTypesManagement = new Label();
            cmsApplicationTypes = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            dataApplicationTypesView = new DataGridView();
            lblRecords = new Label();
            btnClose = new Button();
            cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataApplicationTypesView).BeginInit();
            SuspendLayout();
            // 
            // lblApplicationTypesManagement
            // 
            lblApplicationTypesManagement.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblApplicationTypesManagement.ForeColor = Color.Red;
            lblApplicationTypesManagement.Location = new Point(77, 9);
            lblApplicationTypesManagement.Name = "lblApplicationTypesManagement";
            lblApplicationTypesManagement.Size = new Size(571, 52);
            lblApplicationTypesManagement.TabIndex = 18;
            lblApplicationTypesManagement.Text = "Application Types Management";
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.Font = new Font("Segoe UI", 13F);
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            cmsApplicationTypes.Name = "cmsPeople";
            cmsApplicationTypes.Size = new Size(252, 34);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(251, 30);
            editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // dataApplicationTypesView
            // 
            dataApplicationTypesView.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataApplicationTypesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataApplicationTypesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataApplicationTypesView.DefaultCellStyle = dataGridViewCellStyle4;
            dataApplicationTypesView.Location = new Point(12, 75);
            dataApplicationTypesView.Name = "dataApplicationTypesView";
            dataApplicationTypesView.ReadOnly = true;
            dataApplicationTypesView.ScrollBars = ScrollBars.Vertical;
            dataApplicationTypesView.Size = new Size(713, 500);
            dataApplicationTypesView.TabIndex = 2;
            dataApplicationTypesView.CellClick += dataApplicationTypesView_CellClick;
            dataApplicationTypesView.CellMouseDown += dataApplicationTypesView_CellMouseDown;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 20F);
            lblRecords.Location = new Point(12, 594);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(168, 37);
            lblRecords.TabIndex = 25;
            lblRecords.Text = "# Records : 0";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(604, 581);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 638);
            Controls.Add(lblApplicationTypesManagement);
            Controls.Add(dataApplicationTypesView);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmApplicationTypes";
            Text = "Application Types Management";
            Load += FrmApplicationTypes_Load;
            cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataApplicationTypesView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApplicationTypesManagement;
        private ContextMenuStrip cmsApplicationTypes;
        private DataGridView dataApplicationTypesView;
        private Label lblRecords;
        private Button btnClose;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}