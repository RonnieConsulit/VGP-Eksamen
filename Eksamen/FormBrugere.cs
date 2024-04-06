using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormBrugere : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private FormTilføjBrugere formTilføjBrugere;

        public FormBrugere()
        {
            InitializeComponent();
            listBoxBrugere.SelectedIndexChanged += ListBoxBrugere_SelectedIndexChanged;

        }

        private void formBrugere_Load(object sender, EventArgs e)
        {

            listBoxBrugere.DataSource = BrugerData.alleBrugereList;
            listBoxBrugere.DisplayMember = "Info";

            // Clear the selected item when the form loads
            listBoxBrugere.ClearSelected();

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

        private void ListBoxBrugere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBrugere.SelectedItem != null)
            {
                Brugere selectedBrugere = (Brugere)listBoxBrugere.SelectedItem;


                txtBoxNavn.Text = selectedBrugere.Navn;

                txtBoxAdresse.Text = selectedBrugere.Adresse;


                txtBoxEmail.Text = selectedBrugere.Email;


                txtBoxTelefon.Text = selectedBrugere.Telefon.ToString();

                txtBoxBeskrivelse.Text = selectedBrugere.Beskrivelse;
            }
            else
            {

                txtBoxNavn.Text = "";
                txtBoxAdresse.Text = "";
                txtBoxEmail.Text = "";
                txtBoxTelefon.Text = "";
                txtBoxBeskrivelse.Text = "";
            }


        }

        private void btnSletKunde_Click(object sender, EventArgs e)
        {
            if (listBoxBrugere.SelectedItem != null)
            {

                Brugere selectBrugere = (Brugere)listBoxBrugere.SelectedItem;

                int index = listBoxBrugere.SelectedIndex;


                if (index >= 0 && index < BrugerData.alleBrugereList.Count)
                {
                    // Slet
                    BrugerData.alleBrugereList.RemoveAt(index);

                    // Opdater liste og clear tekst
                    listBoxBrugere.DataSource = null;
                    listBoxBrugere.DataSource = BrugerData.alleBrugereList;
                    listBoxBrugere.DisplayMember = "Info";
                    txtBoxNavn.Text = "";
                    txtBoxAdresse.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxTelefon.Text = "";
                    txtBoxBeskrivelse.Text = "";

                    MessageBox.Show("Brugern er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Brugern kunne ikke findes i listen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingen bruger er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            if (listBoxBrugere.SelectedItem != null)
            {


                Brugere selectedBruger = (Brugere)listBoxBrugere.SelectedItem;

                // Opdater
                selectedBruger.Navn = txtBoxNavn.Text;
                selectedBruger.Adresse = txtBoxAdresse.Text;
                selectedBruger.Email = txtBoxEmail.Text;
                if (int.TryParse(txtBoxTelefon.Text, out int telefonNumber))
                {
                    selectedBruger.Telefon = telefonNumber;
                }
                selectedBruger.Beskrivelse = txtBoxBeskrivelse.Text;
                listBoxBrugere.DataSource = null;
                listBoxBrugere.DataSource = BrugerData.alleBrugereList;
                listBoxBrugere.DisplayMember = "Info";


                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ingen Bruger er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTilføjBrugere_Click(object sender, EventArgs e)
        {

            if (formTilføjBrugere == null || formTilføjBrugere.IsDisposed)
            {
                formTilføjBrugere = new FormTilføjBrugere();
                formTilføjBrugere.FormClosed += (s, args) => this.Show();
                formTilføjBrugere.Show();
                this.Hide();
            }
            else
            {
                formTilføjBrugere.WindowState = FormWindowState.Normal;
                formTilføjBrugere.BringToFront();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }
    }
}
