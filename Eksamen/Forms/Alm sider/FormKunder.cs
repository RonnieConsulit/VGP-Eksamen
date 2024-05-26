using Eksamen.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = Eksamen.Classes.Menu;

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
            if (Personer.KundeData.alleKunderList == null || Personer.KundeData.alleKunderList.Count == 0)
            {
            }

            listBoxKunder.DataSource = Personer.KundeData.alleKunderList;
            listBoxKunder.DisplayMember = "Navn";


            // Clear
            listBoxKunder.ClearSelected();
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

        private void btnTilføjKunder_Click(object sender, EventArgs e)
        {
            Menu.Instance.ÅbenTilføjKunder(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
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
            Personer.Delete(listBoxKunder, txtBoxNavn, txtBoxAdresse, txtBoxEmail, txtBoxKontakt, txtBoxBeskrivelse, Personer.KundeData.alleKunderList);
        }


        private void btnGem_Click(object sender, EventArgs e)
        {
            Personer.Update<Kunde>(listBoxKunder, txtBoxNavn, txtBoxAdresse, txtBoxEmail, txtBoxKontakt, txtBoxBeskrivelse);
        }

    }
}
