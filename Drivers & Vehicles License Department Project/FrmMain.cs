using Drivers_And_Vehicles_License_Department_Project;
using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmMain : Form {
        private readonly Dictionary<Type, Form> openedForms = new Dictionary<Type, Form>();
        Users LoggedInUser = new Users();

        public FrmMain(Users LoggedInUser) {
            InitializeComponent();
            this.LoggedInUser = new Users(LoggedInUser);
        }

        private void OpenForm<T>() where T : Form, new() {
            if (!openedForms.ContainsKey(typeof(T))) {
                T form = new T();
                form.MdiParent = this;
                form.FormClosed += (sender, e) => openedForms.Remove(typeof(T));
                form.Show();
                openedForms[typeof(T)] = form;
            }
            else {
                openedForms[typeof(T)].Activate();
            }
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmPeople>();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmUsers>();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.ud = new FrmUserDetails(LoggedInUser);
            PresentationSettings.ud.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.cp = new FrmChangePassword(LoggedInUser);
            PresentationSettings.cp.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure want to sign out?", "Sign out", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                File.WriteAllText(PresentationSettings.RememberMeFile, "{\"Username\":\"\",\"Password\":\"\",\"RememberMe\":false}");
                Program.SwitchToLoginForm();
                Close();
            }
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmApplicationTypes>();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmTestTypes>();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmLocalDrivingLicenseApplications>();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.nldla = new FrmNewLocalDrivingLicenseApplication();
            PresentationSettings.nldla.ShowDialog();
        }
    }
}
