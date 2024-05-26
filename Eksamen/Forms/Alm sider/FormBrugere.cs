using System.Windows.Forms;
using Eksamen.Classes;
using Eksamen.Datahåndtering;
using Menu = Eksamen.Classes.Menu;

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
        CSVHandler csvHandler = new CSVHandler();

        public FormBrugere()
        {
            InitializeComponent();
            listBoxBrugere.SelectedIndexChanged += ListBoxBrugere_SelectedIndexChanged;

        }

        private void formBrugere_Load(object sender, EventArgs e)
        {

            listBoxBrugere.DataSource = Personer.BrugerData.alleBrugereList;
            listBoxBrugere.DisplayMember = "Navn";

            // Clear the selected item when the form loads
            listBoxBrugere.ClearSelected();

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

        private void ListBoxBrugere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBrugere.SelectedItem != null)
            {
                Bruger selectedBrugere = (Bruger)listBoxBrugere.SelectedItem;


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

                Bruger selectBrugere = (Bruger)listBoxBrugere.SelectedItem;

                int index = listBoxBrugere.SelectedIndex;


                if (index >= 0 && index < Personer.BrugerData.alleBrugereList.Count)
                {
                    // Slet
                    Personer.BrugerData.alleBrugereList.RemoveAt(index);

                    // Opdater liste og clear tekst
                    listBoxBrugere.DataSource = null;
                    listBoxBrugere.DataSource = Personer.BrugerData.alleBrugereList;
                    listBoxBrugere.DisplayMember = "Info";
                    txtBoxNavn.Text = "";
                    txtBoxAdresse.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxTelefon.Text = "";
                    txtBoxBeskrivelse.Text = "";

                    MessageBox.Show("Brugern er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    csvHandler.UpdateAllCSVFiles();
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


                Bruger selectedBruger = (Bruger)listBoxBrugere.SelectedItem;

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
                listBoxBrugere.DataSource = Personer.BrugerData.alleBrugereList;
                listBoxBrugere.DisplayMember = "Info";


                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                csvHandler.UpdateAllCSVFiles();

            }
            else
            {
                MessageBox.Show("Ingen Bruger er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTilføjBrugere_Click(object sender, EventArgs e)
        {

            Menu.Instance.ÅbenTilføjBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
        }
    }
}
