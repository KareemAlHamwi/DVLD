using DVLD_Business_Layer;
using System.Data;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmPeople : Form {
        FrmPersonDetails pd;
        FrmAddUpdatePerson aup;
        People SelectedPerson = new People();

        public FrmPeople() {
            InitializeComponent();
            // dataPeopleView.AutoGenerateColumns = true;
            lblRecords.Text = "# Records : " + People.GetAllPeople().Rows.Count;
            comPeopleColumns.Text = "Person ID";
        }

        private void _SetColumnsView() {
            dataPeopleView.Columns[0].HeaderText = "Person ID";
            dataPeopleView.Columns[0].Width = 100;
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
            dataPeopleView.DataSource = People.GetAllPeople();
            lblRecords.Text = "# Records : " + People.GetAllPeople().Rows.Count;
        }

        private void comPeopleColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string Selected = comPeopleColumns.SelectedItem as string ?? "";

            //TODO: dataPersonView and txtSearch here
            switch (Selected) {
                case "Person ID":
                    System.Console.WriteLine("Person ID");
                    break;

                case "National No.":
                    System.Console.WriteLine("National No.");
                    break;

                case "First Name":
                    System.Console.WriteLine("First Name");
                    break;

                case "Second Name":
                    System.Console.WriteLine("Second Name");
                    break;

                case "Third Name":
                    System.Console.WriteLine("Third Name");
                    break;

                case "Last Name":
                    System.Console.WriteLine("Last Name");
                    break;

                case "Gender":
                    System.Console.WriteLine("Gender");
                    break;

                case "Birthdate":
                    System.Console.WriteLine("Birthdate");
                    break;

                case "Nationality":
                    System.Console.WriteLine("Nationality");
                    break;

                case "Phone":
                    System.Console.WriteLine("Phone");
                    break;

                case "Email":
                    System.Console.WriteLine("Email");
                    break;

                default:
                    System.Console.WriteLine("f u");
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            aup = new FrmAddUpdatePerson(enMode.AddNew);
            aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void _FillSelectedPerson(int RowIndex) {
            if (RowIndex < 0 || RowIndex >= dataPeopleView.Rows.Count)
                return;

            SelectedPerson.PersonID = Convert.ToInt32(dataPeopleView.Rows[RowIndex].Cells[0].Value ?? 0);
            SelectedPerson.NationalNo = dataPeopleView.Rows[RowIndex].Cells[1].Value?.ToString() ?? "";
            SelectedPerson.FirstName = dataPeopleView.Rows[RowIndex].Cells[2].Value?.ToString() ?? "";
            SelectedPerson.SecondName = dataPeopleView.Rows[RowIndex].Cells[3].Value?.ToString() ?? "";
            SelectedPerson.ThirdName = dataPeopleView.Rows[RowIndex].Cells[4].Value?.ToString() ?? "";
            SelectedPerson.LastName = dataPeopleView.Rows[RowIndex].Cells[5].Value?.ToString() ?? "";

            object birthdateValue = dataPeopleView.Rows[RowIndex].Cells[6].Value;
            SelectedPerson.Birthdate = birthdateValue != null ? Convert.ToDateTime(birthdateValue) : DateTime.MinValue;

            object genderValue = dataPeopleView.Rows[RowIndex].Cells[7].Value;
            SelectedPerson.Gender = Enum.TryParse(typeof(enGender), genderValue?.ToString(), out var genderResult)
                ? (enGender)genderResult
                : enGender.Male;

            SelectedPerson.Address = dataPeopleView.Rows[RowIndex].Cells[8].Value?.ToString() ?? "";
            SelectedPerson.Phone = dataPeopleView.Rows[RowIndex].Cells[9].Value?.ToString() ?? "";
            SelectedPerson.Email = dataPeopleView.Rows[RowIndex].Cells[10].Value?.ToString() ?? "";
            SelectedPerson.NationalityCountryName = dataPeopleView.Rows[RowIndex].Cells[11].Value?.ToString() ?? "Unknown";
            SelectedPerson.ImagePath = dataPeopleView.Rows[RowIndex].Cells[12].Value?.ToString() ?? "";
            SelectedPerson.NationalityCountryID = Convert.ToInt32(dataPeopleView.Rows[RowIndex].Cells[13].Value ?? 0);
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
            pd = new FrmPersonDetails(SelectedPerson);
            pd.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
            aup = new FrmAddUpdatePerson(enMode.AddNew);
            aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            aup = new FrmAddUpdatePerson(enMode.Update, SelectedPerson);
            aup.ShowDialog();
            _RefreshDataGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show($"Are you sure want to delete Person with PersonID ({SelectedPerson.PersonID})?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                People.DeletePerson(SelectedPerson.PersonID);
                FrmPopup.ShowPopup("Deleted Successfully!");
                _RefreshDataGrid();
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void FrmPeople_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
            _SetColumnsView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            // DataView dataView = new DataVie
        }
    }
}
