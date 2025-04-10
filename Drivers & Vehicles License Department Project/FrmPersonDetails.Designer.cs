namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmPersonDetails {
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
            lblPeopleManagement = new Label();
            btnClose = new Button();
            ctrlCurrentPersonCard = new ctrlPersonCard();
            SuspendLayout();
            // 
            // lblPeopleManagement
            // 
            lblPeopleManagement.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblPeopleManagement.ForeColor = Color.Red;
            lblPeopleManagement.Location = new Point(318, 9);
            lblPeopleManagement.Name = "lblPeopleManagement";
            lblPeopleManagement.Size = new Size(278, 57);
            lblPeopleManagement.TabIndex = 2;
            lblPeopleManagement.Text = "Person Details";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(835, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 37);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlCurrentPersonCard
            // 
            ctrlCurrentPersonCard.Location = new Point(12, 55);
            ctrlCurrentPersonCard.Name = "ctrlCurrentPersonCard";
            ctrlCurrentPersonCard.Size = new Size(918, 337);
            ctrlCurrentPersonCard.TabIndex = 6;
            // 
            // FrmPersonDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 450);
            Controls.Add(ctrlCurrentPersonCard);
            Controls.Add(btnClose);
            Controls.Add(lblPeopleManagement);
            Name = "FrmPersonDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Details";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPeopleManagement;
        private Button btnClose;
        private ctrlPersonCard ctrlCurrentPersonCard;
    }
}