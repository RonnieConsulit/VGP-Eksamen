using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Eksamen
{
    public partial class FormAktiviteter : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private FormTilføjBrugere formTilføjBrugere;
        private List<Aktiviteter> alleAktiviteter;

        private Aktiviteter selectedAktiviteter;
        public FormAktiviteter()
        {
            InitializeComponent();
            listBoxAktiviteter.SelectedIndexChanged += ListBoxAktiviteter_SelectedIndexChanged;
            alleAktiviteter = new List<Aktiviteter>();

        }

        private void formAktiviteter_Load(object sender, EventArgs e)
        {
            alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList);

            DisplayAktiviteterInListBox();
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

        private void ListBoxAktiviteter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {
                Aktiviteter selectedAktiviteter = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                txtBoxNavn.Text = selectedAktiviteter.Navn;

                // Populate comboBoxAnsvarlig
                comboBoxAnsvarlig.DataSource = BrugerData.alleBrugereList;
                comboBoxAnsvarlig.DisplayMember = "Navn";
                comboBoxAnsvarlig.ValueMember = "Navn";
                Brugere selectedBruger = BrugerData.alleBrugereList.FirstOrDefault(k => k.Navn == selectedAktiviteter.Ansvarlig);
                comboBoxAnsvarlig.SelectedItem = selectedBruger;

                // Populate comboBoxTickets
                comboBoxTickets.DataSource = TicketData.alleTicketsList
                    .Where(ticket => ticket.Kunde == selectedAktiviteter.Kunde)
                    .ToList();
                comboBoxTickets.DisplayMember = "Navn";
                comboBoxTickets.ValueMember = "Navn"; // Set ValueMember to "TicketNummer"
                Ticket selectedTicket = TicketData.alleTicketsList.FirstOrDefault(b => b.Id == selectedAktiviteter.TicketNummer);
                comboBoxTickets.SelectedItem = selectedTicket;


                // Populate comboBoxStatus
                comboBoxStatus.DataSource = TicketData.alleTicketStatus;
                comboBoxStatus.SelectedItem = selectedAktiviteter.Status;

                // Populate comboBoxKunder
                comboBoxKunder.DataSource = KunderData.alleKunderList;
                comboBoxKunder.DisplayMember = "Navn";
                comboBoxKunder.ValueMember = "Navn";
                Kunde selectedKunde = KunderData.alleKunderList.FirstOrDefault(b => b.Navn == selectedAktiviteter.Kunde);
                comboBoxKunder.SelectedItem = selectedKunde;

                txtBoxBeskrivelse.Text = selectedAktiviteter.Beskrivelse;
            }
            else
            {

                txtBoxNavn.Text = "";
                // comboBoxKunde.SelectedItem = null;
                // comboBoxAnsvarlig.SelectedItem = null;
                // comboBoxStatus.SelectedItem = null;
            }

        }


        private void DisplayAktiviteterInListBox()
        {
            // Clear the ListBox
            listBoxAktiviteter.Items.Clear();

            // Add each activity to the ListBox
            foreach (Aktiviteter aktivitet in alleAktiviteter)
            {
                listBoxAktiviteter.Items.Add(aktivitet);
            }
        }

        private void DisplayAktiviteterInListBoxOpen()
        {
            // Clear the ListBox
            listBoxAktiviteter.Items.Clear();

            // Add each open activity to the ListBox
            foreach (Aktiviteter aktivitet in alleAktiviteter)
            {
                if (aktivitet.Status == "Åben")
                {
                    listBoxAktiviteter.Items.Add(aktivitet);
                }
            }
        }

        private void DisplayAktiviteterInListBoxClosed()
        {
            // Clear the ListBox
            listBoxAktiviteter.Items.Clear();

            // Add each closed activity to the ListBox
            foreach (Aktiviteter aktivitet in alleAktiviteter)
            {
                if (aktivitet.Status == "Lukket")
                {
                    listBoxAktiviteter.Items.Add(aktivitet);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnSortÅbne_Click(object sender, EventArgs e)
        {
            DisplayAktiviteterInListBoxOpen();
        }

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            DisplayAktiviteterInListBoxClosed();
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {
                Aktiviteter selectAktiviteter = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                // Update the properties of selectAktiviteter
                selectAktiviteter.Navn = txtBoxNavn.Text;
                selectAktiviteter.Ansvarlig = comboBoxAnsvarlig.Text;
                selectAktiviteter.Status = comboBoxStatus.Text;
                selectAktiviteter.Kunde = comboBoxKunder.Text;
                selectAktiviteter.Beskrivelse = txtBoxBeskrivelse.Text;

                // Get the selected ticket name from comboBoxTickets
                string selectedTicketName = comboBoxTickets.Text;

                // Find the corresponding new Ticket object from TicketData.alleTicketsList
                Ticket newSelectedTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Navn == selectedTicketName);

                // Check if the newSelectedTicket is different from the original ticket
                if (newSelectedTicket != null)
                {
                    // Find the original Ticket object that the Aktiviteter belonged to
                    Ticket originalTicket = TicketData.alleTicketsList.FirstOrDefault(ticket => ticket.Id == selectAktiviteter.TicketNummer);

                    // Remove the Aktiviteter from the original Ticket
                    if (originalTicket != null)
                    {
                        originalTicket.Aktiviteter.Remove(selectAktiviteter);
                    }

                    // Add the Aktiviteter to the new Ticket
                    newSelectedTicket.Aktiviteter.Add(selectAktiviteter);

                    // Update the TicketNummer of selectAktiviteter to the new Ticket Id
                    selectAktiviteter.TicketNummer = newSelectedTicket.Id;

                    // Update the display in the list boxes
                    DisplayAktiviteterInListBox();

                    MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    // Handle the case when the newSelectedTicket is null
                    MessageBox.Show("Fejl: Kunne ikke finde den valgte ticket.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingen aktivitet er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
