using Eksamen.Classes;
using Eksamen.Datah�ndtering;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    public partial class FormTickets : Form
    {
        CSVHandler csvHandler = new CSVHandler();
        private Ticket selectedTicket;
        Ticket ticketInstance = new Ticket(); 

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

   

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnKunder(this);
        }
        private void btnBrugere_Click(object sender, EventArgs e)
        {
            Menu.Instance.�benBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
        }

        private void btnTilf�jTickets_Click(object sender, EventArgs e)
        {
            Menu.Instance.�benTilf�jTickets(this);
        }



        private void ListBoxTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedItem != null)
            {
                selectedTicket = (Ticket)listBoxTickets.SelectedItem;


                comboBoxKunde.DataSource = Personer.KundeData.alleKunderList;
                comboBoxKunde.DisplayMember = "Navn";
                comboBoxKunde.ValueMember = "Navn";
                Kunde selectedKunde = Personer.KundeData.alleKunderList.FirstOrDefault(k => k.Navn == selectedTicket.Kunde);
                comboBoxKunde.SelectedItem = selectedKunde;

                comboBoxAnsvarlig.DataSource = Personer.BrugerData.alleBrugereList;
                comboBoxAnsvarlig.DisplayMember = "Navn";
                comboBoxAnsvarlig.ValueMember = "Navn";
                Bruger selectedAnsvarlig = Personer.BrugerData.alleBrugereList.FirstOrDefault(b => b.Navn == selectedTicket.Ansvarlig);
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
            if (selectedTicket != null)
            {
                selectedTicket.UpdateTicketInfo(comboBoxKunde, comboBoxAnsvarlig, comboBoxStatus, txtBoxNavn, listBoxTickets);
                csvHandler.UpdateAllCSVFiles();
            }
            else
            {
                MessageBox.Show("Ingen ticket valgt. V�lg venligst en ticket.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void btnSletTickets_Click(object sender, EventArgs e)
        {
            if (selectedTicket != null)
            {
                selectedTicket.DeleteSelectedTicket(listBoxTickets, txtBoxNavn, comboBoxAnsvarlig, comboBoxKunde, comboBoxStatus, listBoxAktiviteter);
                csvHandler.UpdateAllCSVFiles();

            }
            else
            {
                MessageBox.Show("Ingen ticket valgt. V�lg venligst en ticket.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTilf�jAktivitet_Click(object sender, EventArgs e)
        {
            if (selectedTicket != null)
            {
                selectedTicket.AddActivityToSelectedTicket(this, selectedTicket);
                csvHandler.UpdateAllCSVFiles();
            }
            else
            {
                MessageBox.Show("Ingen aktivitet valgt. V�lg venligst en aktivitet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSletAktivitet_Click(object sender, EventArgs e)
        {
            if (selectedTicket != null)
            {
                selectedTicket.DeleteSelectedActivity(listBoxAktiviteter);
                csvHandler.UpdateAllCSVFiles();
            }
            else
            {
                MessageBox.Show("Ingen aktivitet valgt. V�lg venligst en aktivitet.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSort�bne_Click(object sender, EventArgs e)
        {
            ticketInstance.SortAndDisplayTicketsInListBox(listBoxTickets, "�ben");
        }

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            ticketInstance.SortAndDisplayTicketsInListBox(listBoxTickets, "Lukket");
        }

        private void btnFakturer_Click(object sender, EventArgs e)
        {
            if (selectedTicket != null)
            {
                selectedTicket.FakturerTicket(listBoxTickets, selectedTicket.Kunde);
                csvHandler.UpdateAllCSVFiles();
            }
            else
            {
                MessageBox.Show("Ingen ticket valgt. V�lg venligst en ticket.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
