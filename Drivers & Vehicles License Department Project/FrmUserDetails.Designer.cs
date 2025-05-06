namespace Drivers___Vehicles_License_Department_Project {
    partial class FrmUserDetails {
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
            ctrlCurrentUserCard = new ctrlUserCard();
            lblUsersManagement = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlCurrentUserCard
            // 
            ctrlCurrentUserCard.Location = new Point(6, 50);
            ctrlCurrentUserCard.Name = "ctrlCurrentUserCard";
            ctrlCurrentUserCard.Size = new Size(921, 498);
            ctrlCurrentUserCard.TabIndex = 0;
            // 
            // lblUsersManagement
            // 
            lblUsersManagement.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblUsersManagement.ForeColor = Color.Red;
            lblUsersManagement.Location = new Point(338, 9);
            lblUsersManagement.Name = "lblUsersManagement";
            lblUsersManagement.Size = new Size(238, 57);
            lblUsersManagement.TabIndex = 3;
            lblUsersManagement.Text = "User Details";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(835, 556);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 37);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 605);
            Controls.Add(btnClose);
            Controls.Add(lblUsersManagement);
            Controls.Add(ctrlCurrentUserCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUserDetails";
            Text = "User Details";
            ResumeLayout(false);
        }

        #endregion

        private ctrlUserCard ctrlCurrentUserCard;
        private Label lblUsersManagement;
        private Button btnClose;
    }
}