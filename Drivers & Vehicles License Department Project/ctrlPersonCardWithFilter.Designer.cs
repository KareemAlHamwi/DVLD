namespace Drivers___Vehicles_License_Department_Project {
    partial class ctrlPersonCardWithFilter {
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
            ctrlPersonCard = new Drivers_And_Vehicles_License_Department_Project.ctrlPersonCard();
            groFilter = new GroupBox();
            btnAdd = new Button();
            btnFind = new Button();
            comSearchGender = new ComboBox();
            txtSearch = new TextBox();
            comPeopleColumns = new ComboBox();
            lblFilterBy = new Label();
            groFilter.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard
            // 
            ctrlPersonCard.Location = new Point(4, 125);
            ctrlPersonCard.Name = "ctrlPersonCard";
            ctrlPersonCard.Size = new Size(914, 337);
            ctrlPersonCard.TabIndex = 0;
            // 
            // groFilter
            // 
            groFilter.Controls.Add(btnAdd);
            groFilter.Controls.Add(btnFind);
            groFilter.Controls.Add(comSearchGender);
            groFilter.Controls.Add(txtSearch);
            groFilter.Controls.Add(comPeopleColumns);
            groFilter.Controls.Add(lblFilterBy);
            groFilter.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groFilter.Location = new Point(4, 3);
            groFilter.Name = "groFilter";
            groFilter.Size = new Size(914, 100);
            groFilter.TabIndex = 1;
            groFilter.TabStop = false;
            groFilter.Text = "Filter";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(769, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 15F);
            btnFind.Location = new Point(681, 39);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(70, 39);
            btnFind.TabIndex = 18;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // comSearchGender
            // 
            comSearchGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comSearchGender.Font = new Font("Segoe UI", 13F);
            comSearchGender.FormattingEnabled = true;
            comSearchGender.Items.AddRange(new object[] { "Male", "Female" });
            comSearchGender.Location = new Point(343, 43);
            comSearchGender.Name = "comSearchGender";
            comSearchGender.Size = new Size(180, 31);
            comSearchGender.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13F);
            txtSearch.Location = new Point(343, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 31);
            txtSearch.TabIndex = 15;
            // 
            // comPeopleColumns
            // 
            comPeopleColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            comPeopleColumns.Font = new Font("Segoe UI", 13F);
            comPeopleColumns.FormattingEnabled = true;
            comPeopleColumns.Items.AddRange(new object[] { "Person ID", "National No." });
            comPeopleColumns.Location = new Point(148, 43);
            comPeopleColumns.Name = "comPeopleColumns";
            comPeopleColumns.Size = new Size(180, 31);
            comPeopleColumns.TabIndex = 14;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 20F);
            lblFilterBy.Location = new Point(18, 37);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(116, 37);
            lblFilterBy.TabIndex = 13;
            lblFilterBy.Text = "Find By :";
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groFilter);
            Controls.Add(ctrlPersonCard);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(921, 466);
            Load += ctrlPersonCardWithFilter_Load;
            groFilter.ResumeLayout(false);
            groFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Drivers_And_Vehicles_License_Department_Project.ctrlPersonCard ctrlPersonCard;
        private GroupBox groFilter;
        private Label lblFilterBy;
        private ComboBox comSearchGender;
        private TextBox txtSearch;
        private ComboBox comPeopleColumns;
        private Button btnFind;
        private Button btnAdd;
    }
}
