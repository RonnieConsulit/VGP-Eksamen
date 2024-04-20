using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eksamen
{
    public partial class FormTilføjTickets : Form
    {
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

            comboBoxStatus.Items.AddRange(new string[] { "", "Åben", "Lukket" });
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);

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

                menu.ÅbnTickets(this);
            }
        }
    }


}
