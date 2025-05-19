namespace Drivers___Vehicles_License_Department_Project {
    partial class FrmUpdateApplicationTypes {
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
            lblUpdateApplicationType = new Label();
            txtFees = new TextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            label3 = new Label();
            lblApplicationTypeID = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUpdateApplicationType
            // 
            lblUpdateApplicationType.Font = new Font("Simple Bold Jut Out", 25F, FontStyle.Bold);
            lblUpdateApplicationType.ForeColor = Color.Red;
            lblUpdateApplicationType.Location = new Point(12, 9);
            lblUpdateApplicationType.Name = "lblUpdateApplicationType";
            lblUpdateApplicationType.Size = new Size(455, 52);
            lblUpdateApplicationType.TabIndex = 19;
            lblUpdateApplicationType.Text = "Update Application Type";
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.Location = new Point(110, 175);
            txtFees.MaxLength = 100;
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(313, 30);
            txtFees.TabIndex = 2;
            txtFees.KeyPress += txtFees_KeyPress;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(110, 126);
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
            label2.Location = new Point(42, 172);
            label2.Name = "label2";
            label2.Size = new Size(62, 34);
            label2.TabIndex = 39;
            label2.Text = "Fees:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNESW;
            label1.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 123);
            label1.Name = "label1";
            label1.Size = new Size(58, 34);
            label1.TabIndex = 38;
            label1.Text = "Title:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(392, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 15F);
            btnClose.Location = new Point(309, 231);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 39);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNESW;
            label3.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 79);
            label3.Name = "label3";
            label3.Size = new Size(39, 34);
            label3.TabIndex = 37;
            label3.Text = "ID:";
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Cursor = Cursors.SizeNESW;
            lblApplicationTypeID.Font = new Font("Simplified Arabic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationTypeID.Location = new Point(110, 79);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(48, 34);
            lblApplicationTypeID.TabIndex = 40;
            lblApplicationTypeID.Text = "???";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmUpdateApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 282);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(lblUpdateApplicationType);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateApplicationTypes";
            Text = "Update Application Types";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateApplicationType;
        private TextBox txtFees;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private Label label3;
        private Label lblApplicationTypeID;
        private ErrorProvider errorProvider;
    }
}