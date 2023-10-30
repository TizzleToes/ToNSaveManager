using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Media;

namespace ToNSaveManager
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
            Application.Run(new MainWindow());
        }

        // Updater
        /*
        static void CheckForUpdate()
        {

        }
        */
    }
}