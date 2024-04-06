using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormKunder : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private FormTilføjKunder formTilføjKunder;

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


            // Clear the selected item when the form loads
            listBoxKunder.ClearSelected();
        }

        private Menu menu = new Menu();

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
            if (listBoxKunder.SelectedItem != null)
            {

                Kunde selectedKunder = (Kunde)listBoxKunder.SelectedItem;

                int index = listBoxKunder.SelectedIndex;


                if (index >= 0 && index < KunderData.alleKunderList.Count)
                {
                    // Slet
                    KunderData.alleKunderList.RemoveAt(index);


                    // Opdater liste og clear tekst
                    listBoxKunder.DataSource = null;
                    listBoxKunder.DataSource = KunderData.alleKunderList;
                    listBoxKunder.DisplayMember = "Info";
                    txtBoxNavn.Text = "";
                    txtBoxAdresse.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxKontakt.Text = "";
                    txtBoxBeskrivelse.Text = "";

                    MessageBox.Show("Kunden er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kunden kunne ikke findes i listen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingen kunde er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            if (listBoxKunder.SelectedItem != null)
            {


                Kunde selectedKunder = (Kunde)listBoxKunder.SelectedItem;

                // Opdater
                selectedKunder.Navn = txtBoxNavn.Text;
                selectedKunder.Adresse = txtBoxAdresse.Text;
                selectedKunder.Email = txtBoxEmail.Text;
                selectedKunder.Kontakt = txtBoxKontakt.Text;
                selectedKunder.Beskrivelse = txtBoxBeskrivelse.Text;
                listBoxKunder.DataSource = null;
                listBoxKunder.DataSource = KunderData.alleKunderList;
                listBoxKunder.DisplayMember = "Info";


                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingen kunde er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTilføjKunder_Click(object sender, EventArgs e)
        {
            menu.ÅbenTilføjKunder(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }
    }
}
