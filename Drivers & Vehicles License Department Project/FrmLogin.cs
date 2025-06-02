using System.Text.Json;
using System.Text;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmLogin : Form {
        Users LoggedInUser = new Users();

        public FrmLogin() {
            InitializeComponent();
            LoadRememberMeInfo();
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
                    FrmPopup.ShowPopup($"{user.UserName} Login Successfully!");
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

            SaveRememberMeInfo(LoggedInUser.UserName, LoggedInUser.Password, chBoxRememberMe.Checked);
        }


        // Basic "encryption" (note: this is just for demo purposes)
        private string Encrypt(string plainText) {
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(data);
        }

        private string Decrypt(string encryptedText) {
            byte[] data = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(data);
        }

        private void SaveRememberMeInfo(string username, string password, bool rememberMe) {
            var info = new ClsRememberME {
                Username = rememberMe ? Encrypt(username) : "",
                Password = rememberMe ? Encrypt(password) : "",
                RememberMe = rememberMe
            };

            string json = JsonSerializer.Serialize(info);
            File.WriteAllText(PresentationSettings.RememberMeFile, json);
        }

        private bool LoadRememberMeInfo() {
            if (!File.Exists(PresentationSettings.RememberMeFile))
                return false;

            string json = File.ReadAllText(PresentationSettings.RememberMeFile);
            var info = JsonSerializer.Deserialize<ClsRememberME>(json);

            if (info != null && info.RememberMe) {
                txtUserName.Text = Decrypt(info.Username);
                txtPassword.Text = Decrypt(info.Password);
                chBoxRememberMe.Checked = true;
                return true;
            }

            return false;
        }
    }
}
