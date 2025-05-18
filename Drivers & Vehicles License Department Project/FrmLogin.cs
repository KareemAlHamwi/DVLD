
using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmLogin : Form {
        Users LoggedInUser = new Users();

        public FrmLogin() {
            InitializeComponent();
        }

        private bool _ValidateAllInputs() {
            bool IsValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text)) {
                errorProvider.SetError(txtUserName, "Username can't be empty!");
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                errorProvider.SetError(txtPassword, "Password can't be empty!");
                IsValid = false;
            }

            return IsValid;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;

            try {
                Users user = Users.Login(txtUserName.Text, txtPassword.Text);

                if (user != null && user.IsActive) {
                    LoggedInUser = user;
                    Program.SwitchToMainForm(LoggedInUser);
                    Close();
                }
                else {
                    FrmPopup.ShowPopup(user == null ? "Invalid credentials" : "Account is inactive");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex) {
                FrmPopup.ShowPopup($"Login failed: {ex.Message}");
            }
        }
    }
}
