using System.Windows.Forms;
using Eksamen.Classes;
using Eksamen.Datah�ndtering;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    public partial class FormTilf�jBrugere : Form
    {

        CSVHandler csvHandler = new CSVHandler();
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
            Menu.Instance.�benBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
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
                    Bruger newBruger = new Bruger(
                        txtBoxNavn.Text,
                        txtBoxAdresse.Text,
                        txtBoxEmail.Text,
                        telefonNumber,
                        txtBoxBeskrivelse.Text
                    );

                    Personer.BrugerData.alleBrugereList.Add(newBruger);
                    csvHandler.UpdateAllCSVFiles();
                    // tilbage til brugere
                    Menu.Instance.�benBrugere(this);
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
            foreach (Bruger bruger in Personer.BrugerData.alleBrugereList)
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
