using System.Data;

namespace DVLD_Business_Layer {
    public enum enGender { Male = 0, Female = 1 };
    public enum enMode { AddNew = 0, Update = 1 };

    public class People {
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public enGender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string NationalityCountryName { get; set; }
        public string ImagePath { get; set; }

        public People() {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Birthdate = DateTime.Now;
            Gender = enGender.Male;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            NationalityCountryName = "";
            ImagePath = "";

            Mode = enMode.AddNew;
        }

        public People(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime Birthdate, int Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string NationalityCountryName, string ImagePath) {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Birthdate = Birthdate;
            this.Gender = Enum.IsDefined(typeof(enGender), Gender) ? (enGender)Gender : throw new ArgumentException("Invalid gender value.");
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.NationalityCountryName = NationalityCountryName;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        public People(People sourcePerson) {
            if (sourcePerson == null) {
                PersonID = -1;
                NationalNo = "";
                FirstName = "";
                SecondName = "";
                ThirdName = "";
                LastName = "";
                Birthdate = DateTime.Now;
                Gender = enGender.Male;
                Address = "";
                Phone = "";
                Email = "";
                NationalityCountryID = -1;
                ImagePath = "";
                Mode = enMode.Update;
                return;
            }

            PersonID = sourcePerson.PersonID;
            NationalNo = sourcePerson.NationalNo;
            FirstName = sourcePerson.FirstName;
            SecondName = sourcePerson.SecondName;
            ThirdName = sourcePerson.ThirdName;
            LastName = sourcePerson.LastName;
            Birthdate = sourcePerson.Birthdate;
            Gender = sourcePerson.Gender;
            Address = sourcePerson.Address;
            Phone = sourcePerson.Phone;
            Email = sourcePerson.Email;
            NationalityCountryID = sourcePerson.NationalityCountryID;
            NationalityCountryName = sourcePerson.NationalityCountryName;
            ImagePath = sourcePerson.ImagePath;
            Mode = sourcePerson.Mode;
        }

        private bool _AddNewPerson() {
            //call DataAccess Layer 

            PersonID = DVLD_Data_Access_Layer.PeopleData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, Birthdate, (byte)Gender,
            Address, Phone, Email, NationalityCountryID, ImagePath);

            return PersonID != -1;
        }

        private bool _UpdateContact() {
            //call DataAccess Layer 

            return DVLD_Data_Access_Layer.PeopleData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Birthdate, (byte)Gender,
            Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        // public static People Find(int PersonID) {
        //     string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "", NationalityCountryName = "";
        //     enGender Gender = enGender.Male;
        //     DateTime Birthdate = DateTime.Now;
        //     int NationalityCountryID = -1;

        //     // Pass parameters by reference using the 'ref' keyword
        //     if (DVLD_Data_Access_Layer.PeopleData.GetPersonByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Birthdate, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref NationalityCountryName, ref ImagePath)) {
        //         return new People(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Birthdate, (byte)Gender,
        //             Address, Phone, Email, NationalityCountryID, NationalityCountryName, ImagePath);
        //     }
        //     else {
        //         return null;
        //     }
        // }

        public bool Save() {
            switch (Mode) {
                case enMode.AddNew:
                    if (_AddNewPerson()) {
                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateContact();
            }

            return false;
        }

        public static DataTable GetAllPeople() {
            return DVLD_Data_Access_Layer.PeopleData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID) {
            return DVLD_Data_Access_Layer.PeopleData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID) {
            return DVLD_Data_Access_Layer.PeopleData.IsPersonExist(PersonID);
        }
    }
}
