using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Access_Layer {
    public class UsersData {
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive) {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserByUserName(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive) {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally {
                connection.Close();
            }

            return isFound;
        }

        private static bool IsPersonLinkedBefore(int PersonID) {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    return true;
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return false;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, string IsActive) {
            int UserID = -1;

            if (IsPersonLinkedBefore(PersonID)) {
                return UserID;
            }

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID,UserName,[Password],IsActive)
                            VALUES (@PersonID,@UserName,@Password,@IsActive);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    UserID = insertedID;
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, string IsActive) {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE Users
                            set UserName = @UserName,
                            [Password] = @Password,
                            IsActive = @IsActive
                            WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("IsActive", IsActive);

            try {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllUsers() {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT
                            u.UserID AS 'User ID',
                            u.PersonID AS 'Person ID',
                            CONCAT_WS(' ', p.FirstName, p.SecondName, p.ThirdName, p.LastName) AS 'Full Name',
                            u.UserName,
                            u.IsActive AS 'Is Active',
							u.UserName
                            FROM Users u
                            LEFT JOIN People p ON p.PersonID = u.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return dt;
        }

        public static bool DeleteUser(int UserID) {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool IsUserExist(int UserID) {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally {
                connection.Close();
            }

            return isFound;
        }

        public static bool Login(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsActive) {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally {
                connection.Close();
            }

            return IsFound;
        }

        public static bool ConfirmPassword(string UserName, string Password) {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 From Users WHERE UserName = @UserName AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally {
                connection.Close();
            }

            return isFound;
        }
    }
}
