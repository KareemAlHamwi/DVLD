using System.Data;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer {
    public class LocalDrivingLicenseApplications : Applications {
        public enMode LocalMode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public LicenseClasses LicenseClassInfo;
        public string PersonFullName {
            get {
                return People.Find(ApplicantPersonID).GetFullName();
            }

        }

        public LocalDrivingLicenseApplications() {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;

            LocalMode = enMode.AddNew;
        }

        public LocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID, int LicenseClassID) {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = LicenseClasses.Find(LicenseClassID);
            LocalMode = enMode.Update;
        }

        public LocalDrivingLicenseApplications(LocalDrivingLicenseApplications sourceLocalDrivingLicenseApplication) {
            if (sourceLocalDrivingLicenseApplication == null) {
                LocalDrivingLicenseApplicationID = -1;
                LicenseClassID = -1;

                LocalMode = enMode.AddNew;
                return;
            }

            LocalDrivingLicenseApplicationID = sourceLocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            ApplicationID = sourceLocalDrivingLicenseApplication.ApplicationID;
            ApplicantPersonID = sourceLocalDrivingLicenseApplication.ApplicantPersonID;
            ApplicationDate = sourceLocalDrivingLicenseApplication.ApplicationDate;
            ApplicationTypeID = sourceLocalDrivingLicenseApplication.ApplicationTypeID;
            ApplicationStatus = sourceLocalDrivingLicenseApplication.ApplicationStatus;
            LastStatusDate = sourceLocalDrivingLicenseApplication.LastStatusDate;
            PaidFees = sourceLocalDrivingLicenseApplication.PaidFees;
            CreatedByUserID = sourceLocalDrivingLicenseApplication.CreatedByUserID;
            LicenseClassID = sourceLocalDrivingLicenseApplication.LicenseClassID;
            LicenseClassInfo = LicenseClasses.Find(sourceLocalDrivingLicenseApplication.LicenseClassID);
            LocalMode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication() {
            LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);

            return LocalDrivingLicenseApplicationID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication() {
            return LocalDrivingLicenseApplicationsData.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        }

        public override bool Save() {
            bool baseSaveSuccess = base.Save();

            switch (LocalMode) {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication()) {
                        LocalMode = enMode.Update;
                        return baseSaveSuccess && true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return baseSaveSuccess && _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications() {
            return LocalDrivingLicenseApplicationsData.GetAllLocalDrivingLicenseApplications();
        }

        public static bool DeleteUser(int LocalDrivingLicenseApplicationID) {
            return LocalDrivingLicenseApplicationsData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }

        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID) {
            return LocalDrivingLicenseApplicationsData.IsLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID);
        }

        // public static LocalDrivingLicenseApplications Find(int LocalDrivingLicenseApplicationID) {
        //     int ApplicationID = 0, LicenseClassID = 0;

        //     if (LocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID)) {
        //         return new LocalDrivingLicenseApplications();
        //     }
        //     else {
        //         return null;
        //     }
        // }
    }
}
