using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Access_Layer {
    public class ApplicationsData {
        public static bool GetApplicationByID(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate,
            ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees,
            ref int CreatedByUserID) {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    IsFound = true;

                    ApplicationPersonID = (int)reader["ApplicationPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,
            int CreatedByUserID) {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications
            (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID) VALUES
            (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID);
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ApplicationID = insertedID;
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                connection.Close();
            }

            return ApplicationID;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,
            int CreatedByUserID) {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications
                            set ApplicationID = @ApplicationID,
                            ApplicantPersonID = @ApplicantPersonID,
                            ApplicationDate = @ApplicationDate,
                            ApplicationTypeID = @ApplicationTypeID,
                            ApplicationStatus = @ApplicationStatus,
                            LastStatusDate = @LastStatusDate,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedByUserID
                            WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static DataTable GetAllApplications() {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT * from Applications";

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

        public static bool DeleteApplication(int ApplicationID) {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool IsApplicationExist(int ApplicationID) {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
