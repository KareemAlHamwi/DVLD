using System.Data;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer {
    public class Countries {
        private int CountryID { get; set; }
        public string CountryName { get; set; }

        public Countries() {
            CountryID = -1;
            CountryName = "";
        }

        public Countries(int CountryID, string CountryName) {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static Countries Find(int CountryID) {
            string CountryName = "";

            if (CountriesData.GetCountryByID(CountryID, ref CountryName)) {
                return new Countries(CountryID,CountryName);
            }
            else {
                return null;
            }
        }

        public static DataTable GetAllCountries() {
            return CountriesData.GetAllCountries();
        }
    }
}
