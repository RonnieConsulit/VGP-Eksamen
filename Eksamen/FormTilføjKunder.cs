using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormTilføjKunder : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private Menu menu = new Menu();


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
            if (formDashboard == null || formDashboard.IsDisposed)
            {
                formDashboard = new FormDashboard();
                formDashboard.FormClosed += (s, args) => this.Show();
                formDashboard.Show();
                this.Hide();
            }
            else
            {
                formDashboard.WindowState = FormWindowState.Normal;
                formDashboard.BringToFront();
            }
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {

            if (formAktiviteter == null || formAktiviteter.IsDisposed)
            {
                formAktiviteter = new FormAktiviteter();
                formAktiviteter.FormClosed += (s, args) => this.Show();
                formAktiviteter.Show();
                this.Hide();
            }
            else
            {
                formAktiviteter.WindowState = FormWindowState.Normal;
                formAktiviteter.BringToFront();
            }


        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
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


        private void btnKunder_Click(object sender, EventArgs e)
        {
            if (formKunder == null || formKunder.IsDisposed)
            {
                formKunder = new FormKunder();
                formKunder.FormClosed += (s, args) => this.Show();
                formKunder.Show();
                this.Hide();
            }
            else
            {
                formKunder.WindowState = FormWindowState.Normal;
                formKunder.BringToFront();
            }
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            if (formBrugere == null || formBrugere.IsDisposed)
            {
                formBrugere = new FormBrugere();
                formBrugere.FormClosed += (s, args) => this.Show();
                formBrugere.Show();
                this.Hide();
            }
            else
            {
                formBrugere.WindowState = FormWindowState.Normal;
                formBrugere.BringToFront();
            }
        }



        private void btnTilføjKunde_Click(object sender, EventArgs e)
        {
            // Alt skal være udfyldt
            if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                string.IsNullOrWhiteSpace(txtBoxAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKontakt.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBeskrivelse.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Findes firma allerede
            string firmaNavn = txtBoxNavn.Text;
            if (uniktFirma(firmaNavn))
            {
                Kunde newKunde = new Kunde(

                    txtBoxNavn.Text,
                    txtBoxAdresse.Text,
                    txtBoxEmail.Text,
                    txtBoxKontakt.Text,
                    txtBoxBeskrivelse.Text
                );

                KunderData.alleKunderList.Add(newKunde);

                // tilbage til formKunder
                if (formKunder == null || formKunder.IsDisposed)
                {
                    formKunder = new FormKunder();
                    formKunder.FormClosed += (s, args) => this.Show();
                    formKunder.Show();
                    this.Hide();
                }
                else
                {
                    formKunder.WindowState = FormWindowState.Normal;
                    formKunder.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Virksomhedsnavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool uniktFirma(string firmaNavn)
        {
            foreach (Kunde kunde in KunderData.alleKunderList)
            {
                if (kunde.Navn.Equals(firmaNavn))
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

        private void btnTilbageTilKunde_Click(object sender, EventArgs e)
        {
            menu.ÅbnKunder(this);
        }
    }
}
