using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drivers_And_Vehicles_License_Department_Project.Properties;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
    public partial class ctrlUserCard : UserControl {
        private People CurrentPerson = new People();
        private Users CurrentUser = new Users();
        public ctrlUserCard() {
            InitializeComponent();
        }

        public void SetUserData(Users User) {
            CurrentPerson = People.Find(User.PersonID);
            CurrentUser = User;
            ctrlPersonCard1.CurrentPerson = new People(CurrentPerson);
            _UpdateUI();
        }

        private void _UpdateUI() {
            ctrlPersonCard1.lblNationalNo.Text = CurrentPerson.NationalNo;
            ctrlPersonCard1.lblPersonID.Text = CurrentPerson.PersonID.ToString();
            ctrlPersonCard1.lblName.Text = CurrentPerson.FirstName + " " + CurrentPerson.SecondName + " " + CurrentPerson.ThirdName + " " + CurrentPerson.LastName;
            ctrlPersonCard1.lblGender.Text = CurrentPerson.Gender.ToString();
            ctrlPersonCard1.lblNationalNo.Text = CurrentPerson.NationalNo;
            ctrlPersonCard1.lblEmail.Text = CurrentPerson.Email;
            ctrlPersonCard1.lblAddress.Text = CurrentPerson.Address;
            ctrlPersonCard1.lblBirthdate.Text = CurrentPerson.Birthdate.ToShortDateString();
            ctrlPersonCard1.lblPhone.Text = CurrentPerson.Phone;
            ctrlPersonCard1.lblCountry.Text = CurrentPerson.NationalityCountryName;

            if (!string.IsNullOrEmpty(CurrentPerson.ImagePath)) {
                string imageFullPath = Path.Combine(Application.StartupPath, "Photos", CurrentPerson.ImagePath);

                if (File.Exists(imageFullPath)) {
                    using (var tempImage = Image.FromFile(imageFullPath)) {
                        ctrlPersonCard1.picboxPersonalPhoto.Image = new Bitmap(tempImage);
                    }
                }
                else {
                    ctrlPersonCard1.picboxPersonalPhoto.Image = Resources.default_avatar;
                }
            }
            else {
                ctrlPersonCard1.picboxPersonalPhoto.Image = Resources.default_avatar;
            }

            lblUserID.Text = CurrentUser.UserID.ToString();
            lblUserName.Text = CurrentUser.UserName;
            if (!CurrentUser.IsActive) {
                lblIsActive.Text = "Not Active";
            }
        }
    }
}
