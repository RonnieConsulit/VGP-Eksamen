namespace Eksamen
{
    public partial class FormKunder : Form
    {

        public FormKunder()
        {
            InitializeComponent();
            listBoxKunder.SelectedIndexChanged += ListBoxKunder_SelectedIndexChanged;

        }

        private void formKunder_Load(object sender, EventArgs e)
        {
            if (KunderData.alleKunderList == null || KunderData.alleKunderList.Count == 0)
            {
            }

            listBoxKunder.DataSource = KunderData.alleKunderList;
            listBoxKunder.DisplayMember = "Info";


            // Clear
            listBoxKunder.ClearSelected();
        }

        private Menu menu = new Menu();

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

        private void btnTilf�jKunder_Click(object sender, EventArgs e)
        {
            menu.�benTilf�jKunder(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

        private void ListBoxKunder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKunder.SelectedItem != null)
            {
                Kunde selectedKunder = (Kunde)listBoxKunder.SelectedItem;

                txtBoxNavn.Text = selectedKunder.Navn;
                txtBoxAdresse.Text = selectedKunder.Adresse;
                txtBoxEmail.Text = selectedKunder.Email;
                txtBoxKontakt.Text = selectedKunder.Kontakt;
                txtBoxBeskrivelse.Text = selectedKunder.Beskrivelse;
            }
            else
            {
                txtBoxNavn.Text = "";
                txtBoxAdresse.Text = "";
                txtBoxEmail.Text = "";
                txtBoxKontakt.Text = "";
                txtBoxBeskrivelse.Text = "";
            }
        }

        private void btnSletKunde_Click(object sender, EventArgs e)
        {
            PersonHandler.DeleteKunde(listBoxKunder, txtBoxNavn, txtBoxAdresse, txtBoxEmail, txtBoxKontakt, txtBoxBeskrivelse);
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            PersonHandler.UpdateKunde(listBoxKunder, txtBoxNavn, txtBoxAdresse, txtBoxEmail, txtBoxKontakt, txtBoxBeskrivelse);
        }

    }
}
