using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmAddUpdatePerson : Form {
        public FrmAddUpdatePerson(enMode mode, People? SelectedPerson = null) {
            InitializeComponent();
            if (mode == enMode.AddNew)
                _UpdateUIAdd();
            else
                _UpdateUIEdit(SelectedPerson);
        }

        private void _UpdateUIAdd() {
            label1.Visible = false;
            lblPersonID.Visible = false;
        }

        private void _UpdateUIEdit(People SelectedPerson) {
            lblAddUpdatePerson.Text = "Edit Person";
            ctrlAddUpdatePerson1.SetPersonData(SelectedPerson);
            lblPersonID.Text = Convert.ToString(SelectedPerson.PersonID);
        }
    }
}
