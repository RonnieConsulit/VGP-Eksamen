using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eksamen
{
    public partial class FormAktiviteter : Form
    {
        private List<Aktiviteter> alleAktiviteter;
        Menu menu = new Menu();

        public FormAktiviteter()
        {
            InitializeComponent();
            listBoxAktiviteter.SelectedIndexChanged += ListBoxAktiviteter_SelectedIndexChanged;
            alleAktiviteter = new List<Aktiviteter>();
        }

        private void formAktiviteter_Load(object sender, EventArgs e)
        {
            alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList);
            Aktiviteter.DisplayAktiviteterInListBox(listBoxAktiviteter, alleAktiviteter);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            menu.≈bnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            menu.≈bnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            menu.≈bnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.≈bnKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.≈benBrugere(this);
        }

        private void ListBoxAktiviteter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {
                Aktiviteter selectedAktiviteter = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                txtBoxNavn.Text = selectedAktiviteter.Navn;

                comboBoxAnsvarlig.DataSource = BrugerData.alleBrugereList;
                comboBoxAnsvarlig.DisplayMember = "Navn";
                comboBoxAnsvarlig.ValueMember = "Navn";
                Brugere selectedBruger = BrugerData.alleBrugereList.FirstOrDefault(k => k.Navn == selectedAktiviteter.Ansvarlig);
                comboBoxAnsvarlig.SelectedItem = selectedBruger;

                comboBoxTickets.DataSource = TicketData.alleTicketsList
                    .Where(ticket => ticket.Kunde == selectedAktiviteter.Kunde)
                    .ToList();
                comboBoxTickets.DisplayMember = "Navn";
                comboBoxTickets.ValueMember = "Navn";
                Ticket selectedTicket = TicketData.alleTicketsList.FirstOrDefault(b => b.Id == selectedAktiviteter.TicketNummer);
                comboBoxTickets.SelectedItem = selectedTicket;

                comboBoxStatus.DataSource = TicketData.alleTicketStatus;
                comboBoxStatus.SelectedItem = selectedAktiviteter.Status;

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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Aktiviteter.Exit(this);
        }

        private void btnSort≈bne_Click(object sender, EventArgs e)
        {
            Aktiviteter.DisplayAktiviteterInListBoxOpen(listBoxAktiviteter, alleAktiviteter);
        }

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            Aktiviteter.DisplayAktiviteterInListBoxClosed(listBoxAktiviteter, alleAktiviteter);
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            Aktiviteter.Gem(listBoxAktiviteter, txtBoxNavn, comboBoxAnsvarlig, comboBoxStatus, comboBoxKunder, txtBoxBeskrivelse, comboBoxTickets);
        }
    }
}
