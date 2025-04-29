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
    public partial class FrmAddUpdateUser : Form {
        public FrmAddUpdateUser() {
            InitializeComponent();
        }

        private void FrmAddUpdateUser_Load(object sender, EventArgs e) {

        }

        private void lblAddUpdatePerson_Click(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
        }
    }
}
