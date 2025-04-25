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

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmUsers : Form {
        public FrmUsers() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Users user = new Users();

            user.PersonID = 1;
            user.UserName = "WhatThe";
            user.Password = "124";
            user.IsActive = true;
            user.AddNewUser();
        }
    }
}
