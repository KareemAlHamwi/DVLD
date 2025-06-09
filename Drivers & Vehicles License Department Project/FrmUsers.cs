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
            comUsersColumns.Text = "User ID";
            dataUsersView.AllowUserToAddRows = false;
            comSearchIsActive.Text = "All";
            comSearchIsActive.Visible = false;
        }

        private void _SetColumnsView() {
            dataUsersView.Columns[0].Width = 120;
            dataUsersView.Columns[1].Width = 120;
            dataUsersView.Columns[2].Width = 500;
            dataUsersView.Columns[3].Width = 120;
            dataUsersView.Columns[4].Width = 120;
            dataUsersView.Columns[5].Visible = false;
        }

        private void _RefreshDataGrid() {
            UsersTable = Users.GetAllUsers();
            UsersTable.TableName = "Users";
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
            string Selected = comUsersColumns.SelectedItem as string ?? "";

            switch (Selected) {
                case "User ID":
                case "Person ID":
                case "UserName":
                case "Full Name":
                    txtSearch.Visible = true;
                    comSearchIsActive.Visible = false;
                    txtSearch.Text = "";
                    break;

                case "Is Active":
                    txtSearch.Visible = false;
                    comSearchIsActive.Visible = true;
                    txtSearch.Text = "";
                    break;
            }

            _RefreshDataGrid();
        }

        private void comSearchIsActive_SelectedIndexChanged(object sender, EventArgs e) {
            bool selectedState = false;

            if (comSearchIsActive.SelectedItem.ToString() == "Yes")
                selectedState = true;
            else if (comSearchIsActive.SelectedItem.ToString() == "No")
                selectedState = false;
            else {
                _RefreshDataGrid();
                return;
            }

            DvUsers.RowFilter = $"[{"Is Active"}] = '{selectedState}'";

            lblRecords.Text = "# Records : " + DvUsers.Count;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string selectedColumn = comUsersColumns.SelectedItem?.ToString();
            string searchText = txtSearch.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(selectedColumn)) {
                string filterExpression = string.Empty;

                switch (selectedColumn) {
                    case "User ID":
                    case "Person ID":
                        filterExpression = $"CONVERT([{selectedColumn}], 'System.String') LIKE '%{searchText}%'";
                        break;

                    default:
                        filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                        break;
                }

                try {
                    DvUsers.RowFilter = filterExpression;
                }
                catch (EvaluateException ex) {
                    Console.WriteLine("Filter error: " + ex.Message);
                    DvUsers.RowFilter = string.Empty;
                }
            }
            else {
                DvUsers.RowFilter = string.Empty;
            }

            lblRecords.Text = "# Records : " + DvUsers.Count;
        }

        private void _ResetFilterUI() {
            comUsersColumns.Text = "User ID";
            comSearchIsActive.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _ResetFilterUI();
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

        private void _FillSelectedUser(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataUsersView.Rows.Count)
                return;

            SelectedUser = new Users(Convert.ToInt32(dataUsersView.Rows[RowIndex].Cells[0].Value ?? 0)
            , Convert.ToInt32(dataUsersView.Rows[RowIndex].Cells[1].Value ?? 0)
            , dataUsersView.Rows[RowIndex].Cells[5].Value?.ToString() ?? ""
            , dataUsersView.Rows[RowIndex].Cells[3].Value?.ToString() ?? ""
            , dataUsersView.Rows[RowIndex].Cells[4].Value?.ToString() ?? "");
        }

        private void dataUsersView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                _FillSelectedUser(e.RowIndex);
                cmsUsers.Show(dataUsersView, dataUsersView.PointToClient(Cursor.Position));
            }
        }

        private void dataUsersView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.ud = new FrmUserDetails(SelectedUser);
            PresentationSettings.ud.ShowDialog();
            _RefreshDataGrid();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.auu = new FrmAddUpdateUser(enMode.AddNew);
            PresentationSettings.auu.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            string username = SelectedUser.UserName;
            SelectedUser = Users.Find(username);
            PresentationSettings.auu = new FrmAddUpdateUser(enMode.Update, SelectedUser);
            PresentationSettings.auu.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show($"Are you sure want to delete User with UserID ({SelectedUser.UserID})?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (Users.DeleteUser(SelectedUser.UserID))
                    FrmPopup.ShowPopup("Deleted Successfully!");
                else
                    FrmPopup.ShowPopup("Couldn't Delete, Something Went Wrong ..");

                _RefreshDataGrid();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.cp = new FrmChangePassword(SelectedUser);
            PresentationSettings.cp.ShowDialog();
            _RefreshDataGrid();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) {
            string selectedColumn = comUsersColumns.SelectedItem as string ?? "";

            switch (selectedColumn) {
                case "User ID":
                case "Person ID":
                    PresentationSettings.AllowOnlyDigits(e);
                    break;

                default:
                    break;
            }
        }
    }
}
