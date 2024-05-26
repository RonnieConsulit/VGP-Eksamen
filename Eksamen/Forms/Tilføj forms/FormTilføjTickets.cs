using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Eksamen.Classes;
using Eksamen.Datahåndtering;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    public partial class FormTilføjTickets : Form
    {

        CSVHandler csvHandler = new CSVHandler();

        public FormTilføjTickets()
        {
            InitializeComponent();
        }

        private void formTilføjTicket_Load(object sender, EventArgs e)
        {
            // Load Kunde names into comboBoxKunde
            var kundeNames = Personer.KundeData.alleKunderList.Select(kunde => kunde.Navn).ToList();
            kundeNames.Insert(0, ""); // Add an empty option
            comboBoxKunde.DataSource = kundeNames;

            // Load Bruger names into comboBoxAnsvarlig
            var ansvarligNames = Personer.BrugerData.alleBrugereList.Select(bruger => bruger.Navn).ToList();
            ansvarligNames.Insert(0, ""); // Add an empty option
            comboBoxAnsvarlig.DataSource = ansvarligNames;

            // Set up comboBoxStatus
            comboBoxStatus.Items.AddRange(new string[] { "", "Åben", "Lukket" });
            comboBoxStatus.SelectedIndex = 0;
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


        private void btnTilføjTicket_Click(object sender, EventArgs e)
        {
            string navn = txtBoxNavn.Text;
            string kunde = comboBoxKunde.SelectedItem.ToString();
            string ansvarlig = comboBoxAnsvarlig.SelectedItem.ToString();
            string status = comboBoxStatus.SelectedItem.ToString();

            if (Ticket.CreateNewTicket(navn, kunde, ansvarlig, status))
            {
                txtBoxNavn.Text = "";
                comboBoxKunde.SelectedIndex = -1;
                comboBoxAnsvarlig.SelectedIndex = -1;
                comboBoxStatus.SelectedIndex = -1;

                Menu.Instance.ÅbnTickets(this);
                csvHandler.UpdateAllCSVFiles();
            }
        }
    }


}
