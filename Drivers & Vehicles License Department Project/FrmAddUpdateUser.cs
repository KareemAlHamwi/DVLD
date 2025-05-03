using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmAddUpdateUser : Form {
        private enMode Mode;
        public FrmAddUpdateUser() {
            InitializeComponent();
        }

        public FrmAddUpdateUser(enMode Mode) {
            InitializeComponent();
            this.Mode = Mode;

            if (Mode == enMode.Update) {
                lblAddUpdatePerson.Text = "Update User";
            }

            ctrlPersonInfoWithFilter.SetMode(this.Mode);
        }

        private void FrmAddUpdateUser_Load(object sender, EventArgs e) {

        }

        private void lblAddUpdatePerson_Click(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
        }
    }
}
