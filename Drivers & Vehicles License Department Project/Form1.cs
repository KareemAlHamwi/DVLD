namespace Drivers___Vehicles_License_Department_Project {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
            label1.Text = DVLD_Business_Layer.Class1.Test();
        }
    }
}
