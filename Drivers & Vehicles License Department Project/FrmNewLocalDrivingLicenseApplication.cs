using System.Data;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmNewLocalDrivingLicenseApplication : Form {
        LocalDrivingLicenseApplications NewDrivingLicenseApplication = new LocalDrivingLicenseApplications();
        public FrmNewLocalDrivingLicenseApplication() {
            InitializeComponent();
            LoadDataToUI();
            LoadApplicationsData();
        }

        private void LoadDataToUI() {
            comLicenseClass.DataSource = LicenseClasses.GetAllLicenseClasses();
            comLicenseClass.DisplayMember = "ClassName";
            comLicenseClass.ValueMember = "LicenseClassID";
            comLicenseClass.SelectedIndex = 2;
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = ApplicationTypes.GetServiceFeesByType(enServicesTypes.NewLocalDrivingLicenseService).ToString();
            lblCreatedBy.Text = PresentationSettings.LoggedInUser.UserName;
        }

        private void LoadApplicationsData() {
            NewDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            NewDrivingLicenseApplication.ApplicationTypeID = (int)enServicesTypes.NewInternationalLicense;
            NewDrivingLicenseApplication.ApplicationStatus = Applications.enApplicationStatus.New;
            NewDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            NewDrivingLicenseApplication.PaidFees = ApplicationTypes.GetServiceFeesByType(enServicesTypes.NewLocalDrivingLicenseService);
            NewDrivingLicenseApplication.CreatedByUserID = PresentationSettings.LoggedInUser.UserID;

            if (comLicenseClass.SelectedItem != null) {
                DataRowView selectedRow = (DataRowView)comLicenseClass.SelectedItem;
                int selectedId = (int)selectedRow["LicenseClassID"];
                NewDrivingLicenseApplication.LicenseClassID = selectedId;
            }
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

            NewDrivingLicenseApplication.ApplicantPersonID = ctrlPersonInfoWithFilter.FoundPerson.PersonID;
            tabControl.SelectedIndex = 1;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (ctrlPersonInfoWithFilter.FoundPerson == null) {
                FrmPopup.ShowPopup("Please select a person first!");
                tabControl.SelectedIndex = 0;
                return;
            }
            NewDrivingLicenseApplication.ApplicantPersonID = ctrlPersonInfoWithFilter.FoundPerson.PersonID;
        }

        private void comLicenseClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (comLicenseClass.SelectedItem != null) {
                DataRowView selectedRow = (DataRowView)comLicenseClass.SelectedItem;
                int selectedId = (int)selectedRow["LicenseClassID"];
                NewDrivingLicenseApplication.LicenseClassID = selectedId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (NewDrivingLicenseApplication.Save())
                FrmPopup.ShowPopup("Saved!");
            else
                FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");

            Close();
        }
    }
}
