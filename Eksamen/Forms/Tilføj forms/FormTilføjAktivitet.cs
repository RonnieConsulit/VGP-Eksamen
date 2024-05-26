using System;
using System.Linq;
using System.Windows.Forms;
using Eksamen.Classes;
using Eksamen.Datahåndtering;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    
    public partial class FormTilføjAktivitet : Form
    {

        private Ticket selectedTicket;
        List<Bruger> brugerList = Personer.BrugerData.alleBrugereList;
        List<Kunde> kundeList = Personer.KundeData.alleKunderList; 
        CSVHandler csvHandler = new CSVHandler();

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

            var ansvarligNames = Personer.BrugerData.alleBrugereList.Select(bruger => bruger.Navn).ToList();
            ansvarligNames.Insert(0, "");
            comboBoxAnsvarlig.DataSource = ansvarligNames;
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

        private void btnTilbageTilTicket_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnTickets(this);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
        }

        private void btnTilbageTilTickets_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnTickets(this);
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
                csvHandler.UpdateAllCSVFiles();
            }
            else
            {
                MessageBox.Show("Kunne ikke tilføje aktivitet til ticket.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // tilbage til formTickets
            Menu.Instance.ÅbnTickets(this);
        }

    }
}
