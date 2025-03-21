using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class FrmPeople : Form {
        DataTable dt = DVLD_Business_Layer.People.GetAllPeople();
        public FrmPeople() {
            InitializeComponent();
            dataPersonsView.AutoGenerateColumns = true;
            dataPersonsView.DataSource = dt;
            lblRecords.Text = "# Records : " + dt.Rows.Count;
            // MessageBox.Show(DVLD_Data_Access_Layer.PeopleData.IsPersonExist(1).ToString());
            // MessageBox.Show(dt.Rows.Count.ToString());
            // foreach (DataRow row in dt.Rows) {
            //     Console.WriteLine(string.Join(", ", row.ItemArray)); // Prints all row values to the Output window
            // }
        }

        private void comPesonColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string Selected = comPeopleColumns.SelectedItem as string ?? "";

            //TODO: dataPersonView and txtSearch here
            switch (Selected) {
                case "Person ID":
                    System.Console.WriteLine("Person ID");
                    dataPersonsView.Sort(colPersonID, ListSortDirection.Ascending);
                    break;

                case "National No.":
                    System.Console.WriteLine("National No.");
                    dataPersonsView.Sort(colNationalNumber, ListSortDirection.Ascending);
                    break;

                case "First Name":
                    System.Console.WriteLine("First Name");
                    dataPersonsView.Sort(colFirstName, ListSortDirection.Ascending);
                    break;

                case "Second Name":
                    System.Console.WriteLine("Second Name");
                    dataPersonsView.Sort(colSecondName, ListSortDirection.Ascending);
                    break;

                case "Third Name":
                    System.Console.WriteLine("Third Name");
                    dataPersonsView.Sort(colThirdName, ListSortDirection.Ascending);
                    break;

                case "Last Name":
                    System.Console.WriteLine("Last Name");
                    dataPersonsView.Sort(colLastName, ListSortDirection.Ascending);
                    break;

                case "Gender":
                    System.Console.WriteLine("Gender");
                    dataPersonsView.Sort(colGender, ListSortDirection.Ascending);
                    break;

                case "Birthdate":
                    System.Console.WriteLine("Birthdate");
                    dataPersonsView.Sort(colBirthdate, ListSortDirection.Ascending);
                    break;

                case "Nationality":
                    System.Console.WriteLine("Nationality");
                    dataPersonsView.Sort(colNationality, ListSortDirection.Ascending);
                    break;

                case "Phone":
                    System.Console.WriteLine("Phone");
                    dataPersonsView.Sort(colPhone, ListSortDirection.Ascending);
                    break;

                case "Email":
                    System.Console.WriteLine("Email");
                    dataPersonsView.Sort(colEmail, ListSortDirection.Ascending);
                    break;

                default:
                    System.Console.WriteLine("f u");
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void dataPersonsView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                // dataPersonsView.Rows[e.RowIndex].Selected = true;
                cmsPeople.Show(dataPersonsView, e.Location);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            // DVLD_Business_Layer.People.DeletePerson(Convert.ToInt32(dataPersonsView.Rows[dataPersonsView.CurrentCell.RowIndex].Cells[0].Value));
        }
    }
}
