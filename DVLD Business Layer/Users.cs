using System.Data;

namespace DVLD_Business_Layer {
    public class Users {
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsActive { get; set; }

        public Users() {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;

            Mode = enMode.AddNew;
        }

        public Users(int UserID, int PersonID, string UserName, string Password, string IsActive) {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = Convert.ToBoolean(IsActive);

            Mode = enMode.Update;
        }

        private bool _AddNewUser() {
            UserID = DVLD_Data_Access_Layer.UsersData.AddNewUser(PersonID, UserName, Password, IsActive.ToString());

            return UserID != -1;
        }

        private bool _UpdateUser() {
            return DVLD_Data_Access_Layer.UsersData.UpdateUser(UserID, UserName, Password, IsActive.ToString());
        }

        public bool Save() {
            switch (Mode) {
                case enMode.AddNew:
                    if (_AddNewUser()) {
                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers() {
            return DVLD_Data_Access_Layer.UsersData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID) {
            return DVLD_Data_Access_Layer.UsersData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID) {
            return DVLD_Data_Access_Layer.UsersData.IsUserExist(UserID);
        }

        public static Users Find(int UserID) {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            // Pass parameters by reference using the 'ref' keyword
            if (DVLD_Data_Access_Layer.UsersData.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive)) {
                return new Users(UserID, PersonID, UserName, Password, IsActive.ToString());
            }
            else {
                return null;
            }
        }
    }
}
