namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmAddUpdatePerson {
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
            ctrlAddUpdatePerson1 = new ctrlAddUpdatePerson();
            lblPersonID = new Label();
            label1 = new Label();
            lblAddUpdatePerson = new Label();
            SuspendLayout();
            // 
            // ctrlAddUpdatePerson1
            // 
            ctrlAddUpdatePerson1.Location = new Point(12, 81);
            ctrlAddUpdatePerson1.Name = "ctrlAddUpdatePerson1";
            ctrlAddUpdatePerson1.Size = new Size(899, 428);
            ctrlAddUpdatePerson1.TabIndex = 0;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Cursor = Cursors.SizeNESW;
            lblPersonID.Font = new Font("Simplified Arabic", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(124, 60);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(86, 31);
            lblPersonID.TabIndex = 18;
            lblPersonID.Text = "????????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(106, 34);
            label1.TabIndex = 17;
            label1.Text = "Person ID:";
            // 
            // lblAddUpdatePerson
            // 
            lblAddUpdatePerson.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblAddUpdatePerson.ForeColor = Color.Red;
            lblAddUpdatePerson.Location = new Point(330, 9);
            lblAddUpdatePerson.Name = "lblAddUpdatePerson";
            lblAddUpdatePerson.Size = new Size(285, 57);
            lblAddUpdatePerson.TabIndex = 19;
            lblAddUpdatePerson.Text = "Add Person";
            // 
            // FrmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 515);
            Controls.Add(lblAddUpdatePerson);
            Controls.Add(lblPersonID);
            Controls.Add(label1);
            Controls.Add(ctrlAddUpdatePerson1);
            Name = "FrmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Person Info.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlAddUpdatePerson ctrlAddUpdatePerson1;
        private Label lblPersonID;
        private Label label1;
        private Label lblAddUpdatePerson;
    }
}