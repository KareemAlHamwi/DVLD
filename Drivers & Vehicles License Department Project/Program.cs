using System.Text.Json;
using System.Text;
using Drivers_And_Vehicles_License_Department_Project;
using Drivers_And_Vehicles_License_Department_Project;
using DVLD_Business_Layer;

static class Program {
    private static ApplicationContext _mainContext;

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Users loggedInUser;

        if (TryAutoLogin(out loggedInUser)) {
            _mainContext = new ApplicationContext(new FrmMain(loggedInUser));
        }
        else {
            _mainContext = new ApplicationContext(new FrmLogin());
        }

        Application.Run(_mainContext);
    }

    public static void SwitchToMainForm(Users loggedInUser) {
        var mainForm = new FrmMain(loggedInUser);
        _mainContext.MainForm = mainForm;
        mainForm.Show();
    }

    public static void SwitchToLoginForm() {
        var loginForm = new FrmLogin();
        _mainContext.MainForm = loginForm;
        loginForm.Show();
    }

    private static bool TryAutoLogin(out Users user) {
        user = null;

        const string REMEMBER_ME_FILE = "RememberMe.json";

        if (!File.Exists(REMEMBER_ME_FILE))
            return false;

        try {
            string json = File.ReadAllText(REMEMBER_ME_FILE);
            var info = JsonSerializer.Deserialize<ClsRememberME>(json);

            if (info == null || !info.RememberMe)
                return false;

            string username = Encoding.UTF8.GetString(Convert.FromBase64String(info.Username));
            string password = Encoding.UTF8.GetString(Convert.FromBase64String(info.Password));

            user = Users.Login(username, password);

            return user != null && user.IsActive;
        }
        catch {
            return false;
        }
    }
}
