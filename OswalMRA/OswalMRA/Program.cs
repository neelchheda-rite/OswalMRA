using OswalMRA.Layout;

namespace OswalMRA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmSplashScreen frmHomeScreen  = new frmSplashScreen();
            //Application.Run(frmHomeScreen);

            //if (frmHomeScreen.IsDisposed)
            //{
            //    //frmMainLayout frmMainLayout = new frmMainLayout();
            //    //Application.Run(frmMainLayout);
            //    frmFullLayout frmFullLayout = new frmFullLayout();
            //    Application.Run(frmFullLayout);
            //}

            //frmFullLayout frmFullLayout = new frmFullLayout();
            //frmNewMould frmNewMould = new frmNewMould();
            mouldManagementForm mouldManagementForm = new mouldManagementForm();
            Application.Run(mouldManagementForm);
        }
    }
}