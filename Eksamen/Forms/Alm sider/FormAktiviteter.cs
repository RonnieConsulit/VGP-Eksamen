using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Eksamen.Classes;
using Eksamen.Datahåndtering;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    public partial class FormAktiviteter : Form
    {
        private List<Aktiviteter> alleAktiviteter;
        private Aktiviteter aktInstance = new Aktiviteter();
        CSVHandler csvHandler = new CSVHandler();

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

        private void ListBoxAktiviteter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAktiviteter.SelectedItem != null)
            {
                Aktiviteter selectedAktiviteter = (Aktiviteter)listBoxAktiviteter.SelectedItem;

                txtBoxNavn.Text = selectedAktiviteter.Navn;

                comboBoxAnsvarlig.DataSource = Personer.BrugerData.alleBrugereList;
                comboBoxAnsvarlig.DisplayMember = "Navn";
                comboBoxAnsvarlig.ValueMember = "Navn";
                Bruger selectedBruger = Personer.BrugerData.alleBrugereList.FirstOrDefault(k => k.Navn == selectedAktiviteter.Ansvarlig);
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

                comboBoxKunder.DataSource = Personer.KundeData.alleKunderList;
                comboBoxKunder.DisplayMember = "Navn";
                comboBoxKunder.ValueMember = "Navn";
                Kunde selectedKunde = Personer.KundeData.alleKunderList.FirstOrDefault(b => b.Navn == selectedAktiviteter.Kunde);
                comboBoxKunder.SelectedItem = selectedKunde;

                txtBoxBeskrivelse.Text = selectedAktiviteter.Beskrivelse;
            }
            else
            {
                txtBoxNavn.Text = "";
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbenBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Aktiviteter.Exit(this);
        }

        private void btnSortÅbne_Click(object sender, EventArgs e)
        {
            Aktiviteter.DisplayAktiviteterInListBox(listBoxAktiviteter, alleAktiviteter, "Åben");
            
        }

        private void btnSortLukket_Click(object sender, EventArgs e)
        {
            Aktiviteter.DisplayAktiviteterInListBox(listBoxAktiviteter, alleAktiviteter, "Lukket");
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            Aktiviteter.Gem(listBoxAktiviteter, txtBoxNavn, comboBoxAnsvarlig, comboBoxStatus, comboBoxKunder, txtBoxBeskrivelse, comboBoxTickets);
            csvHandler.UpdateAllCSVFiles();
        }
    }
}
