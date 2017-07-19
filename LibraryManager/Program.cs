using System;
using System.Windows.Forms;


namespace LibraryManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sk");
            // Setting up Slovak text for MessageBox Buttons.
            MessageBoxManager.Yes = "Áno";
            MessageBoxManager.No = "Nie";
            MessageBoxManager.Register();
            // Default auto-generated start configuration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
