using System.Data;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmLocalDrivingLicenseApplications : Form {
        LocalDrivingLicenseApplications SelectedLocalDrivingLicenseApplication = new LocalDrivingLicenseApplications();
        DataTable LocalDrivingLicenseApplicationsTable;
        DataView DvLocalDrivingLicenseApplications;
        public FrmLocalDrivingLicenseApplications() {
            InitializeComponent();

            LocalDrivingLicenseApplicationsTable = LocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            LocalDrivingLicenseApplicationsTable.TableName = "People";
            DvLocalDrivingLicenseApplications = new DataView(LocalDrivingLicenseApplicationsTable);
            dataLDLApplicationsView.DataSource = DvLocalDrivingLicenseApplications;
            dataLDLApplicationsView.Columns[0].Name = "L.D.L AppID";
            dataLDLApplicationsView.Columns[2].Name = "National No.";
            dataLDLApplicationsView.Columns[3].Name = "Full Name";

            lblRecords.Text = "# Records : " + LocalDrivingLicenseApplicationsTable.Rows.Count;
            comLDLApplicationsColumns.Text = "L.D.L AppID";
            dataLDLApplicationsView.AllowUserToAddRows = false;
            comSearchStatus.Visible = false;
        }

        private void _SetColumnsView() {
            dataLDLApplicationsView.Columns[0].HeaderText = "L.D.L AppID";
            dataLDLApplicationsView.Columns[0].Name = "L.D.L AppID";
            dataLDLApplicationsView.Columns[0].Width = 100;
            dataLDLApplicationsView.Columns[1].HeaderText = "Driving Class";
            dataLDLApplicationsView.Columns[1].Width = 200;
            dataLDLApplicationsView.Columns[2].HeaderText = "National No.";
            dataLDLApplicationsView.Columns[2].Width = 200;
            dataLDLApplicationsView.Columns[3].HeaderText = "Full Name";
            dataLDLApplicationsView.Columns[3].Width = 500;
            dataLDLApplicationsView.Columns[4].HeaderText = "Application Date";
            dataLDLApplicationsView.Columns[4].Width = 200;
            dataLDLApplicationsView.Columns[5].HeaderText = "Passed Tests";
            dataLDLApplicationsView.Columns[5].Width = 120;
            dataLDLApplicationsView.Columns[6].Width = 100;
        }

        private void _RefreshDataGrid() {
            LocalDrivingLicenseApplicationsTable = LocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
            LocalDrivingLicenseApplicationsTable.TableName = "Local Driving License Applications";
            DvLocalDrivingLicenseApplications.Table = LocalDrivingLicenseApplicationsTable;
            lblRecords.Text = "# Records : " + LocalDrivingLicenseApplicationsTable.Rows.Count;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PresentationSettings.nldla = new FrmNewLocalDrivingLicenseApplication();
            PresentationSettings.nldla.ShowDialog();
            _RefreshDataGrid();
        }

        void _FillSelectedLocalDrivingLicenseApplication(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataLDLApplicationsView.Rows.Count)
                return;

            SelectedLocalDrivingLicenseApplication = new LocalDrivingLicenseApplications();
        }

        private void _SelectWholeRow(int RowIndex) {
            dataLDLApplicationsView.ClearSelection();
            dataLDLApplicationsView.Rows[RowIndex].Selected = true;
        }

        private void dataLDLApplicationsView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                _FillSelectedLocalDrivingLicenseApplication(e.RowIndex);
                cmsLDLApplications.Show(dataLDLApplicationsView, dataLDLApplicationsView.PointToClient(Cursor.Position));
            }
        }

        private void dataLDLApplicationsView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void FrmLocalDrivingLicenseApplications_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void _ResetFilterUI() {
            comLDLApplicationsColumns.Text = "Person ID";
            comSearchStatus.Visible = false;
            txtSearch.Visible = true;
            txtSearch.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _ResetFilterUI();
            _RefreshDataGrid();
        }

        private void comLDLApplicationsColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string Selected = comLDLApplicationsColumns.SelectedItem as string ?? "";

            switch (Selected) {
                case "L.D.L AppID":
                case "National No.":
                case "Full Name":
                    txtSearch.Visible = true;
                    comSearchStatus.Visible = false;
                    txtSearch.Text = "";
                    break;

                case "Status":
                    txtSearch.Visible = false;
                    comSearchStatus.Visible = true;
                    txtSearch.Text = "";
                    break;
            }

            _RefreshDataGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string selectedColumn = comLDLApplicationsColumns.SelectedItem?.ToString();
            string searchText = txtSearch.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(selectedColumn)) {
                string filterExpression = string.Empty;

                switch (selectedColumn) {
                    case "L.D.L AppID":
                    case "National No.":
                        filterExpression = $"CONVERT([{selectedColumn}], 'System.String') LIKE '%{searchText}%'";
                        break;

                    case "Full Name":
                        filterExpression = $"[{selectedColumn}] LIKE '%{searchText}%'";
                        break;
                }

                try {
                    DvLocalDrivingLicenseApplications.RowFilter = filterExpression;
                }
                catch (EvaluateException ex) {
                    Console.WriteLine("Filter error: " + ex.Message);
                    DvLocalDrivingLicenseApplications.RowFilter = string.Empty;
                }
            }
            else {
                DvLocalDrivingLicenseApplications.RowFilter = string.Empty;
            }

            lblRecords.Text = "# Records : " + DvLocalDrivingLicenseApplications.Count;
        }

        private void comSearchStatus_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedColumn = comLDLApplicationsColumns.SelectedItem?.ToString();
            string selectedGender = comSearchStatus.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(selectedColumn) && !string.IsNullOrWhiteSpace(selectedGender)) {
                DvLocalDrivingLicenseApplications.RowFilter = $"[{selectedColumn}] = '{selectedGender}'";
            }
            else {
                DvLocalDrivingLicenseApplications.RowFilter = string.Empty;
            }

            lblRecords.Text = "# Records : " + DvLocalDrivingLicenseApplications.Count;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) {
            string selectedColumn = comLDLApplicationsColumns.SelectedItem as string ?? "";

            switch (selectedColumn) {
                case "L.D.L AppID":
                case "National No.":
                    PresentationSettings.AllowOnlyDigits(e);
                    break;

                case "Full Name":
                    PresentationSettings.AllowOnlyLetters(e);
                    break;

                default:
                    break;
            }
        }
    }
}
