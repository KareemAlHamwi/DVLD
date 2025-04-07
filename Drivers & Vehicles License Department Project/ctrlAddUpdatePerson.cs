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
        public delegate void DataBackEventHandler(object sender, string Text);
        public event DataBackEventHandler DataBack;
        private People AddedOrEditedPerson = new People();
        private string _SelectedImagePath = "";

        public ctrlAddUpdatePerson() {
            InitializeComponent();
            radMale.Checked = true;
            AddedOrEditedPerson.Gender = enGender.Male;
            //* Syria = 169 .. Noice
            comCountries.SelectedIndex = 169;
            dateBirthdate.MaxDate = PresentationSettings.MaxDate;
        }

        public void SetPersonData(People Person) {
            // *TODO: insted of doing this here go to FrmPeople
            // TODO and use the constructor that updates.
            Person.Mode = enMode.Update;
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
            txtAdress.Text = AddedOrEditedPerson.Address;

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
            if (radFemale.Checked) {
                AddedOrEditedPerson.Gender = enGender.Female;
            }
            AddedOrEditedPerson.NationalityCountryID = comCountries.SelectedIndex;
            AddedOrEditedPerson.ImagePath = _SelectedImagePath;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            FindForm()?.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                _SaveRestOfPersonData();

                if (AddedOrEditedPerson.Save()) {
                    FrmPopup.ShowPopup("Saved!");
                }
                else {
                    FrmPopup.ShowPopup("Couldn't Save, Something Went Wrong ..");
                }

                FindForm()?.Close();
            }
        }

        private void _SetValidationError(Control control, string Message, CancelEventArgs e, ErrorIconAlignment Alignment = ErrorIconAlignment.MiddleRight) {
            e.Cancel = true;
            control.Focus();
            errorProvider.SetError(control, Message);
            errorProvider.SetIconAlignment(control, Alignment);
        }

        private void _UnsetValidationError(Control control, CancelEventArgs e) {
            e.Cancel = false;
            errorProvider.SetError(control, null);
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

        // Validating Methods
        private void txtFirstName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                _SetValidationError(txtFirstName, "First Name can't be empty!", e);
            else {
                _UnsetValidationError(txtFirstName, e);
                AddedOrEditedPerson.FirstName = txtFirstName.Text;
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
                _SetValidationError(txtSecondName, "Second Name can't be empty!", e);
            else {
                _UnsetValidationError(txtSecondName, e);
                AddedOrEditedPerson.SecondName = txtSecondName.Text;
            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
                _SetValidationError(txtThirdName, "Third Name can't be empty!", e);
            else {
                _UnsetValidationError(txtThirdName, e);
                AddedOrEditedPerson.ThirdName = txtThirdName.Text;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                _SetValidationError(txtLastName, "Last Name can't be empty!", e);
            else {
                _UnsetValidationError(txtLastName, e);
                AddedOrEditedPerson.LastName = txtLastName.Text;
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
                _SetValidationError(txtNationalNo, "National No. can't be empty!", e);
            else {
                _UnsetValidationError(txtNationalNo, e);
                AddedOrEditedPerson.NationalNo = txtNationalNo.Text;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                _SetValidationError(txtPhone, "Phone can't be empty!", e);
            else {
                _UnsetValidationError(txtPhone, e);
                AddedOrEditedPerson.Phone = txtPhone.Text;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                _SetValidationError(txtEmail, "Email can't be empty!", e);
            else {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, PresentationSettings.EmailPattern)) {
                    _SetValidationError(txtEmail, "Please enter a valid email address.", e);
                }
                else {
                    _UnsetValidationError(txtEmail, e);
                    AddedOrEditedPerson.Email = txtEmail.Text;
                }
            }
        }

        private void txtAdress_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtAdress.Text))
                _SetValidationError(txtAdress, "Address can't be empty!", e, ErrorIconAlignment.TopRight);
            else {
                _UnsetValidationError(txtAdress, e);
                AddedOrEditedPerson.Address = txtAdress.Text;
            }
        }

        // KeyPress Methods
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
        }
    }
}
