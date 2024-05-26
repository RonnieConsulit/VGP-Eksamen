using System;
using System.Windows.Forms;
using Eksamen.Datahåndtering;

namespace Eksamen
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

            CheckCSVExistence csvChecker = new CheckCSVExistence(Environment.CurrentDirectory);

            csvChecker.CheckAndCreateCSVFiles();



            // Run the main form
            Application.Run(new FormDashboard());
        }
    }
}
