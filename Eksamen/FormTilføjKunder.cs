using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormTilføjKunder : Form
    {


        private FormKunder formKunder;
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
            menu.ÅbnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            menu.ÅbnAktiviteter(this);


        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbenTilføjTickets(this);
        }


        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.ÅbenTilføjKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.ÅbenBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilKunde_Click(object sender, EventArgs e)
        {
            menu.ÅbnKunder(this);
        }


        private void btnTilføjKunde_Click(object sender, EventArgs e)
        {
            // Call the CreateNewCustomer method
            if (Kunde.CreateNewCustomer(
                txtBoxNavn.Text,
                txtBoxAdresse.Text,
                txtBoxEmail.Text,
                txtBoxKontakt.Text,
                txtBoxBeskrivelse.Text))
            {
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
        }
    }
}
