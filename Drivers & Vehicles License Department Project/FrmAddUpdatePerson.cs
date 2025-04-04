using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmAddUpdatePerson : Form {
        public FrmAddUpdatePerson(enMode mode) {
            InitializeComponent();
            if (mode == enMode.AddNew) {
                UpdateUIAdd();
            } else {
                UpdateUIEdit();
            }
        }

        

        private void UpdateUIAdd() {
            label1.Visible = false;
            lblPersonID.Visible = false;
        }

        private void UpdateUIEdit() {
                lblAddUpdatePerson.Text = "Edit Person";
        }
    }
}
