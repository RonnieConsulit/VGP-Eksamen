using Eksamen.Classes;
using Eksamen.Datahåndtering;
using System.Windows.Forms;
using static Eksamen.Classes.Personer;

namespace Eksamen
{
    public partial class FormTilføjKunder : Form
    {


        private FormKunder formKunder;
        CSVHandler csvHandler = new CSVHandler();

        private bool isIdInitialized = false;

        public FormTilføjKunder()
        {
            InitializeComponent();
        }

        private void formTilføjKunder_Load(object sender, EventArgs e)
        {


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
            Menu.Instance.ÅbenTilføjTickets(this);
        }


        private void btnKunder_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbenTilføjKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbenBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
        }

        private void btnTilbageTilKunde_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbnKunder(this);
        }


        private void btnTilføjKunde_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                string.IsNullOrWhiteSpace(txtBoxAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKontakt.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBeskrivelse.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the customer name already exists
            string kundeNavn = txtBoxNavn.Text;

            if (unikKunder(kundeNavn))
            {
                Kunde newKunde = new Kunde(
                    txtBoxNavn.Text,
                    txtBoxAdresse.Text,
                    txtBoxEmail.Text,
                    txtBoxKontakt.Text,
                    txtBoxBeskrivelse.Text
                );

                Kunde.KundeData.alleKunderList.Add(newKunde);
                csvHandler.UpdateAllCSVFiles();

                // Navigate back to the customers form
                Menu.Instance.ÅbnKunder(this);
            }
            else
            {
                MessageBox.Show("Kundenavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to check if the customer name already exists
        private bool unikKunder(string kundeNavn)
        {
            return !Kunde.KundeData.alleKunderList.Exists(kunde => kunde.Navn.Equals(kundeNavn));
        }





    }
}


