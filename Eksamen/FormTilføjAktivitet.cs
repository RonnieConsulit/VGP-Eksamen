using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eksamen
{
    public partial class FormTilf�jAktivitet : Form
    {
        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private Menu menu = new Menu();
        private Ticket selectedTicket;

        public FormTilf�jAktivitet(Ticket ticket)
        {
            InitializeComponent();
            selectedTicket = ticket;
        }

        private void formTilf�jAktivitet(object sender, EventArgs e)
        {

        }

        private void formTilf�jAktivitet_Load(object sender, EventArgs e)
        {
            textBoxKunde.Text = selectedTicket.Kunde;
            txtBoxTicketId.Text = selectedTicket.Id.ToString();

            var ansvarligNames = BrugerData.alleBrugereList.Select(bruger => bruger.Navn).ToList();
            ansvarligNames.Insert(0, "");
            comboBoxAnsvarlig.DataSource = ansvarligNames;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            menu.�bnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            menu.�bnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            menu.�bnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.�bnKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.�benBrugere(this);
        }

        private void btnTilbageTilTicket_Click(object sender, EventArgs e)
        {
            menu.�bnTickets(this);
        }

        private void btnTilf�jTAktivitet_Click(object sender, EventArgs e)
        {
            // Alt skal v�re udfyldt
            if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAnsvarlig.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAnsvarlig.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string aktivitetNavn = txtBoxNavn.Text;
            string navn = txtBoxNavn.Text;
            string ansvarlig = comboBoxAnsvarlig.SelectedItem.ToString();
            string beskrivelse = txtBoxBeskrivelse.Text;
            

            // Create a new Aktiviteter object with a new ID generated
            Aktiviteter newAktivitet = new Aktiviteter(selectedTicket, selectedTicket.Id, navn, beskrivelse);

            // Find the ticket in alleTicketsList with matching TicketNummer
            Ticket matchingTicket = TicketData.alleTicketsList.FirstOrDefault(t => t.Id == selectedTicket.Id);

            if (matchingTicket != null)
            {
                // Add the new Aktiviteter object to the matching ticket's Aktiviteter list
                matchingTicket.Aktiviteter.Add(newAktivitet);

                // Reset form controls
                txtBoxNavn.Text = "";
                comboBoxAnsvarlig.SelectedIndex = -1;

                MessageBox.Show("Aktivitet tilf�jet til ticket.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kunne ikke finde matchende ticket.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // tilbage til formTickets
            menu.�bnTickets(this);


        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilTickets_Click(object sender, EventArgs e)
        {
            menu.�bnTickets(this);
        }
    }
}
