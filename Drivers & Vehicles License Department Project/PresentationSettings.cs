using Drivers___Vehicles_License_Department_Project;
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
        public static FrmUserDetails ud;
        public static FrmAddUpdatePerson aup;
        public static FrmAddUpdateUser auu;
        public static FrmChangePassword cp;

        public static void NotImplementedMessage() {
            FrmPopup.ShowPopup("Feature is not implemented yet!");
        }

        public static void AllowOnlyLetters(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ') {
                e.Handled = true;
            }
        }

        public static void AllowOnlyDigits(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
