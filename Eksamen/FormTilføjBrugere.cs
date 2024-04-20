using System.Windows.Forms;

namespace Eksamen
{
    public partial class FormTilf�jBrugere : Form
    {
        private Menu menu = new Menu();


        private bool isIdInitialized = false;

        public FormTilf�jBrugere()
        {
            InitializeComponent();

        }

        private void formTilf�jBrugere_Load(object sender, EventArgs e)
        {

        }

        private void btnTilbageTilBrugere_Click(object sender, EventArgs e)
        {
            menu.�benBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }


        private void btnTilf�jBrugere_Click(object sender, EventArgs e)
        {
            // Alt skal v�re udfyldt
            if (string.IsNullOrWhiteSpace(txtBoxNavn.Text) ||
                string.IsNullOrWhiteSpace(txtBoxAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtBoxBeskrivelse.Text))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Findes bruger allerede
            string brugerNavn = txtBoxNavn.Text;

            if (unikBrugere(brugerNavn))
            {
                int telefonNumber;
                if (int.TryParse(txtBoxTelefon.Text, out telefonNumber))
                {
                    Brugere newBruger = new Brugere(
                        txtBoxNavn.Text,
                        txtBoxAdresse.Text,
                        txtBoxEmail.Text,
                        telefonNumber,
                        txtBoxBeskrivelse.Text
                    );

                    BrugerData.alleBrugereList.Add(newBruger);

                    // tilbage til brugere
                    menu.�benBrugere(this);
                }
                else
                {
                    MessageBox.Show("Ugyldigt telefonnummerformat. Indtast venligst et gyldigt nummer.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Brugernavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool unikBrugere(string brugerNavn)
        {
            foreach (Brugere bruger in BrugerData.alleBrugereList)
            {
                if (bruger.Navn.Equals(brugerNavn))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
