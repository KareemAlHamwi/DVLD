using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class ctrlAddUpdatePerson : UserControl {
        public People AddedOrEditedPerson = new People();
        private string _SelectedImagePath = "";

        public ctrlAddUpdatePerson() {
            InitializeComponent();
            radMale.Checked = true;
            AddedOrEditedPerson.Gender = enGender.Male;
            //* Syria = 169 .. Noice
            comCountries.SelectedIndex = 169;
            dateBirthdate.MaxDate = PresentationSettings.MaxDate;
            AutoValidate = AutoValidate.Disable;
        }

        public void SetPersonData(People Person) {
            AddedOrEditedPerson = new People(Person);
            UpdateUI();
        }

        private void UpdateUI() {
            txtFirstName.Text = AddedOrEditedPerson.FirstName;
            txtSecondName.Text = AddedOrEditedPerson.SecondName;
            txtThirdName.Text = AddedOrEditedPerson.ThirdName;
            txtLastName.Text = AddedOrEditedPerson.LastName;
            txtNationalNo.Text = AddedOrEditedPerson.NationalNo;
            dateBirthdate.Text = AddedOrEditedPerson.Birthdate.ToShortDateString();

            if (AddedOrEditedPerson.Gender == enGender.Female) {
                radFemale.Checked = true;
            }

            txtPhone.Text = AddedOrEditedPerson.Phone;
            txtEmail.Text = AddedOrEditedPerson.Email;
            comCountries.SelectedIndex = AddedOrEditedPerson.NationalityCountryID;
            txtAddress.Text = AddedOrEditedPerson.Address;

            if (!string.IsNullOrEmpty(AddedOrEditedPerson.ImagePath) && File.Exists(AddedOrEditedPerson.ImagePath)) {
                using (var tempImage = Image.FromFile(AddedOrEditedPerson.ImagePath)) {
                    picboxPersonalPhoto.Image = new Bitmap(tempImage);
                }
            }
            else {
                picboxPersonalPhoto.Image = Properties.Resources.default_avatar;
            }
        }

        private void _SaveRestOfPersonData() {
            AddedOrEditedPerson.Birthdate = dateBirthdate.Value;
            if (radFemale.Checked)
                AddedOrEditedPerson.Gender = enGender.Female;

            AddedOrEditedPerson.NationalityCountryID = comCountries.SelectedIndex;
            AddedOrEditedPerson.NationalityCountryName = comCountries.SelectedItem.ToString();

            if (_SelectedImagePath != "")
                AddedOrEditedPerson.ImagePath = _SelectedImagePath;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            FindForm()?.Close();
        }

        private bool _ValidateAllInputs() {
            bool isValid = true;
            errorProvider.Clear(); // clear old errors first

            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) {
                errorProvider.SetError(txtFirstName, "First Name can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.FirstName = txtFirstName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtSecondName.Text)) {
                errorProvider.SetError(txtSecondName, "Second Name can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.SecondName = txtSecondName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtThirdName.Text)) {
                errorProvider.SetError(txtThirdName, "Third Name can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.ThirdName = txtThirdName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text)) {
                errorProvider.SetError(txtLastName, "Last Name can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.LastName = txtLastName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text)) {
                errorProvider.SetError(txtNationalNo, "National No. can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.NationalNo = txtNationalNo.Text;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text)) {
                errorProvider.SetError(txtPhone, "Phone can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.Phone = txtPhone.Text;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                errorProvider.SetError(txtEmail, "Email can't be empty!");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, PresentationSettings.EmailPattern)) {
                errorProvider.SetError(txtEmail, "Please enter a valid email address.");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.Email = txtEmail.Text;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text)) {
                errorProvider.SetError(txtAddress, "Address can't be empty!");
                isValid = false;
            }
            else {
                AddedOrEditedPerson.Address = txtAddress.Text;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!_ValidateAllInputs())
                return;

            _SaveRestOfPersonData();

            if (AddedOrEditedPerson.Save())
                FrmPopup.ShowPopup("Saved!");
            else
                FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");

            FindForm()?.Close();
        }

        private void _AllowOnlyLetters(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ') {
                e.Handled = true;
            }
        }

        private void _AllowOnlyDigits(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        //* KeyPress Methods
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyLetters(e);
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyLetters(e);
        }

        private void txtThirdName_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyLetters(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyLetters(e);
        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyDigits(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e) {
            _AllowOnlyDigits(e);
        }

        private void linkSetImageInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Select Face ID Picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    _SelectedImagePath = ofd.FileName;
                    picboxPersonalPhoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void linkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            picboxPersonalPhoto.Image = Properties.Resources.default_avatar;
            AddedOrEditedPerson.ImagePath = "";
            _SelectedImagePath = "";
        }
    }
}
