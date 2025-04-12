using System;
using System.Linq;
using System.Windows.Forms;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class FrmMain : Form {
        private readonly Dictionary<Type, Form> openedForms = new Dictionary<Type, Form>();

        public FrmMain() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void OpenForm<T>() where T : Form, new() {
            // If the form is not already opened, open it
            if (!openedForms.ContainsKey(typeof(T))) {
                T form = new T();
                form.MdiParent = this;
                form.FormClosed += (sender, e) => openedForms.Remove(typeof(T)); // Remove form when closed
                form.Show();
                openedForms[typeof(T)] = form; // Track opened form
            }
            else {
                // If it's already opened, activate the existing instance
                openedForms[typeof(T)].Activate();
            }
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmPeople>();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenForm<FrmUsers>();
        }
    }
}
