using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmUserDetails : Form {
        public FrmUserDetails(Users User) {
            InitializeComponent();
            ctrlCurrentUserCard.SetUserData(User);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
