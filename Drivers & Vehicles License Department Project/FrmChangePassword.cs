using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmChangePassword : Form {
        Users User = new Users();
        public FrmChangePassword(Users User) {
            InitializeComponent();
            this.User = new Users(User);

            ctrlUserCard1.SetUserData(User);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private bool _ValidateAllInputs() {
            bool IsValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text)) {
                errorProvider.SetError(txtCurrentPassword, "This field can't be empty!");
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text)) {
                errorProvider.SetError(txtNewPassword, "This field can't be empty!");
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) {
                errorProvider.SetError(txtConfirmPassword, "This field can't be empty!");
                IsValid = false;
                return IsValid;
            }

            if (!User.ConfirmPassword(txtCurrentPassword.Text)) {
                errorProvider.SetError(txtCurrentPassword, "Password is not correct!");
                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();
                IsValid = false;
                return IsValid;
            }

            if (txtCurrentPassword.Text == txtNewPassword.Text) {
                errorProvider.SetError(txtNewPassword, "Can't change to the same password!");
                IsValid = false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text) {
                errorProvider.SetError(txtConfirmPassword, "Password confirmation does not match!");
                IsValid = false;
            }

            return IsValid;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;
            else
                User.Password = txtNewPassword.Text;

            if (User.Save())
                FrmPopup.ShowPopup("Password Changed!");
            else
                FrmPopup.ShowPopup("Couldn't Change Password, Something Went Wrong ..");

            Close();
        }
    }
}
