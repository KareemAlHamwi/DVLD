namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmLogin {
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
            label1 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            chBoxRememberMe = new CheckBox();
            btnLogin = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 45);
            label1.TabIndex = 19;
            label1.Text = "Login to your account";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 153);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(269, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(173, 103);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(269, 23);
            txtUserName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 94);
            label4.Name = "label4";
            label4.Size = new Size(110, 34);
            label4.TabIndex = 27;
            label4.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(106, 34);
            label3.TabIndex = 26;
            label3.Text = "Password:";
            // 
            // chBoxRememberMe
            // 
            chBoxRememberMe.AutoSize = true;
            chBoxRememberMe.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chBoxRememberMe.Location = new Point(173, 202);
            chBoxRememberMe.Name = "chBoxRememberMe";
            chBoxRememberMe.Size = new Size(145, 27);
            chBoxRememberMe.TabIndex = 3;
            chBoxRememberMe.Text = "Remember Me.";
            chBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.Location = new Point(372, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(70, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 321);
            Controls.Add(btnLogin);
            Controls.Add(chBoxRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label4;
        private Label label3;
        private CheckBox chBoxRememberMe;
        private Button btnLogin;
        private ErrorProvider errorProvider;
    }
}