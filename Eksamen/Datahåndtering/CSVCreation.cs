using System;
using System.IO;
using System.Collections.Generic;
using Eksamen.Classes;
using System.Text;
using static Eksamen.Classes.Personer;
using Microsoft.VisualBasic.FileIO;

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
                bool anyCSVExists = false;
                string[] csvFiles = { "TicketsCSV.csv", "AktiviteterCSV.csv", "BrugerCSV.csv", "KunderCSV.csv" };
                foreach (string csvFile in csvFiles)
                {
                    string filePath = Path.Combine(projectFolderPath, csvFile);
                    if (File.Exists(filePath))
                    {
                        anyCSVExists = true;
                        break;
                    }
                }

                if (!anyCSVExists)
                {
                    // If none of the CSV files exist, initialize hardcoded data
                    HardcodedData.InitializeTickets();
                    HardcodedData.InitializeKunder();
                    HardcodedData.InitializeBrugere();
                    Console.WriteLine("Initialized hardcoded data.");
                }




                foreach (string csvFile in csvFiles)
                {
                    string filePath = Path.Combine(projectFolderPath, csvFile);
                    if (!File.Exists(filePath))
                    {
                        // Create the CSV file
                        File.Create(filePath).Close();
                        Console.WriteLine($"Created {csvFile}.");

                        switch (csvFile)
                        {
                            case "TicketsCSV.csv":
                                AppendDataToCSVFile(filePath, TicketData.alleTicketsList);
                                break;
                            case "AktiviteterCSV.csv":
                                List<Aktiviteter> alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList);
                                AppendDataToCSVFile(filePath, alleAktiviteter);
                                break;
                            case "BrugerCSV.csv":
                                AppendDataToCSVFile(filePath, BrugerData.alleBrugereList);
                                break;
                            case "KunderCSV.csv":
                                AppendDataToCSVFile(filePath, KundeData.alleKunderList);
                                break;
                        }
                    }
                    else
                    {
                        switch (csvFile)
                        {
                            case "TicketsCSV.csv":
                                ImportTicket(csvFile);
                                break;
                            case "AktiviteterCSV.csv":
                                ImportAktiviteter(csvFile);
                                break;
                            case "BrugerCSV.csv":
                                ImportBrugere(csvFile);
                                break;
                            case "KunderCSV.csv":
                                ImportKunder(csvFile);
                                break;
                        }
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

        private void ImportBrugere(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                   

                        string[] parts = line.Split(',');
                        if (parts.Length >= 6)
                        {
                            int id = int.Parse(parts[0]);
                            string navn = parts[2]; // Extracting name from index 2
                            string adresse = parts[3]; // Extracting address from index 3
                            string email = parts[4]; // Extracting email from index 4
                            int telefon = int.Parse(parts[1]); // Extracting phone number from index 1
                            string beskrivelse = parts[5]; // Extracting description from index 5

                            // Add to the Bruger list
                            BrugerData.alleBrugereList.Add(new Bruger(navn, adresse, email, telefon, beskrivelse, id));
                        }
                    }
                }
                Console.WriteLine($"Imported brugere from {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing brugere from {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }
        private void ImportKunder(string filePath)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] parts = parser.ReadFields();

                        if (parts.Length >= 6)
                        {
                            int id;
                            if (int.TryParse(parts[1], out id)) // Adjusted index for ID
                            {
                                string navn = parts[2];
                                string adresse = parts[3];
                                string email = parts[4];
                                string kontakt = parts[0];
                                string beskrivelse = parts[5];

                                // Add to the Kunde list
                                KundeData.alleKunderList.Add(new Kunde(navn, adresse, email, kontakt, beskrivelse, id));
                            }
                            else
                            {
                                Console.WriteLine($"Failed to parse id: {parts[1]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line: {string.Join(",", parts)}");
                        }
                    }
                }
                Console.WriteLine($"Imported kunder from {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing kunder from {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }



        private void ImportAktiviteter(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 7) // Make sure there are at least 7 parts
                        {
                            int id = int.Parse(parts[0]);
                            string navn = parts[1];
                            int ticketNummer = int.Parse(parts[2]);
                            string firma = parts[3];
                            string ansvarlig = parts[4];
                            string beskrivelse = parts[5];
                            string status = parts[6];

                            // Find the ticket corresponding to the ticketNummer
                            Ticket ticket = TicketData.alleTicketsList.Find(t => t.Id == ticketNummer);
                            if (ticket != null)
                            {
                                // Create the Aktiviteter object using the constructor
                                Aktiviteter aktivitet = new Aktiviteter(ticket, ticketNummer, navn, beskrivelse, id)
                                {
                   
                                };

                                // Add the Aktiviteter object to the ticket's activity list
                                ticket.AktivitetList.Add(aktivitet);
                            }
                        }
                    }
                }
                Console.WriteLine($"Imported activities from {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing activities from {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }



        private void ImportTicket(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5)
                        {
                            int id = int.Parse(parts[0]);
                            string navn = parts[1];
                            string kunde = parts[2];
                            string ansvarlig = parts[3];
                            string status = parts[4];

                            // Add to the Tickets list
                            TicketData.alleTicketsList.Add(new Ticket
                            {
                                Id = id,
                                Navn = navn,
                                Kunde = kunde,
                                Ansvarlig = ansvarlig,
                                Status = status
                            });
                        }
                    }
                }
                Console.WriteLine($"Imported tickets from {Path.GetFileName(filePath)}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing tickets from {Path.GetFileName(filePath)}: {ex.Message}");
            }
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

    }
}
