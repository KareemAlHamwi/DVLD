using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class ctrlPersonCardWithFilter : UserControl {
        private enMode Mode;

        public ctrlPersonCardWithFilter() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.AddNew);
            PresentationSettings.aup.ShowDialog();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e) {
            _ApplyModeSettings();
        }

        public void SetMode(enMode Mode) {
            this.Mode = Mode;
            _ApplyModeSettings();
        }

        private void _ApplyModeSettings() {
            comPeopleColumns.Text = "Person ID";
            comSearchGender.Visible = false;

            if (Mode == enMode.Update) {
                groFilter.Enabled = false;
                comPeopleColumns.Enabled = false;
                comSearchGender.Enabled = false;
                txtSearch.Enabled = false;
                btnFind.Enabled = false;
                btnAdd.Enabled = false;
            }
        }
    }
}
