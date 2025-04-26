using System.Data;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmUsers : Form {
        Users SelectedUser = new Users();
        DataTable UsersTable;
        DataView DvUsers;

        public FrmUsers() {
            InitializeComponent();
            UsersTable = Users.GetAllUsers();
            UsersTable.TableName = "Users";
            DvUsers = new DataView(UsersTable);
            dataUsersView.DataSource = DvUsers;

            lblRecords.Text = "# Records : " + UsersTable.Rows.Count;
            comUsersColumns.Text = "UserID";
            dataUsersView.AllowUserToAddRows = false;
            comSearchGender.Visible = false;
        }

        private void _SetColumnsView() {
            dataUsersView.Columns[0].Width = 120;
            dataUsersView.Columns[1].Width = 120;
            dataUsersView.Columns[2].Width = 500;
            dataUsersView.Columns[3].Width = 120;
            dataUsersView.Columns[4].Width = 120;
        }

        private void _RefreshDataGrid() {
            UsersTable = Users.GetAllUsers();
            UsersTable.TableName = "People";
            DvUsers.Table = UsersTable;
            lblRecords.Text = "# Records : " + UsersTable.Rows.Count;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Users user = new Users();

            // user.PersonID = 2045;
            // user.UserName = "Kareem";
            // user.Password = "1344";
            // user.IsActive = true;
            // user.AddNewUser();
        }

        private void comUsersColumns_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comSearchGender_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {

        }

        private void btnRefresh_Click(object sender, EventArgs e) {

        }

        private void FrmUsers_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }
    }
}
