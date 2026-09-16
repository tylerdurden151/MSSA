namespace Assignments_11._3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Surface any unhandled exception in a message box instead of the app
            // silently closing — remove once the app is stable.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) =>
                MessageBox.Show(e.Exception.ToString(), "Unhandled UI exception");
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                MessageBox.Show((e.ExceptionObject as Exception)?.ToString() ?? "Unknown error", "Unhandled exception");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Mainform());
        }
    }
}