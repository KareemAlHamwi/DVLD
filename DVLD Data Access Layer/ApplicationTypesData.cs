using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Access_Layer {
    public class ApplicationTypesData {
        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees) {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes
                            set ApplicationTypeTitle = @ApplicationTypeTitle,
                            ApplicationFees = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("ApplicationFees", ApplicationFees);

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

        public static DataTable GetAllApplicationTypes() {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"select ApplicationTypeID as ID, ApplicationTypeTitle as Title, ApplicationFees as Fees from ApplicationTypes";

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
    }
}
