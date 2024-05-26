using System;
using System.IO;
using System.Collections.Generic;
using Eksamen.Classes;
using System.Text;

namespace Eksamen.Datahåndtering
{
    public class CheckCSVExistence
    {
        private string projectFolderPath;

        public CheckCSVExistence(string folderPath)
        {
            projectFolderPath = folderPath;
        }

        public void CheckAndCreateCSVFiles()
        {
            try
            {
                string[] csvFiles = { "TicketsCSV.csv", "AktiviteterCSV.csv", "BrugerCSV.csv", "KunderCSV.csv" };
                foreach (string csvFile in csvFiles)
                {
                    string filePath = Path.Combine(projectFolderPath, csvFile);
                    if (!File.Exists(filePath))
                    {
                        // Get hardcoded data into the list
                        HardcodedData.InitializeTickets();
                        HardcodedData.InitializeKunder();
                        HardcodedData.InitializeBrugere();


                        // Create the CSV file
                        File.Create(filePath).Close();
                        Console.WriteLine($"Created {csvFile}.");

                        switch (csvFile)
                        {
                            case "TicketsCSV.csv":
                                AppendDataToCSVFile(filePath, TicketData.alleTicketsList);
                                break;
                            case "AktiviteterCSV.csv":
                                List<Aktiviteter> alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTicketsToCSV(TicketData.alleTicketsList);
                                AppendDataToCSVFile(filePath, alleAktiviteter);
                                break;
                            case "BrugerCSV.csv":
                                AppendDataToCSVFile(filePath, Personer.BrugerData.alleBrugereList);
                                break;
                            case "KunderCSV.csv":
                                AppendDataToCSVFile(filePath, Personer.KundeData.alleKunderList);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{csvFile} already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking and creating CSV files: " + ex.Message);
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
                        writer.WriteLine(data.ToString());
                    }
                }
                Console.WriteLine($"Appended data to {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error appending data to {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }


    }
}
