using Eksamen.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Eksamen.Classes.Personer;

namespace Eksamen.Datahåndtering
{
    public class CSVHandler
    {
        private string projectFolderPath;

        public CSVHandler()
        {
            // Set the project folder path dynamically
            projectFolderPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void UpdateCSVFile<T>(string csvFileName, List<T> dataList)
        {
            try
            {
                string filePath = Path.Combine(projectFolderPath, csvFileName);

                // Delete the existing file if it exists
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine($"Deleted existing {csvFileName}.");
                }

                // Create a new CSV file and append updated data
                AppendDataToCSVFile(filePath, dataList);
                Console.WriteLine($"Recreated {csvFileName} with updated data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating {csvFileName}: {ex.Message}");
            }
        }

        private void AppendDataToCSVFile<T>(string filePath, List<T> dataList)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    foreach (T data in dataList)
                    {
                        writer.WriteLine(SerializeObject(data));
                    }
                }
                Console.WriteLine($"Appended data to {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error appending data to {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }

        private string SerializeObject<T>(T obj)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var prop in typeof(T).GetProperties())
            {
                if (sb.Length > 0)
                    sb.Append(",");
                var value = prop.GetValue(obj);
                sb.Append(value != null ? value.ToString() : "");
            }
            return sb.ToString();
        }

        // Add method to update all CSV files
        public void UpdateAllCSVFiles()
        {
            try
            {
                // Update TicketsCSV.csv
                UpdateCSVFile("TicketsCSV.csv", TicketData.alleTicketsList);

                // Update AktiviteterCSV.csv
                List<Aktiviteter> alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList);
                UpdateCSVFile("AktiviteterCSV.csv", alleAktiviteter);

                // Update BrugerCSV.csv
                UpdateCSVFile("BrugerCSV.csv", BrugerData.alleBrugereList);

                // Update KunderCSV.csv
                UpdateCSVFile("KunderCSV.csv", KundeData.alleKunderList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating all CSV files: {ex.Message}");
            }
        }
    }
}
