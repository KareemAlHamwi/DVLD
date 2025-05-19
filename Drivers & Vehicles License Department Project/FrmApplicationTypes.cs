using System.Data;
using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmApplicationTypes : Form {

        ApplicationTypes SelectedApplicationType;
        DataTable ApplicationTypesTable;
        DataView DvApplicationTypes;

        public FrmApplicationTypes() {
            InitializeComponent();

            ApplicationTypesTable = ApplicationTypes.GetAllApplicationTypes();
            ApplicationTypesTable.TableName = "Users";
            DvApplicationTypes = new DataView(ApplicationTypesTable);
            dataApplicationTypesView.DataSource = DvApplicationTypes;

            lblRecords.Text = "# Records : " + ApplicationTypesTable.Rows.Count;
            dataApplicationTypesView.AllowUserToAddRows = false;
        }

        private void _SetColumnsView() {
            dataApplicationTypesView.Columns[0].Width = 60;
            dataApplicationTypesView.Columns[1].Width = 500;
            dataApplicationTypesView.Columns[2].Width = 120;
        }

        private void _RefreshDataGrid() {
            ApplicationTypesTable = ApplicationTypes.GetAllApplicationTypes();
            ApplicationTypesTable.TableName = "People";
            DvApplicationTypes.Table = ApplicationTypesTable;
            lblRecords.Text = "# Records : " + ApplicationTypesTable.Rows.Count;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void _SelectWholeRow(int RowIndex) {
            dataApplicationTypesView.ClearSelection();
            dataApplicationTypesView.Rows[RowIndex].Selected = true;
        }

        private void _FillSelectedPerson(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataApplicationTypesView.Rows.Count)
                return;

            SelectedApplicationType = new ApplicationTypes(Convert.ToInt32(dataApplicationTypesView.Rows[RowIndex].Cells[0].Value ?? 0)
            , dataApplicationTypesView.Rows[RowIndex].Cells[1].Value?.ToString() ?? ""
            , Convert.ToDecimal(dataApplicationTypesView.Rows[RowIndex].Cells[2].Value?.ToString() ?? ""));
        }

        private void dataApplicationTypesView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                _FillSelectedPerson(e.RowIndex);
                cmsApplicationTypes.Show(dataApplicationTypesView, dataApplicationTypesView.PointToClient(Cursor.Position));
            }
        }

        private void dataApplicationTypesView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void FrmApplicationTypes_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.uat = new FrmUpdateApplicationTypes(SelectedApplicationType);
            PresentationSettings.uat.ShowDialog();
            _RefreshDataGrid();
        }
    }
}
