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
                lblAddUpdatePerson.Text = "Edit User";
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
            if (People.IsPersonLinkedToUser(ctrlPersonInfoWithFilter.FoundPerson.PersonID)) {
                tabControl.SelectedIndex = 0;
                FrmPopup.ShowPopup("Person is linked to a User before!");
            } else {
                tabControl.SelectedIndex = 1;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl.SelectedTab == tabPage2 && People.IsPersonLinkedToUser(ctrlPersonInfoWithFilter.FoundPerson.PersonID)) {
                tabControl.SelectedIndex = 0;
                FrmPopup.ShowPopup("Person is linked to a User before!");
            }
        }
    }
}
