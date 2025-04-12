using Drivers_And_Vehicles_License_Department_Project.Properties;
using DVLD_Business_Layer;

namespace Drivers_And_Vehicles_License_Department_Project {
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
            lblAddress.Text = CurrentPerson.Address;
            lblBirthdate.Text = CurrentPerson.Birthdate.ToShortDateString();
            lblPhone.Text = CurrentPerson.Phone;
            lblCountry.Text = CurrentPerson.NationalityCountryName;

            if (!string.IsNullOrEmpty(CurrentPerson.ImagePath)) {
                string imageFullPath = Path.Combine(Application.StartupPath, "Photos", CurrentPerson.ImagePath);

                if (File.Exists(imageFullPath)) {
                    using (var tempImage = Image.FromFile(imageFullPath)) {
                        picboxPersonalPhoto.Image = new Bitmap(tempImage);
                    }
                }
                else {
                    picboxPersonalPhoto.Image = Properties.Resources.default_avatar;
                }
            }
            else {
                picboxPersonalPhoto.Image = Properties.Resources.default_avatar;
            }

        }

        private void lilblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.Update, CurrentPerson);
            PresentationSettings.aup.DataBack += Aup_DataBack;
            PresentationSettings.aup.ShowDialog();
        }

        private void Aup_DataBack(object sender, People person) {
            SetPersonData(person);
        }
    }
}
