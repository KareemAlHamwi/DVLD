namespace Drivers_And_Vehicles_License_Department_Project {
    partial class FrmUpdateTestTypes {
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
            lblTestTypeID = new Label();
            txtFees = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            label3 = new Label();
            lblUpdateTestType = new Label();
            errorProvider = new ErrorProvider(components);
            label4 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Cursor = Cursors.SizeNESW;
            lblTestTypeID.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypeID.Location = new Point(134, 91);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(48, 34);
            lblTestTypeID.TabIndex = 49;
            lblTestTypeID.Text = "???";
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.Location = new Point(134, 365);
            txtFees.MaxLength = 100;
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(313, 30);
            txtFees.TabIndex = 3;
            txtFees.KeyPress += txtFees_KeyPress;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(134, 138);
            txtTitle.MaxLength = 100;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(313, 30);
            txtTitle.TabIndex = 1;
            txtTitle.KeyPress += txtTitle_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeNESW;
            label2.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 362);
            label2.Name = "label2";
            label2.Size = new Size(62, 34);
            label2.TabIndex = 48;
            label2.Text = "Fees:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 135);
            label1.Name = "label1";
            label1.Size = new Size(58, 34);
            label1.TabIndex = 47;
            label1.Text = "Title:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(406, 422);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(323, 422);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 91);
            label3.Name = "label3";
            label3.Size = new Size(39, 34);
            label3.TabIndex = 46;
            label3.Text = "ID:";
            // 
            // lblUpdateTestType
            // 
            lblUpdateTestType.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblUpdateTestType.ForeColor = Color.Red;
            lblUpdateTestType.Location = new Point(70, 22);
            lblUpdateTestType.Name = "lblUpdateTestType";
            lblUpdateTestType.Size = new Size(333, 52);
            lblUpdateTestType.TabIndex = 45;
            lblUpdateTestType.Text = "Update Test Type";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNESW;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 185);
            label4.Name = "label4";
            label4.Size = new Size(120, 34);
            label4.TabIndex = 50;
            label4.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(134, 188);
            txtDescription.MaxLength = 250;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(313, 158);
            txtDescription.TabIndex = 2;
            txtDescription.KeyPress += txtDescription_KeyPress;
            // 
            // FrmUpdateTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 474);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(lblTestTypeID);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(lblUpdateTestType);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateTestTypes";
            Text = "Update Test Type";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTestTypeID;
        private TextBox txtFees;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private Label lblUpdateTestType;
        private ErrorProvider errorProvider;
        private Label label4;
        private TextBox txtDescription;
    }
}