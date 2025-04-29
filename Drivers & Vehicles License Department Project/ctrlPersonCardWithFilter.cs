using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;
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
    public partial class ctrlPersonCardWithFilter : UserControl {
        public ctrlPersonCardWithFilter() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.AddNew);
            PresentationSettings.aup.ShowDialog();
        }
    }
}
