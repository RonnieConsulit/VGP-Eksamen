using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eksamen
{
    public partial class FormTilføjAktivitet : Form
    {
        private Menu menu = new Menu();
        private Ticket selectedTicket;

        public FormTilføjAktivitet(Ticket ticket)
        {
            InitializeComponent();
            selectedTicket = ticket;
        }

        private void formTilføjAktivitet(object sender, EventArgs e)
        {

        }

        private void formTilføjAktivitet_Load(object sender, EventArgs e)
        {
            textBoxKunde.Text = selectedTicket.Kunde;
            txtBoxTicketId.Text = selectedTicket.Id.ToString();

            var ansvarligNames = BrugerData.alleBrugereList.Select(bruger => bruger.Navn).ToList();
            ansvarligNames.Insert(0, "");
            comboBoxAnsvarlig.DataSource = ansvarligNames;
        }

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

        private void btnTilbageTilTicket_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);
        }



        private void btnTilføjTAktivitet_Click(object sender, EventArgs e)
        {
            // Alt skal være udfyldt
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

            // Call create aktivitet
            if (Aktiviteter.CreateNewActivity(selectedTicket, selectedTicket.Id, navn, beskrivelse))
            {
                // Reset form controls
                txtBoxNavn.Text = "";
                comboBoxAnsvarlig.SelectedIndex = -1;

                MessageBox.Show("Aktivitet tilføjet til ticket.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kunne ikke tilføje aktivitet til ticket.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // tilbage til formTickets
            menu.ÅbnTickets(this);
        }

    }
}
