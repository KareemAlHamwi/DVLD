using Drivers___Vehicles_License_Department_Project;
using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

static class Program {
    private static ApplicationContext _mainContext;

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Initialize with login form
        _mainContext = new ApplicationContext(new FrmLogin());
        Application.Run(_mainContext);
    }

    public static void SwitchToMainForm(Users loggedInUser) {
        var mainForm = new FrmMain(loggedInUser);
        _mainContext.MainForm = mainForm;
        mainForm.Show();
    }
}
