namespace Eksamen
{
    public partial class FormTickets : Form
    {


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

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilføjTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbenTilføjTickets(this);
        }



        private void ListBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedItem != null)
            {
                selectedTicket = (Ticket)listBoxTickets.SelectedItem;


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

                listBoxAktiviteter.DataSource = null;
                listBoxAktiviteter.Items.Clear();

                foreach (Aktiviteter aktivitet in selectedTicket.AktivitetList)
                {
                    listBoxAktiviteter.Items.Add(aktivitet);
                }
            }
            else
            {
                txtBoxNavn.Text = "";
                comboBoxKunde.SelectedItem = null;
                comboBoxAnsvarlig.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;

                listBoxAktiviteter.DataSource = null;
                listBoxAktiviteter.Items.Clear();
            }
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            selectedTicket.UpdateTicketInfo(comboBoxKunde, comboBoxAnsvarlig, comboBoxStatus, txtBoxNavn, listBoxTickets);

        }

        private void btnSletTickets_Click(object sender, EventArgs e)
        {
            selectedTicket.DeleteSelectedTicket(listBoxTickets, txtBoxNavn, comboBoxAnsvarlig, comboBoxKunde, comboBoxStatus, listBoxAktiviteter);
        }

        private void btnTilføjAktivitet_Click(object sender, EventArgs e)
        {
            selectedTicket.AddActivityToSelectedTicket(this, selectedTicket);
        }

        private void btnSletAktivitet_Click(object sender, EventArgs e)
        {
            selectedTicket.DeleteSelectedActivity(listBoxAktiviteter);
        }

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            selectedTicket.SortAndDisplayTicketsInListBoxClosed(listBoxTickets);
        }

        private void btnSortÅbne_Click(object sender, EventArgs e)
        {
            selectedTicket.SortAndDisplayTicketsInListBoxOpen(listBoxTickets);
        }

        private void btnFakturer_Click(object sender, EventArgs e)
        {
            selectedTicket.FakturerTicket(listBoxTickets, selectedTicket.Kunde);
        }
    }
}
