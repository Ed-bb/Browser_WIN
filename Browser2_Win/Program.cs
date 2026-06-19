using Browser2_Win.Forms;
using System.Runtime.CompilerServices;

namespace Browser2_Win
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetColorMode(SystemColorMode.Dark);
            Application.SetDefaultFont(new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new BrowserForm());
        }
    }
}