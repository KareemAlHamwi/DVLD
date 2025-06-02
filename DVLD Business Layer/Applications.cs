using System.Data;

namespace DVLD_Business_Layer {
    public class Applications {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enApplicationType {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enMode Mode = enMode.AddNew;
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public string ApplicantFullName {
            get {
                return People.Find(ApplicantPersonID).GetFullName();
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public ApplicationTypes ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText {
            get {

                switch (ApplicationStatus) {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public Users CreatedByUserInfo;

        public Applications() {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        public Applications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, decimal PaidFees,
            int CreatedByUserID) {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        public Applications(Applications sourceApplication) {
            if (sourceApplication == null) {
                ApplicationID = -1;
                ApplicantPersonID = -1;
                ApplicationDate = DateTime.Now;
                ApplicationTypeID = -1;
                ApplicationStatus = enApplicationStatus.New;
                LastStatusDate = DateTime.Now;
                PaidFees = 0;
                CreatedByUserID = -1;

                Mode = enMode.Update;
                return;
            }

            ApplicationID = sourceApplication.ApplicationID;
            ApplicantPersonID = sourceApplication.ApplicantPersonID;
            ApplicationDate = sourceApplication.ApplicationDate;
            ApplicationTypeID = sourceApplication.ApplicationTypeID;
            ApplicationStatus = sourceApplication.ApplicationStatus;
            LastStatusDate = sourceApplication.LastStatusDate;
            PaidFees = sourceApplication.PaidFees;
            CreatedByUserID = sourceApplication.CreatedByUserID;

            Mode = sourceApplication.Mode;
        }

        private bool _AddNewApplication() {
            ApplicationID = DVLD_Data_Access_Layer.ApplicationsData.AddNewApplication(ApplicantPersonID, ApplicationDate,
            ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return ApplicationID != -1;
        }

        private bool _UpdateApplication() {
            return DVLD_Data_Access_Layer.ApplicationsData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
            ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public static Applications Find(int ApplicationID) {
            int ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte ApplicationStatus = 0;
            decimal PaidFees = 0;

            // Pass parameters by reference using the 'ref' keyword
            if (DVLD_Data_Access_Layer.ApplicationsData.GetApplicationByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
            ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID)) {
                return new Applications(ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,(enApplicationStatus)ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID);
            }
            else {
                return null;
            }
        }

        public virtual bool Save() {
            switch (Mode) {
                case enMode.AddNew:
                    if (_AddNewApplication()) {
                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }

        public static DataTable GetAllApplications() {
            return DVLD_Data_Access_Layer.ApplicationsData.GetAllApplications();
        }

        public static bool DeleteApplication(int PersonID) {
            return DVLD_Data_Access_Layer.ApplicationsData.DeleteApplication(PersonID);
        }

        public static bool IsApplicationExist(int PersonID) {
            return DVLD_Data_Access_Layer.ApplicationsData.IsApplicationExist(PersonID);
        }
    }
}
