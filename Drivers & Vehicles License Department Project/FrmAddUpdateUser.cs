using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmAddUpdateUser : Form {
        private enMode Mode;

        public Users AddedOrEditedUser = new Users();

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
            if (ctrlPersonInfoWithFilter.FoundPerson == null) {
                FrmPopup.ShowPopup("Please select a person first!");
                tabControl.SelectedIndex = 0;
                return;
            }

            if (People.IsPersonLinkedToUser(ctrlPersonInfoWithFilter.FoundPerson.PersonID)) {
                tabControl.SelectedIndex = 0;
                FrmPopup.ShowPopup("Person is linked to a User before!");
                return;
            }

            AddedOrEditedUser.PersonID = ctrlPersonInfoWithFilter.FoundPerson.PersonID;
            tabControl.SelectedIndex = 1;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlPersonInfoWithFilter.FoundPerson == null) {
                FrmPopup.ShowPopup("Please select a person first!");
                tabControl.SelectedIndex = 0;
                return;
            }

            if (tabControl.SelectedTab == tabPage2 && People.IsPersonLinkedToUser(ctrlPersonInfoWithFilter.FoundPerson.PersonID)) {
                tabControl.SelectedIndex = 0;
                FrmPopup.ShowPopup("Person is linked to a User before!");
            }
        }

        private bool _ValidateAllInputs() {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text)) {
                errorProvider.SetError(txtUserName, "Username can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedUser.UserName = txtUserName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                errorProvider.SetError(txtPassword, "Password can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedUser.Password = txtPassword.Text;
            }

            if (chBoxIsActive.Checked) {
                AddedOrEditedUser.IsActive = true;
            }
            else {
                AddedOrEditedUser.IsActive = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) {
                errorProvider.SetError(txtConfirmPassword, "Confirm Password can't be empty!");
                isValid = false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text) {
                errorProvider.SetError(txtConfirmPassword, "Password confirmation does not match!");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;

            if (AddedOrEditedUser.Save())
                FrmPopup.ShowPopup("Saved!");
            else
                FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");

            Close();
        }
    }
}
