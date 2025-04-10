using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers_And_Vehicles_License_Department_Project {
    internal class PresentationSettings {
        public static string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public static DateTime MaxDate = DateTime.Now.AddYears(-18);
        public static FrmPersonDetails pd;
        public static FrmAddUpdatePerson aup;

        public static void NotImplementedMessage() {
            FrmPopup.ShowPopup("Feature is not implemented yet!");
        }
    }
}
