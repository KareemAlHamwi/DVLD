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
        public FrmPeople() {
            InitializeComponent();
        }

        private void comPesonColumns_SelectedIndexChanged(object sender, EventArgs e) {
            string Selected = comPesonColumns.SelectedItem.ToString();

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
    }
}
