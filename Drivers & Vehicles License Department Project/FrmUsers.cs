using System.Data;
using Drivers___Vehicles_License_Department_Project;
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
            comUsersColumns.Text = "User ID";
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
            PresentationSettings.auu = new FrmAddUpdateUser(enMode.AddNew);
            PresentationSettings.auu.ShowDialog();
            _RefreshDataGrid();
        }

        private void comUsersColumns_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comSearchGender_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _RefreshDataGrid();
        }

        private void FrmUsers_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void _SelectWholeRow(int RowIndex) {
            dataUsersView.ClearSelection();
            dataUsersView.Rows[RowIndex].Selected = true;
        }

        private void dataUsersView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                // _FillSelectedPerson(e.RowIndex);
                cmsUsers.Show(dataUsersView, dataUsersView.PointToClient(Cursor.Position));
            }
        }

        private void dataUsersView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.auu = new FrmAddUpdateUser(enMode.AddNew);
            PresentationSettings.auu.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.auu = new FrmAddUpdateUser(enMode.Update);
            PresentationSettings.auu.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }
    }
}
