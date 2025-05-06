namespace Drivers___Vehicles_License_Department_Project {
    partial class ctrlUserCard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ctrlPersonCard1 = new Drivers_And_Vehicles_License_Department_Project.ctrlPersonCard();
            groPersonInfo = new GroupBox();
            lblUserID = new Label();
            label1 = new Label();
            lblUserName = new Label();
            label3 = new Label();
            lblIsActive = new Label();
            label5 = new Label();
            groPersonInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(3, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(914, 337);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groPersonInfo
            // 
            groPersonInfo.Controls.Add(lblIsActive);
            groPersonInfo.Controls.Add(label5);
            groPersonInfo.Controls.Add(lblUserName);
            groPersonInfo.Controls.Add(label3);
            groPersonInfo.Controls.Add(lblUserID);
            groPersonInfo.Controls.Add(label1);
            groPersonInfo.Font = new Font("Segoe UI", 13F);
            groPersonInfo.Location = new Point(3, 346);
            groPersonInfo.Name = "groPersonInfo";
            groPersonInfo.Size = new Size(914, 149);
            groPersonInfo.TabIndex = 3;
            groPersonInfo.TabStop = false;
            groPersonInfo.Text = "Login Information";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Cursor = Cursors.SizeNESW;
            lblUserID.Font = new Font("Simplified Arabic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(147, 71);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(86, 31);
            lblUserID.TabIndex = 17;
            lblUserID.Text = "????????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(97, 34);
            label1.TabIndex = 6;
            label1.Text = "User ID : ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Cursor = Cursors.SizeNESW;
            lblUserName.Font = new Font("Simplified Arabic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(485, 71);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(86, 31);
            lblUserName.TabIndex = 19;
            lblUserName.Text = "????????";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(357, 68);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 18;
            label3.Text = "UserName : ";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Cursor = Cursors.SizeNESW;
            lblIsActive.Font = new Font("Simplified Arabic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(784, 71);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(59, 31);
            lblIsActive.TabIndex = 21;
            lblIsActive.Text = "Active";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNESW;
            label5.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(670, 68);
            label5.Name = "label5";
            label5.Size = new Size(108, 34);
            label5.TabIndex = 20;
            label5.Text = "Is Active : ";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groPersonInfo);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(921, 498);
            groPersonInfo.ResumeLayout(false);
            groPersonInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Drivers_And_Vehicles_License_Department_Project.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groPersonInfo;
        private Label label1;
        private Label lblUserID;
        private Label lblIsActive;
        private Label label5;
        private Label lblUserName;
        private Label label3;
    }
}
