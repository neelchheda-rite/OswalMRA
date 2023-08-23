using NLog;
using NLog.Config;
using NLog.Targets;
using OswalMRA.Layout;

namespace OswalMRA
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure NLog using the configuration file
            var config = new LoggingConfiguration();
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, new FileTarget("logfile"));

            LogManager.Configuration = config;

            try
            {
                ApplicationConfiguration.Initialize();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //frmSplashScreen frmHomeScreen = new frmSplashScreen();
                //Application.Run(frmHomeScreen);

                //if (frmHomeScreen.IsDisposed)
                //{
                //    frmFullLayout frmFullLayout = new frmFullLayout();
                //    Application.Run(frmFullLayout);
                //}
                frmFullLayout frmFullLayout = new frmFullLayout();
                mouldManagementForm mouldManagementForm = new();

                Application.Run(frmFullLayout);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An unhandled exception occurred.");
            }
        }
    }
}
