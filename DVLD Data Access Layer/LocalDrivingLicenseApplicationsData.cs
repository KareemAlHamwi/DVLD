using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Access_Layer {
    public class LocalDrivingLicenseApplicationsData {
        public static bool GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID) {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID) {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
            (ApplicationID,LicenseClassID) VALUES
            (@ApplicationID,@LicenseClassID);
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    LocalDrivingLicenseApplicationID = insertedID;
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID) {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications
                        set LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                        ApplicationID = @ApplicationID,
                        LicenseClassID = @LicenseClassID
                        WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static DataTable GetAllLocalDrivingLicenseApplications() {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

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

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID) {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID) {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
