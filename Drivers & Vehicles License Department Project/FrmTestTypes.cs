using System.Data;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmTestTypes : Form {

        TestTypes SelectedTestType;
        DataTable TestTypesTable;
        DataView DvTestTypes;

        public FrmTestTypes() {
            InitializeComponent();

            TestTypesTable = TestTypes.GetAllTestTypes();
            TestTypesTable.TableName = "TestTypes";
            DvTestTypes = new DataView(TestTypesTable);
            dataTestTypesView.DataSource = DvTestTypes;

            lblRecords.Text = "# Records : " + TestTypesTable.Rows.Count;
            dataTestTypesView.AllowUserToAddRows = false;
        }

        private void _SetColumnsView() {
            dataTestTypesView.Columns[0].Width = 60;
            dataTestTypesView.Columns[1].Width = 150;
            dataTestTypesView.Columns[2].Width = 710;
            dataTestTypesView.Columns[3].Width = 100;
        }

        private void _RefreshDataGrid() {
            TestTypesTable = TestTypes.GetAllTestTypes();
            TestTypesTable.TableName = "TestTypes";
            DvTestTypes.Table = TestTypesTable;
            lblRecords.Text = "# Records : " + TestTypesTable.Rows.Count;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void _SelectWholeRow(int RowIndex) {
            dataTestTypesView.ClearSelection();
            dataTestTypesView.Rows[RowIndex].Selected = true;
        }

        private void _FillSelectedTestType(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataTestTypesView.Rows.Count)
                return;

            SelectedTestType = new TestTypes(Convert.ToInt32(dataTestTypesView.Rows[RowIndex].Cells[0].Value ?? 0)
            , dataTestTypesView.Rows[RowIndex].Cells[1].Value?.ToString() ?? ""
            , dataTestTypesView.Rows[RowIndex].Cells[2].Value?.ToString() ?? ""
            , Convert.ToDecimal(dataTestTypesView.Rows[RowIndex].Cells[3].Value?.ToString() ?? ""));
        }

        private void dataTestTypesView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                _FillSelectedTestType(e.RowIndex);
                cmsTestTypes.Show(dataTestTypesView, dataTestTypesView.PointToClient(Cursor.Position));
            }
        }

        private void dataTestTypesView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void FrmTestTypes_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.utt = new FrmUpdateTestTypes(SelectedTestType);
            PresentationSettings.utt.ShowDialog();
            _RefreshDataGrid();
        }
    }
}
