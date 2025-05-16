using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

namespace Drivers___Vehicles_License_Department_Project {
    public partial class ctrlPersonCardWithFilter : UserControl {
        private enMode Mode;
        public People FoundPerson;

        public ctrlPersonCardWithFilter() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            PresentationSettings.aup = new FrmAddUpdatePerson(enMode.AddNew);
            PresentationSettings.aup.DataBack += Aup_DataBack;
            PresentationSettings.aup.ShowDialog();

            //if (PresentationSettings.aup.SelectedPerson != null) {
            //    _FillFilterWithAddedPerson(PresentationSettings.aup.SelectedPerson);
            //}
        }

        private void Aup_DataBack(object sender, People person) {
            ctrlPersonCard.SetPersonData(person);
            _FillFilterWithAddedPerson(person);
        }

        private void _FillFilterWithAddedPerson(People Person) {
            if (Person != null) {
                comPeopleColumns.Text = "Person ID";
                txtSearch.Text = Person.PersonID.ToString();
                btnFind.PerformClick();
            }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e) {
            _ApplyModeSettings();
        }

        public void SetMode(enMode Mode) {
            this.Mode = Mode;
            _ApplyModeSettings();
        }

        public void SetPerson(Users AddedOrEditedUser) {
            FoundPerson = People.Find(AddedOrEditedUser.PersonID);
        }

        private void _ApplyModeSettings() {
            comPeopleColumns.Text = "National No.";

            if (Mode == enMode.Update) {
                groFilter.Enabled = false;
                comPeopleColumns.Enabled = false;
                txtSearch.Enabled = false;
                btnFind.Enabled = false;
                btnAdd.Enabled = false;
                ctrlPersonCard.lilblEditPersonInfo.Enabled = true;
                ctrlPersonCard.SetPersonData(FoundPerson);
            }
            else {
                ctrlPersonCard.lilblEditPersonInfo.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtSearch.Text))
                return;

            switch (comPeopleColumns.Text) {
                case "National No.":
                    string nationalNo = txtSearch.Text;
                    FoundPerson = People.Find(nationalNo);
                    if (FoundPerson != null) {
                        ctrlPersonCard.SetPersonData(FoundPerson);
                    }
                    else {
                        FrmPopup.ShowPopup("Person was not found!");
                        ctrlPersonCard.UnsetPersonData();
                    }
                    break;

                case "Person ID":
                    int personId = Convert.ToInt32(txtSearch.Text);
                    FoundPerson = People.Find(personId);

                    if (FoundPerson != null) {
                        ctrlPersonCard.SetPersonData(FoundPerson);
                    }
                    else {
                        FrmPopup.ShowPopup("Person was not found!");
                        ctrlPersonCard.UnsetPersonData();
                    }

                    break;

                default:
                    break;
            }
        }
    }
}
