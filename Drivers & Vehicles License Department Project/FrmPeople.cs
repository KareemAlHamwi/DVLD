using DVLD_Business_Layer;
using System.Data;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmPeople : Form {
        People SelectedPerson = new People();
        DataTable PeopleTable;
        DataView DvPeople;

        public FrmPeople() {
            InitializeComponent();

            PeopleTable = People.GetAllPeople();
            PeopleTable.TableName = "People";
            DvPeople = new DataView(PeopleTable);
            dataPeopleView.DataSource = DvPeople;

            lblRecords.Text = "# Records : " + PeopleTable.Rows.Count;
            comPeopleColumns.Text = "Person ID";
            dataPeopleView.AllowUserToAddRows = false;
            comSearchGender.Visible = false;
        }


        private void _SetColumnsView() {
            dataPeopleView.Columns[0].HeaderText = "Person ID";
            dataPeopleView.Columns[0].Width = 110;
            dataPeopleView.Columns[1].HeaderText = "National No.";
            dataPeopleView.Columns[1].Width = 130;
            dataPeopleView.Columns[2].HeaderText = "First Name";
            dataPeopleView.Columns[2].Width = 130;
            dataPeopleView.Columns[3].HeaderText = "Second Name";
            dataPeopleView.Columns[3].Width = 130;
            dataPeopleView.Columns[4].HeaderText = "Third Name";
            dataPeopleView.Columns[4].Width = 130;
            dataPeopleView.Columns[5].HeaderText = "Last Name";
            dataPeopleView.Columns[5].Width = 130;
            dataPeopleView.Columns[6].HeaderText = "Birthdate";
            dataPeopleView.Columns[6].Width = 130;
            dataPeopleView.Columns[7].HeaderText = "Gender";
            dataPeopleView.Columns[7].Width = 130;
            dataPeopleView.Columns[8].Visible = false;
            dataPeopleView.Columns[9].HeaderText = "Phone";
            dataPeopleView.Columns[9].Width = 130;
            dataPeopleView.Columns[10].HeaderText = "Email";
            dataPeopleView.Columns[10].Width = 130;
            dataPeopleView.Columns[11].HeaderText = "Nationality";
            dataPeopleView.Columns[11].Width = 130;
            dataPeopleView.Columns[12].Visible = false;
            dataPeopleView.Columns[13].Visible = false;
        }

        private void _RefreshDataGrid() {
            PeopleTable = People.GetAllPeople();
            PeopleTable.TableName = "People";
            DvPeople.Table = PeopleTable;
            lblRecords.Text = "# Records : " + PeopleTable.Rows.Count;
        }

        private void comPeopleColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string Selected = comPeopleColumns.SelectedItem as string ?? "";

            //TODO: dataPersonView and txtSearch here
            switch (Selected) {
                case "Person ID":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Person ID");
                    txtSearch.Text = "";
                    break;

                case "National No.":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("National No.");
                    txtSearch.Text = "";
                    break;

                case "First Name":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("First Name");
                    txtSearch.Text = "";
                    break;

                case "Second Name":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Second Name");
                    txtSearch.Text = "";
                    break;

                case "Third Name":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Third Name");
                    txtSearch.Text = "";
                    break;

                case "Last Name":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Last Name");
                    txtSearch.Text = "";
                    break;

                case "Gender":
                    txtSearch.Visible = false;
                    comSearchGender.Visible = true;
                    System.Console.WriteLine("Gender");
                    txtSearch.Text = "";
                    break;

                case "Birthdate":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Birthdate");
                    txtSearch.Text = "12/31/1990";
                    break;

                case "Nationality":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Nationality");
                    txtSearch.Text = "";
                    break;

                case "Phone":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Phone");
                    txtSearch.Text = "";
                    break;

                case "Email":
                    txtSearch.Visible = true;
                    comSearchGender.Visible = false;
                    System.Console.WriteLine("Email");
                    txtSearch.Text = "@";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.AddNew);
            PresentationSettings.aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void _FillSelectedPerson(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataPeopleView.Rows.Count)
                return;

            object birthdateValue = dataPeopleView.Rows[RowIndex].Cells[6].Value;
            object genderValue = dataPeopleView.Rows[RowIndex].Cells[7].Value;

            SelectedPerson = new People(Convert.ToInt32(dataPeopleView.Rows[RowIndex].Cells[0].Value ?? 0),
            dataPeopleView.Rows[RowIndex].Cells[1].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[2].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[3].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[4].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[5].Value?.ToString() ?? "",

            birthdateValue != null ? Convert.ToDateTime(birthdateValue) : DateTime.MinValue,
            genderValue?.ToString() == "Female" ? 1 : 0,

            dataPeopleView.Rows[RowIndex].Cells[8].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[9].Value?.ToString() ?? "",
            dataPeopleView.Rows[RowIndex].Cells[10].Value?.ToString() ?? "",
            Convert.ToInt32(dataPeopleView.Rows[RowIndex].Cells[13].Value ?? 0),
            dataPeopleView.Rows[RowIndex].Cells[11].Value?.ToString() ?? "Unknown",
            dataPeopleView.Rows[RowIndex].Cells[12].Value?.ToString() ?? "");
        }

        private void _SelectWholeRow(int RowIndex) {
            dataPeopleView.ClearSelection();
            dataPeopleView.Rows[RowIndex].Selected = true;
        }

        private void dataPersonsView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                _FillSelectedPerson(e.RowIndex);
                cmsPeople.Show(dataPeopleView, dataPeopleView.PointToClient(Cursor.Position));
            }
        }

        private void dataPersonsView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.pd = new FrmPersonDetails(SelectedPerson);
            PresentationSettings.pd.ShowDialog();
            _RefreshDataGrid();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.AddNew);
            PresentationSettings.aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.Update, SelectedPerson);
            PresentationSettings.aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show($"Are you sure want to delete Person with PersonID ({SelectedPerson.PersonID})?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                People.DeletePerson(SelectedPerson.PersonID);
                FrmPopup.ShowPopup("Deleted Successfully!");
                _RefreshDataGrid();
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) {
            PresentationSettings.NotImplementedMessage();
        }

        private void FrmPeople_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string selectedColumn = comPeopleColumns.SelectedItem?.ToString();
            string searchText = txtSearch.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(selectedColumn)) {
                string filterExpression = string.Empty;

                switch (selectedColumn) {
                    case "Person ID":
                        filterExpression = $"CONVERT([Person ID], 'System.String') LIKE '%{searchText}%'";
                        break;

                    case "Birthdate":
                        filterExpression = $"CONVERT([Birthdate], 'System.String') LIKE '%{searchText}%'";
                        break;

                    default:
                        filterExpression = $"[{selectedColumn}] LIKE '%{comSearchGender.SelectedItem?.ToString()}%'";
                        break;
                }

                DvPeople.RowFilter = filterExpression;
            }
            else {
                DvPeople.RowFilter = string.Empty;
            }

            lblRecords.Text = "# Records : " + DvPeople.Count;
        }

        private void comSearchGender_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedColumn = comPeopleColumns.SelectedItem?.ToString();

            DvPeople.RowFilter = $"[{selectedColumn}] LIKE '%{comSearchGender.SelectedItem?.ToString()}%'";
        }
    }
}
