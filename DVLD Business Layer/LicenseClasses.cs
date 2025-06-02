using System.Data;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer {
    public class LicenseClasses {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public float ClassFees { set; get; }

        public LicenseClasses() {
            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 18;
            DefaultValidityLength = 10;
            ClassFees = 0;

            Mode = enMode.AddNew;
        }

        public LicenseClasses(int LicenseClassID, string ClassName,
            string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees) {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }

        private bool _AddNewLicenseClass() {
            LicenseClassID = LicenseClassData.AddNewLicenseClass(ClassName, ClassDescription,
                MinimumAllowedAge, DefaultValidityLength, ClassFees);

            return LicenseClassID != -1;
        }

        private bool _UpdateLicenseClass() {
            return LicenseClassData.UpdateLicenseClass(LicenseClassID, ClassName, ClassDescription,
                MinimumAllowedAge, DefaultValidityLength, ClassFees);
        }

        public static LicenseClasses Find(int LicenseClassID) {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (LicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new LicenseClasses(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        public static LicenseClasses Find(string ClassName) {
            int LicenseClassID = -1; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; float ClassFees = 0;

            if (LicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new LicenseClasses(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }

        public static DataTable GetAllLicenseClasses() {
            return LicenseClassData.GetAllLicenseClasses();
        }

        public bool Save() {
            switch (Mode) {
                case enMode.AddNew:
                    if (_AddNewLicenseClass()) {
                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLicenseClass();
            }
            return false;
        }
    }
}
