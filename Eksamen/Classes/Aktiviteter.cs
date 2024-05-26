using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Eksamen.Classes
{
    public class Aktiviteter
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int TicketNummer { get; set; }
        public string Kunde { get; set; }
        public string Ansvarlig { get; set; }
        public string Beskrivelse { get; set; }
        public string Status { get; set; }

        public Aktiviteter(Ticket ticket, int ticketNummer, string navn, string beskrivelse)
        {
            Id = GenerateId();
            Navn = navn;
            TicketNummer = ticketNummer;
            Kunde = ticket.Kunde;
            Ansvarlig = ticket.Ansvarlig;
            Beskrivelse = beskrivelse;
            Status = "Åben";
        }

        public Aktiviteter()
        {

        }

        protected virtual int GenerateId()
        {
            return Counter.NextActivty();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}";
        }

        public static List<Aktiviteter> GetAllAktiviteterFromTickets(List<Ticket> tickets)
        {
            List<Aktiviteter> alleAktiviteter = new List<Aktiviteter>();

            foreach (Ticket ticket in tickets)
            {
                foreach (Aktiviteter aktivitet in ticket.AktivitetList)
                {
                    alleAktiviteter.Add(aktivitet);
                }
            }

            return alleAktiviteter;
        }

        // new list for CSV
        public static List<Aktiviteter> GetAllAktiviteterFromTicketsToCSV(List<Ticket> tickets)
        {
            List<Aktiviteter> alleAktiviteterCSV = new List<Aktiviteter>();

            foreach (Ticket ticket in tickets)
            {
                foreach (Aktiviteter aktivitet in ticket.AktivitetList)
                {
                    // Create a new Aktiviteter object with all properties populated
                    Aktiviteter fullAktivitet = new Aktiviteter(
                        ticket,
                        aktivitet.TicketNummer,
                        aktivitet.Navn,
                        aktivitet.Beskrivelse);

               
                    alleAktiviteterCSV.Add(fullAktivitet);
                }
            }

            return alleAktiviteterCSV;
        }

        public static bool CreateNewActivity(Ticket ticket, int ticketNummer, string navn, string beskrivelse)
        {
            if (string.IsNullOrWhiteSpace(navn) || string.IsNullOrWhiteSpace(beskrivelse))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Aktiviteter newActivity = new Aktiviteter(ticket, ticketNummer, navn, beskrivelse);
            ticket.AktivitetList.Add(newActivity);
            return true;
        }

        public static void DisplayAktiviteterInListBox(ListBox listBox, List<Aktiviteter> aktiviteter)
        {
            listBox.Items.Clear();
            foreach (Aktiviteter aktivitet in aktiviteter)
            {
                listBox.Items.Add(aktivitet);
            }
        }

        public static void DisplayAktiviteterInListBox(ListBox listBox, List<Aktiviteter> aktiviteter, string status)
        {
            listBox.Items.Clear();
            foreach (Aktiviteter aktivitet in aktiviteter)
            {
                if (aktivitet.Status == status)
                {
                    listBox.Items.Add(aktivitet);
                }
            }
        }

        public static void Exit(Form form)
        {
            form.Close();
        }

        public static void Gem(ListBox listBox, TextBox txtBoxNavn, ComboBox comboBoxAnsvarlig, ComboBox comboBoxStatus, ComboBox comboBoxKunder, TextBox txtBoxBeskrivelse, ComboBox comboBoxTickets)
        {
            if (listBox.SelectedItem != null)
            {
                Aktiviteter selectAktiviteter = (Aktiviteter)listBox.SelectedItem;

                selectAktiviteter.Navn = txtBoxNavn.Text;
                selectAktiviteter.Ansvarlig = comboBoxAnsvarlig.Text;
                selectAktiviteter.Status = comboBoxStatus.Text;
                selectAktiviteter.Kunde = comboBoxKunder.Text;
                selectAktiviteter.Beskrivelse = txtBoxBeskrivelse.Text;

                string selectedTicketName = comboBoxTickets.Text;

                Ticket newSelectedTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Navn == selectedTicketName);

                if (newSelectedTicket != null)
                {
                    Ticket originalTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Id == selectAktiviteter.TicketNummer);

                    if (originalTicket != null)
                    {
                        originalTicket.AktivitetList.Remove(selectAktiviteter);
                    }

                    newSelectedTicket.AktivitetList.Add(selectAktiviteter);

                    selectAktiviteter.TicketNummer = newSelectedTicket.Id;

                    DisplayAktiviteterInListBox(listBox, GetAllAktiviteterFromTickets(TicketData.alleTicketsList));

                    MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fejl: Kunne ikke finde den valgte ticket.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Marker venligst aktivitet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public static List<Aktiviteter> CloseActivitiesWithTicketNumber(Ticket ticket)
        {
            List<Aktiviteter> alleAktiviteterPåTicket = new List<Aktiviteter>();

            // Find and close all activities associated with the specified ticket
            foreach (Aktiviteter aktivitet in ticket.AktivitetList)
            {
                aktivitet.Status = "Lukket";
                alleAktiviteterPåTicket.Add(aktivitet);
            }

            return alleAktiviteterPåTicket;
        }
    }
}
