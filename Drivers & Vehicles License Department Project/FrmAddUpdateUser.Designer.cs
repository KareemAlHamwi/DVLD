namespace Drivers___Vehicles_License_Department_Project {
    partial class FrmAddUpdateUser {
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            ctrlPersonInfoWithFilter = new ctrlPersonCardWithFilter();
            btnNext = new Button();
            tabPage2 = new TabPage();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            chBoxIsActive = new CheckBox();
            lblUserID = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblAddUpdatePerson = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider = new ErrorProvider(components);
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Font = new Font("Segoe UI", 13F);
            tabControl.Location = new Point(12, 82);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(942, 557);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
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
            // ctrlPersonInfoWithFilter
            // 
            ctrlPersonInfoWithFilter.Location = new Point(6, 6);
            ctrlPersonInfoWithFilter.Name = "ctrlPersonInfoWithFilter";
            ctrlPersonInfoWithFilter.Size = new Size(921, 460);
            ctrlPersonInfoWithFilter.TabIndex = 24;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 15F);
            btnNext.Location = new Point(857, 472);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 39);
            btnNext.TabIndex = 23;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtConfirmPassword);
            tabPage2.Controls.Add(txtPassword);
            tabPage2.Controls.Add(txtUserName);
            tabPage2.Controls.Add(chBoxIsActive);
            tabPage2.Controls.Add(lblUserID);
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(225, 192);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(174, 31);
            txtConfirmPassword.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 147);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(174, 31);
            txtPassword.TabIndex = 25;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(225, 97);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(174, 31);
            txtUserName.TabIndex = 24;
            // 
            // chBoxIsActive
            // 
            chBoxIsActive.AutoSize = true;
            chBoxIsActive.Checked = true;
            chBoxIsActive.CheckState = CheckState.Checked;
            chBoxIsActive.Location = new Point(225, 246);
            chBoxIsActive.Name = "chBoxIsActive";
            chBoxIsActive.Size = new Size(97, 29);
            chBoxIsActive.TabIndex = 23;
            chBoxIsActive.Text = "Is Active";
            chBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Cursor = Cursors.SizeNESW;
            lblUserID.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(225, 47);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 34);
            lblUserID.TabIndex = 21;
            lblUserID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 94);
            label4.Name = "label4";
            label4.Size = new Size(110, 34);
            label4.TabIndex = 20;
            label4.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(113, 144);
            label3.Name = "label3";
            label3.Size = new Size(106, 34);
            label3.TabIndex = 19;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 192);
            label1.Name = "label1";
            label1.Size = new Size(181, 34);
            label1.TabIndex = 18;
            label1.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeNESW;
            label2.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 47);
            label2.Name = "label2";
            label2.Size = new Size(85, 34);
            label2.TabIndex = 17;
            label2.Text = "User ID:";
            // 
            // lblAddUpdatePerson
            // 
            lblAddUpdatePerson.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblAddUpdatePerson.ForeColor = Color.Red;
            lblAddUpdatePerson.Location = new Point(387, 9);
            lblAddUpdatePerson.Name = "lblAddUpdatePerson";
            lblAddUpdatePerson.Size = new Size(194, 57);
            lblAddUpdatePerson.TabIndex = 20;
            lblAddUpdatePerson.Text = "Add User";
            lblAddUpdatePerson.Click += lblAddUpdatePerson_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(881, 650);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 39);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(793, 650);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 39);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(963, 701);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblAddUpdatePerson);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddUpdateUser";
            Text = "Add / Edit User Info.";
            Load += FrmAddUpdateUser_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblAddUpdatePerson;
        private Button btnSave;
        private Button btnClose;
        private Button btnNext;
        private ctrlPersonCardWithFilter ctrlPersonInfoWithFilter;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label lblUserID;
        private CheckBox chBoxIsActive;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private ErrorProvider errorProvider;
    }
}