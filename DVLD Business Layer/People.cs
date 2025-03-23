﻿using System.Data;

namespace DVLD_Business_Layer {
    public enum enGender { Male = 0, Female = 1 };
    public enum enMode { AddNew = 0, Update = 1 };

    public class People {
        public enMode Mode = enMode.AddNew;
        public int PersonID { get; private set; }
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
        public int NationalityCountryID { get; private set; }
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
            ImagePath = "";

            Mode = enMode.AddNew;
        }

        public People(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime Birthdate, byte Gender, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath) {
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
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson() {
            //call DataAccess Layer 

            PersonID = DVLD_Data_Access_Layer.PeopleData.AddNewPerson(NationalNo,FirstName,SecondName,ThirdName, LastName,Birthdate,(byte)Gender,
            Address,Phone,Email,NationalityCountryID,ImagePath);

            return PersonID != -1;
        }

        private bool _UpdateContact() {
            //call DataAccess Layer 

            return DVLD_Data_Access_Layer.PeopleData.UpdatePerson(PersonID,NationalNo,FirstName,SecondName,ThirdName, LastName,Birthdate,(byte)Gender,
            Address,Phone,Email,NationalityCountryID,ImagePath);
        }

        public static People Find(int PersonID) {

            string NationalNo = "", FirstName = "",SecondName = "",ThirdName = "", LastName = "", Address = "", Phone = "" ,Email = "", ImagePath = "";
            enGender Gender = enGender.Male;
            DateTime Birthdate = DateTime.Now;
            int NationalityCountryID = -1;

            if (DVLD_Data_Access_Layer.PeopleData.GetPersonByID(PersonID,NationalNo,FirstName,SecondName,ThirdName, LastName,Birthdate,(byte)Gender,
            Address,Phone,Email,NationalityCountryID,ImagePath))

                return new People(PersonID,NationalNo,FirstName,SecondName,ThirdName, LastName,Birthdate,(byte)Gender,
            Address,Phone,Email,NationalityCountryID,ImagePath);
            else
                return null;
        }

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
