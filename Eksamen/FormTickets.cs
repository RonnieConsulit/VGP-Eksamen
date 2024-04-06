using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormTickets : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private FormTilføjTickets formTilføjTickets;
        private FormTilføjAktivitet formTilføjAktivitet;

        private Ticket selectedTicket;

        public FormTickets()
        {
            InitializeComponent();

        }

        private void formTickets_Load(object sender, EventArgs e)
        {
            listBoxTickets.DataSource = TicketData.alleTicketsList;
            listBoxTickets.DisplayMember = "Info";
            listBoxAktiviteter.DisplayMember = "Info";

            listBoxTickets.SelectedIndexChanged += ListBoxTickets_SelectedIndexChanged;

            // Clear the selected item when the form loads
            listBoxTickets.ClearSelected();
            listBoxAktiviteter.ClearSelected();

        }

        private Menu menu = new Menu();

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            menu.ÅbnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            menu.ÅbnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.ÅbnKunder(this);
        }
        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.ÅbenBrugere(this);
        }




        private void ListBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxTickets.SelectedItem != null)
            {
                Ticket selectedTicket = (Ticket)listBoxTickets.SelectedItem;


                comboBoxKunde.DataSource = KunderData.alleKunderList;
                comboBoxKunde.DisplayMember = "Navn";
                comboBoxKunde.ValueMember = "Navn";
                Kunde selectedKunde = KunderData.alleKunderList.FirstOrDefault(k => k.Navn == selectedTicket.Kunde);
                comboBoxKunde.SelectedItem = selectedKunde;



                comboBoxAnsvarlig.DataSource = BrugerData.alleBrugereList;
                comboBoxAnsvarlig.DisplayMember = "Navn";
                comboBoxAnsvarlig.ValueMember = "Navn";
                Brugere selectedAnsvarlig = BrugerData.alleBrugereList.FirstOrDefault(b => b.Navn == selectedTicket.Ansvarlig);
                comboBoxAnsvarlig.SelectedItem = selectedAnsvarlig;

                comboBoxStatus.DataSource = TicketData.alleTicketStatus;
                comboBoxStatus.SelectedItem = selectedTicket.Status;

                txtBoxNavn.Text = selectedTicket.Navn;
            }
            else
            {

                txtBoxNavn.Text = "";
                comboBoxKunde.SelectedItem = null;
                comboBoxAnsvarlig.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }

            if (listBoxTickets.SelectedItem != null)
            {

                selectedTicket = (Ticket)listBoxTickets.SelectedItem;

                listBoxAktiviteter.DataSource = null;
                listBoxAktiviteter.Items.Clear();

                foreach (Aktiviteter aktivitet in selectedTicket.Aktiviteter)
                {
                    // Add each Aktiviteter item to the listBoxAktiviteter
                    listBoxAktiviteter.DataSource = null;

                    listBoxAktiviteter.Items.Add(aktivitet);
                }
            }
            else
            {
                // If no item is selected in listBoxTickets, clear listBoxAktiviteter
                listBoxAktiviteter.DataSource = null;
                listBoxAktiviteter.Items.Clear();
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilføjTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbenTilføjTickets(this);
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedItem != null)
            {
                Ticket selectedTicket = (Ticket)listBoxTickets.SelectedItem;


                // Alt skal være udfyldt
                if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxKunde.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxAnsvarlig.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxStatus.Text))
                {
                    MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                string navn = txtBoxNavn.Text;
                string kunde = comboBoxKunde.Text;
                string ansvarlig = comboBoxAnsvarlig.Text;
                string status = comboBoxStatus.Text;

                selectedTicket.Navn = navn;
                selectedTicket.Ansvarlig = ansvarlig;
                selectedTicket.Kunde = kunde;
                selectedTicket.Status = status;

                listBoxTickets.DataSource = null;
                listBoxTickets.DataSource = TicketData.alleTicketsList;
                listBoxTickets.DisplayMember = "Info";

                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingen ticket er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSletTickets_Click(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedItem != null)
            {

                Ticket selectedTickets = (Ticket)listBoxTickets.SelectedItem;

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

        private void btnTilføjAktivitet_Click(object sender, EventArgs e)
        {
            if (selectedTicket != null)
            {
                menu.ÅbenTilføjAktiviteter(this, selectedTicket);
            }
            else
            {
                MessageBox.Show("Vælg venligst en ticket for at tilføje en aktivitet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSletAktivitet_Click(object sender, EventArgs e)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {
                // Get the selected Aktiviteter
                Aktiviteter selectedAktivitet = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                // Get the corresponding Ticket of the selected Aktiviteter
                Ticket tilhørendeTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Id == selectedAktivitet.TicketNummer);

                if (tilhørendeTicket != null)
                {
                    // Remove the selected Aktiviteter from the Ticket's Aktiviteter list
                    tilhørendeTicket.Aktiviteter.Remove(selectedAktivitet);

                    // Update the listBoxAktiviteter
                    listBoxAktiviteter.DataSource = null;
                    listBoxAktiviteter.DataSource = tilhørendeTicket.Aktiviteter;
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

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            DisplayTicketsInListBoxClosed();
        }

        private void btnSortÅbne_Click(object sender, EventArgs e)
        {
            DisplayTicketsInListBoxOpen();
        }

        private void DisplayTicketsInListBoxOpen()
        {
            // Clear the ListBox
            listBoxTickets.DataSource = null;
            listBoxTickets.Items.Clear();

            // Add each open activity to the ListBox
            foreach (Ticket ticket in TicketData.alleTicketsList)
            {
                if (ticket.Status == "Åben")
                {
                    listBoxTickets.Items.Add(ticket);
                }
            }
        }

        private void DisplayTicketsInListBoxClosed()
        {

            // Clear the ListBox
            listBoxTickets.DataSource = null;
            listBoxTickets.Items.Clear();

            // Add each open activity to the ListBox
            foreach (Ticket ticket in TicketData.alleTicketsList)
            {
                if (ticket.Status == "Lukket")
                {
                    listBoxTickets.Items.Add(ticket);
                }
            }

        }
    }
}
