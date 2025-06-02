namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmNewLocalDrivingLicenseApplication {
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
            errorProvider = new ErrorProvider(components);
            btnSave = new Button();
            btnClose = new Button();
            lblNewLDLApplications = new Label();
            btnNext = new Button();
            lblLDLApplicationsID = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ctrlPersonInfoWithFilter = new ctrlPersonCardWithFilter();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            comLicenseClass = new ComboBox();
            lblCreatedBy = new Label();
            lblApplicationFees = new Label();
            lblApplicationDate = new Label();
            label5 = new Label();
            tabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(877, 650);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 39);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(789, 650);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 39);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblNewLDLApplications
            // 
            lblNewLDLApplications.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblNewLDLApplications.ForeColor = Color.Red;
            lblNewLDLApplications.Location = new Point(121, 18);
            lblNewLDLApplications.Name = "lblNewLDLApplications";
            lblNewLDLApplications.Size = new Size(706, 52);
            lblNewLDLApplications.TabIndex = 24;
            lblNewLDLApplications.Text = "New Local Driving License Applications";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 15F);
            btnNext.Location = new Point(857, 472);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 39);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblLDLApplicationsID
            // 
            lblLDLApplicationsID.AutoSize = true;
            lblLDLApplicationsID.Cursor = Cursors.SizeNESW;
            lblLDLApplicationsID.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLDLApplicationsID.Location = new Point(285, 81);
            lblLDLApplicationsID.Name = "lblLDLApplicationsID";
            lblLDLApplicationsID.Size = new Size(60, 34);
            lblLDLApplicationsID.TabIndex = 21;
            lblLDLApplicationsID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 127);
            label4.Name = "label4";
            label4.Size = new Size(164, 34);
            label4.TabIndex = 20;
            label4.Text = "Application Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 177);
            label3.Name = "label3";
            label3.Size = new Size(142, 34);
            label3.TabIndex = 19;
            label3.Text = "License Class:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 226);
            label1.Name = "label1";
            label1.Size = new Size(166, 34);
            label1.TabIndex = 18;
            label1.Text = "Application Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeNESW;
            label2.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 81);
            label2.Name = "label2";
            label2.Size = new Size(173, 34);
            label2.TabIndex = 17;
            label2.Text = "DL Application ID:";
            // 
            // ctrlPersonInfoWithFilter
            // 
            ctrlPersonInfoWithFilter.Location = new Point(6, 6);
            ctrlPersonInfoWithFilter.Name = "ctrlPersonInfoWithFilter";
            ctrlPersonInfoWithFilter.Size = new Size(921, 460);
            ctrlPersonInfoWithFilter.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ctrlPersonInfoWithFilter);
            tabPage1.Controls.Add(btnNext);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(934, 521);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personal Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comLicenseClass);
            tabPage2.Controls.Add(lblCreatedBy);
            tabPage2.Controls.Add(lblApplicationFees);
            tabPage2.Controls.Add(lblApplicationDate);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lblLDLApplicationsID);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(934, 521);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comLicenseClass
            // 
            comLicenseClass.FormattingEnabled = true;
            comLicenseClass.Location = new Point(285, 180);
            comLicenseClass.Name = "comLicenseClass";
            comLicenseClass.Size = new Size(314, 31);
            comLicenseClass.TabIndex = 26;
            comLicenseClass.SelectedIndexChanged += comLicenseClass_SelectedIndexChanged;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Cursor = Cursors.SizeNESW;
            lblCreatedBy.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(285, 271);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(60, 34);
            lblCreatedBy.TabIndex = 25;
            lblCreatedBy.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Cursor = Cursors.SizeNESW;
            lblApplicationFees.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(285, 226);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(60, 34);
            lblApplicationFees.TabIndex = 24;
            lblApplicationFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Cursor = Cursors.SizeNESW;
            lblApplicationDate.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(285, 127);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(60, 34);
            lblApplicationDate.TabIndex = 23;
            lblApplicationDate.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNESW;
            label5.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 271);
            label5.Name = "label5";
            label5.Size = new Size(117, 34);
            label5.TabIndex = 22;
            label5.Text = "Created By:";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Font = new Font("Segoe UI", 13F);
            tabControl.Location = new Point(8, 82);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(942, 557);
            tabControl.TabIndex = 21;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // FrmNewLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 697);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblNewLDLApplications);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewLocalDrivingLicenseApplication";
            Text = "New Local Driving License Application";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider;
        private Button btnSave;
        private Button btnClose;
        private Label lblNewLDLApplications;
        private TabControl tabControl;
        private TabPage tabPage1;
        private Drivers_And_Vehicles_License_Department_Project.ctrlPersonCardWithFilter ctrlPersonInfoWithFilter;
        private Button btnNext;
        private TabPage tabPage2;
        private Label lblLDLApplicationsID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label lblApplicationDate;
        private Label lblCreatedBy;
        private Label lblApplicationFees;
        private ComboBox comLicenseClass;
    }
}