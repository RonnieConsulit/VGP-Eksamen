using System;
using System.Windows.Forms;

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

            HardcodedData.InitializeTickets();
            HardcodedData.InitializeKunder();
            HardcodedData.InitializeBrugere();

            // Run the main form
            Application.Run(new FormDashboard());

            // Initialize the hardcoded data after creating the main form

        }
    }
}
