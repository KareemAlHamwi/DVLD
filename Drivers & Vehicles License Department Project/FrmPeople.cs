using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmPeople : Form {
        public FrmPeople() {
            InitializeComponent();
            dataPeopleView.AutoGenerateColumns = true;
            lblRecords.Text = "# Records : " + DVLD_Business_Layer.People.GetAllPeople().Rows.Count;
        }

        private void _RefreshDataGrid() {
            dataPeopleView.DataSource = DVLD_Business_Layer.People.GetAllPeople();
        }

        private void comPesonColumns_SelectedIndexChanged(object sender, EventArgs e) {
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

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void _SelectWholeRow(int rowIndex) {
            dataPeopleView.ClearSelection();
            dataPeopleView.Rows[rowIndex].Selected = true;
        }

        private void dataPersonsView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
                cmsPeople.Show(dataPeopleView, dataPeopleView.PointToClient(Cursor.Position));
            }
        }

        private void dataPersonsView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                _SelectWholeRow(e.RowIndex);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            //DVLD_Business_Layer.People.DeletePerson(Convert.ToInt32(dataPersonsView.Rows[dataPersonsView.CurrentCell.RowIndex].Cells[0].Value));
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void FrmPeople_Load(object sender, EventArgs e) {
            _RefreshDataGrid();
        }
    }
}
