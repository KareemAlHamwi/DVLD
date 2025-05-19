using System.Data;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer {
    public class TestTypes {
        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public TestTypes() {
            TestTypeID = -1;
            Title = "";
            Description = "";
            Fees = 0;
        }

        public TestTypes(int TestTypeID, string Title, string Description, decimal Fees) {
            this.TestTypeID = TestTypeID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public TestTypes(TestTypes sourceTestType) {
            if (sourceTestType == null) {
                TestTypeID = -1;
                Title = "";
                Description = "";
                Fees = 0;
                return;
            }

            TestTypeID = sourceTestType.TestTypeID;
            Title = sourceTestType.Title;
            Description = sourceTestType.Description;
            Fees = sourceTestType.Fees;
        }

        private bool _UpdateTestType() {
            return TestTypesData.UpdateTestType(TestTypeID, Title, Description, Fees);
        }

        public bool Save() {
            return _UpdateTestType();
        }
        
        public static DataTable GetAllTestTypes() {
            return TestTypesData.GetAllTestTypes();
        }
    }
}
