using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;
namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmUpdateApplicationTypes : Form {
        public ApplicationTypes EditedApplicationType = new ApplicationTypes();
        public FrmUpdateApplicationTypes(ApplicationTypes ApplicationType) {
            InitializeComponent();
            _LoadToUI(ApplicationType);
            EditedApplicationType = new ApplicationTypes(ApplicationType);
        }

        private void _LoadToUI(ApplicationTypes ApplicationType) {
            lblApplicationTypeID.Text = ApplicationType.ApplicationTypeID.ToString();
            txtTitle.Text = ApplicationType.Title;
            txtFees.Text = ApplicationType.Fees.ToString("0.##");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private bool _ValidateAllInputs() {
            bool IsValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtTitle.Text)) {
                errorProvider.SetError(txtTitle, "Title can't be empty!");
                IsValid = false;
            }
            else {
                EditedApplicationType.Title = txtTitle.Text;
            }

            if (string.IsNullOrWhiteSpace(txtFees.Text)) {
                errorProvider.SetError(txtFees, "Fees can't be empty!");
                IsValid = false;
            }
            else {
                EditedApplicationType.Fees = Convert.ToDecimal(txtFees.Text);
            }

            return IsValid;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;

            if (EditedApplicationType.Save())
                FrmPopup.ShowPopup("Saved!");
            else
                FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");

            Close();
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e) {
            PresentationSettings.AllowOnlyLetters(e);
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e) {
            PresentationSettings.AllowOnlyDigits(e);
        }
    }
}
