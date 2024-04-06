using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eksamen
{
    public partial class FormTilføjTickets : Form
    {
        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private Menu menu = new Menu();


        public FormTilføjTickets()
        {
            InitializeComponent();
        }

        private void formTilføjTicket_Load(object sender, EventArgs e)
        {

            var kundeNames = KunderData.alleKunderList.Select(kunde => kunde.Navn).ToList();
            kundeNames.Insert(0, "");
            comboBoxKunde.DataSource = kundeNames;


            var ansvarligNames = BrugerData.alleBrugereList.Select(bruger => bruger.Navn).ToList();
            ansvarligNames.Insert(0, "");
            comboBoxAnsvarlig.DataSource = ansvarligNames;

            comboBoxStatus.Items.AddRange(new string[] { "", "Open", "Igangværende", "Lukket" });


            comboBoxStatus.SelectedIndex = 0;

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

        private void btnTilføjTicket_Click(object sender, EventArgs e)
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

            // Findes ticketnavn allerede
            string ticketNavn = txtBoxNavn.Text;
            if (uniktTicket(ticketNavn))
            {
                // Retrieve values from the form controls
                string navn = txtBoxNavn.Text;
                string kunde = comboBoxKunde.SelectedItem.ToString();
                string ansvarlig = comboBoxAnsvarlig.SelectedItem.ToString();
                string status = comboBoxStatus.SelectedItem.ToString();

                // Create a new Ticket object
                Ticket newTicket = new Ticket(navn, kunde, ansvarlig, status);

                // Add the new Ticket object to the list of tickets
                TicketData.alleTicketsList.Add(newTicket);

                // Reset form controls
                txtBoxNavn.Text = "";
                comboBoxKunde.SelectedIndex = -1;
                comboBoxAnsvarlig.SelectedIndex = -1;
                comboBoxStatus.SelectedIndex = -1;

                // tilbage til formTickets
                if (formTickets == null || formTickets.IsDisposed)
                {
                    formTickets = new FormTickets();
                    formTickets.FormClosed += (s, args) => this.Show();
                    formTickets.Show();
                    this.Hide();
                }
                else
                {
                    formTickets.WindowState = FormWindowState.Normal;
                    formTickets.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Ticketnavn eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private bool uniktTicket(string ticketNavn)
        {
            foreach (Ticket ticket in TicketData.alleTicketsList)
            {
                if (ticket.Navn.Equals(ticketNavn))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);
            
        }
    }


}
