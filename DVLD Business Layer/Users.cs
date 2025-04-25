namespace DVLD_Business_Layer {
    public class Users {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName {get; set;} = "";
        public string Password {get; set;} = "";
        public bool IsActive {get; set;}


        // public for experimenting
        public bool AddNewUser() {
            UserID = DVLD_Data_Access_Layer.UsersData.AddNewUser(PersonID,UserName,Password,IsActive.ToString());

            return UserID != -1;
        }
    }
}
