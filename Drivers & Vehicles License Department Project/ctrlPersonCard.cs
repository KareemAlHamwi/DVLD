﻿using Drivers___Vehicles_License_Department_Project.Properties;
using DVLD_Business_Layer;
using System.Reflection;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class ctrlPersonCard : UserControl {
        private People CurrentPerson = new People();

        public ctrlPersonCard() {
            InitializeComponent();
        }

        public void SetPersonData(People Person) {
            CurrentPerson = new People(Person);
            UpdateUI();
        }

        private void UpdateUI() {
            lblNationalNo.Text = CurrentPerson.NationalNo;
            lblPersonID.Text = CurrentPerson.PersonID.ToString();
            lblName.Text = CurrentPerson.FirstName + " " + CurrentPerson.SecondName + " " + CurrentPerson.ThirdName + " " + CurrentPerson.LastName;
            lblGender.Text = CurrentPerson.Gender.ToString();
            lblNationalNo.Text = CurrentPerson.NationalNo;
            lblEmail.Text = CurrentPerson.Email;
            lblAdress.Text = CurrentPerson.Address;
            lblBirthdate.Text = CurrentPerson.Birthdate.ToShortDateString();
            lblPhone.Text = CurrentPerson.Phone;

            if (!string.IsNullOrEmpty(CurrentPerson.ImagePath) && File.Exists(CurrentPerson.ImagePath)) {
                using (var tempImage = Image.FromFile(CurrentPerson.ImagePath)) {
                    picboxPersonalPhoto.Image = new Bitmap(tempImage);
                }
            }
            else {
                picboxPersonalPhoto.Image = Resources.default_avatar;
            }
        }

        private void groPersonInfo_Enter(object sender, EventArgs e) {

        }
    }
}
