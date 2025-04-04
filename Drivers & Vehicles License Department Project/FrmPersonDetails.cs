using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmPersonDetails : Form {
        public FrmPersonDetails(People Person) {
            InitializeComponent();
            ctrlCurrentPersonCard.SetPersonData(Person);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
