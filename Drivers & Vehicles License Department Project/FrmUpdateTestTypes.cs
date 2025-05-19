using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;
namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmUpdateTestTypes : Form {
        public TestTypes EditedTestType = new TestTypes();
        public FrmUpdateTestTypes(TestTypes TestType) {
            InitializeComponent();
            _SetTestTypeData(TestType);
            EditedTestType = new TestTypes(TestType);
        }

        private void _SetTestTypeData(TestTypes TestType) {
            lblTestTypeID.Text = TestType.TestTypeID.ToString();
            txtTitle.Text = TestType.Title;
            txtDescription.Text = TestType.Description;
            txtFees.Text = TestType.Fees.ToString("0.##");
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
                EditedTestType.Title = txtTitle.Text;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text)) {
                errorProvider.SetError(txtDescription, "Description can't be empty!");
                IsValid = false;
            }
            else {
                EditedTestType.Description = txtDescription.Text;
            }

            if (string.IsNullOrWhiteSpace(txtFees.Text)) {
                errorProvider.SetError(txtFees, "Fees can't be empty!");
                IsValid = false;
            }
            else {
                EditedTestType.Fees = Convert.ToDecimal(txtFees.Text);
            }

            return IsValid;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;

            if (EditedTestType.Save())
                FrmPopup.ShowPopup("Saved!");
            else
                FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");

            Close();
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e) {
            PresentationSettings.AllowOnlyLetters(e);
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e) {
            PresentationSettings.AllowOnlyLetters(e);
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e) {
            PresentationSettings.AllowOnlyDigits(e);
        }
    }
}
