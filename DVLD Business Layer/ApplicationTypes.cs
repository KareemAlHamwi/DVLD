using System.Data;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer {
    public class ApplicationTypes {
        public int ApplicationTypeID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }

        public ApplicationTypes() {
            ApplicationTypeID = -1;
            Title = "";
            Fees = 0;
        }

        public ApplicationTypes(int ApplicationTypeID, string Title, decimal Fees) {
            this.ApplicationTypeID = ApplicationTypeID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public ApplicationTypes(ApplicationTypes sourceApplicationType) {
            if (sourceApplicationType == null) {
                ApplicationTypeID = -1;
                Title = "";
                Fees = 0;
                return;
            }

            ApplicationTypeID = sourceApplicationType.ApplicationTypeID;
            Title = sourceApplicationType.Title;
            Fees = sourceApplicationType.Fees;
        }

        private bool _UpdateApplicationType() {
            return ApplicationTypesData.UpdateApplicationType(ApplicationTypeID, Title, Fees);
        }

        public bool Save() {
            return _UpdateApplicationType();
        }
        
        public static DataTable GetAllApplicationTypes() {
            return ApplicationTypesData.GetAllApplicationTypes();
        }
    }
}
