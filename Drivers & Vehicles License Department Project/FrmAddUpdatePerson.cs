using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmAddUpdatePerson : Form {
        public delegate void DataBackEventHandler(object sender, People person);
        public event DataBackEventHandler DataBack;

        public People SelectedPerson;

        public FrmAddUpdatePerson(enMode mode, People? SelectedPerson = null) {
            InitializeComponent();
            this.SelectedPerson = new People(SelectedPerson);
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

        private void FrmAddUpdatePerson_FormClosed(object sender, FormClosedEventArgs e) {
            DataBack?.Invoke(this, ctrlAddUpdatePerson1.AddedOrEditedPerson);
        }
    }
}
