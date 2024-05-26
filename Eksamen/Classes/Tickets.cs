namespace Eksamen.Classes
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Kunde { get; set; }
        public string Ansvarlig { get; set; }
        public string Status { get; set; }
        public List<Aktiviteter> AktivitetList { get; set; } = new List<Aktiviteter>();

        public Ticket(string navn, string kunde, string ansvarlig, string status)
        {
            Id = GenerateId();
            Navn = navn;
            Kunde = kunde;
            Ansvarlig = ansvarlig;
            Status = status;
        }

        public Ticket()
        {

        }

        public override string ToString()
        {r
            return $"Id: {Id}, Navn: {Navn}, Kunde: {Kunde}";
        }

        protected virtual int GenerateId()
        {
            return Counter.NextTicket();
        }

        public static bool CreateNewTicket(string navn, string kunde, string ansvarlig, string status)
        {
            // Alt skal være udfyldt
            if (string.IsNullOrWhiteSpace(navn) ||
                string.IsNullOrWhiteSpace(kunde) ||
                string.IsNullOrWhiteSpace(ansvarlig) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Findes ticketnavn allerede
            if (!IsUniqueTicketName(navn))
            {
                MessageBox.Show("Ticketnavn eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Ticket newTicket = new Ticket(navn, kunde, ansvarlig, status);
            TicketData.alleTicketsList.Add(newTicket);
            return true;
        }

        private static bool IsUniqueTicketName(string ticketNavn)
        {
            return !TicketData.alleTicketsList.Any(ticket => ticket.Navn.Equals(ticketNavn));
        }

        public void UpdateTicketInfo(ComboBox comboBoxKunde, ComboBox comboBoxAnsvarlig, ComboBox comboBoxStatus, TextBox txtBoxNavn, ListBox listBoxTickets)
        {
            if (this != null)
            {
                // Alt skal være udfyldt
                if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxKunde.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxAnsvarlig.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxStatus.Text))
                {
                    MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Navn = txtBoxNavn.Text;
                Ansvarlig = comboBoxAnsvarlig.Text;
                Kunde = comboBoxKunde.Text;
                Status = comboBoxStatus.Text;

                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateListBox(listBoxTickets);
            }
            else
            {
                MessageBox.Show("Ingen ticket er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateListBox(ListBox listBoxTickets)
        {

            int selectedIndex = listBoxTickets.SelectedIndex;

            Ticket selectedTicket = (Ticket)listBoxTickets.SelectedItem;

            listBoxTickets.DataSource = null;
            listBoxTickets.DataSource = TicketData.alleTicketsList;
            listBoxTickets.DisplayMember = "Info";


            listBoxTickets.SelectedIndex = selectedIndex;
        }

        public void DeleteSelectedTicket(ListBox listBoxTickets, TextBox txtBoxNavn, ComboBox comboBoxAnsvarlig, ComboBox comboBoxKunde, ComboBox comboBoxStatus, ListBox listBoxAktiviteter)
        {
            if (this != null)
            {
                int index = listBoxTickets.SelectedIndex;

                if (index >= 0 && index < TicketData.alleTicketsList.Count)
                {
                    // Slet
                    TicketData.alleTicketsList.RemoveAt(index);

                    // Opdater liste og clear tekst
                    listBoxTickets.DataSource = null;
                    listBoxTickets.DataSource = TicketData.alleTicketsList;
                    listBoxTickets.DisplayMember = "Info";
                    txtBoxNavn.Text = "";
                    comboBoxAnsvarlig.Text = "";
                    comboBoxKunde.Text = "";
                    comboBoxStatus.Text = "";
                    listBoxAktiviteter.Text = "";

                    listBoxAktiviteter.Items.Clear();
                    MessageBox.Show("Ticket er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ticket kunne ikke findes i listen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingen ticket er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void AddActivityToSelectedTicket(Form parentForm, Ticket selectedTicket)
        {
            if (selectedTicket != null)
            {

                Menu.Instance.ÅbenTilføjAktiviteter(parentForm, selectedTicket);
            }
            else
            {
                MessageBox.Show("Vælg venligst en ticket for at tilføje en aktivitet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeleteSelectedActivity(ListBox listBoxAktiviteter)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {

                Aktiviteter selectedAktivitet = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                // Find tilhørende tickets
                Ticket tilhørendeTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Id == selectedAktivitet.TicketNummer);

                if (tilhørendeTicket != null)
                {

                    tilhørendeTicket.AktivitetList.Remove(selectedAktivitet);

                    listBoxAktiviteter.DataSource = null;
                    listBoxAktiviteter.DataSource = tilhørendeTicket.AktivitetList;
                    listBoxAktiviteter.DisplayMember = "Info";

                    MessageBox.Show("Aktivitet er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fejl: Ingen korresponderende ticket fundet.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingen aktivitet er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SortAndDisplayTicketsInListBox(ListBox listBoxTickets, string status)
        {
      
            listBoxTickets.DataSource = null;
            listBoxTickets.Items.Clear();

            foreach (Ticket ticket in TicketData.alleTicketsList)
            {
                if (ticket.Status == status)
                {
                    listBoxTickets.Items.Add(ticket);
                }
            }
        }

        public void FakturerTicket(ListBox listBoxTickets, string kunde)
        {
            string customerEmail = "";

            if (!string.IsNullOrEmpty(kunde))
            {
                foreach (Kunde ønsketKunde in Personer.KundeData.alleKunderList)
                {
                    if (ønsketKunde.Navn == kunde)
                    {
                        customerEmail = ønsketKunde.Email;
                        break; // Exit the loop once the customer is found
                    }
                }
            }

            if (!string.IsNullOrEmpty(customerEmail))
            {
                if (listBoxTickets.SelectedItem != null)
                {
                    Ticket selectedTicket = (Ticket)listBoxTickets.SelectedItem; // Get the selected ticket

                    // Close activities associated with the ticket
                    List<Aktiviteter> closedActivities = Aktiviteter.CloseActivitiesWithTicketNumber(selectedTicket);

                    // Close the ticket
                    selectedTicket.Status = "Lukket";

                    // Generate receipt
                    string kvittering = Kvittering.GenerateKvittering(selectedTicket, closedActivities);

                    // Send receipt via email
                    Email emailService = new Email();
                    string subject = $"Kvittering for ticket: {selectedTicket.Navn}";
                    emailService.SendEmail(customerEmail, subject, kvittering);
                }
                else
                {
                    MessageBox.Show("Ingen ticket er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kunde med den angivne e-mail blev ikke fundet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }

    internal static class TicketData
    {
        public static List<Ticket> alleTicketsList = new List<Ticket>();
        public static List<string> alleTicketStatus = new List<string> { "Åben", "Lukket" };

    }
}
