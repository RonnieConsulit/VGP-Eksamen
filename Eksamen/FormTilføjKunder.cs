using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormTilf�jKunder : Form
    {


        private FormKunder formKunder;
        private Menu menu = new Menu();


        private bool isIdInitialized = false;

        public FormTilf�jKunder()
        {
            InitializeComponent();
        }

        private void formTilf�jKunder_Load(object sender, EventArgs e)
        {


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
            menu.�benTilf�jTickets(this);
        }


        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.�benTilf�jKunder(this);
        }

        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.�benBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void btnTilbageTilKunde_Click(object sender, EventArgs e)
        {
            menu.�bnKunder(this);
        }


        private void btnTilf�jKunde_Click(object sender, EventArgs e)
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
