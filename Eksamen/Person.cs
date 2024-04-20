using System;
using System.Collections.Generic;

namespace Eksamen
{
    internal class Personer
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Beskrivelse { get; set; }

        public Personer(string navn, string adresse, string email, string beskrivelse)
        {
            Navn = navn;
            Adresse = adresse;
            Email = email;
            Beskrivelse = beskrivelse;
        }

        protected virtual int GenerateId()
        {
            return 0; // Default implementation, should be overridden
        }

        public string Info
        {
            get { return $"Id: {Id}, Navn: {Navn}"; }
        }
    }

    internal class Brugere : Personer
    {
        public int Telefon { get; set; }

        public Brugere(string navn, string adresse, string email, int telefon, string beskrivelse)
            : base(navn, adresse, email, beskrivelse)
        {
            Telefon = telefon;
            Id = Counter.NextBruger();
        }

        protected override int GenerateId()
        {
            return Counter.NextBruger();
        }

        public static bool CreateNewUser(string navn, string adresse, string email, int telefon, string beskrivelse)
        {
            // Alt skal være udfyldt
            if (string.IsNullOrWhiteSpace(navn) ||
                string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefon.ToString()) ||
                string.IsNullOrWhiteSpace(beskrivelse))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Findes bruger allerede
            if (!IsUniqueUser(navn, BrugerData.alleBrugereList))
            {
                MessageBox.Show("Brugernavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int telefonNumber;
            if (int.TryParse(telefon.ToString(), out telefonNumber))
            {
                Brugere newBruger = new Brugere(navn, adresse, email, telefonNumber, beskrivelse);
                BrugerData.alleBrugereList.Add(newBruger);
                return true;
            }
            else
            {
                MessageBox.Show("Forkert telefon nr. format.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private static bool IsUniqueUser(string brugerNavn, List<Brugere> userList)
        {
            return !userList.Any(bruger => bruger.Navn.Equals(brugerNavn));
        }
    }

    internal class Kunde : Personer
    {
        public string Kontakt { get; set; }

        public Kunde(string navn, string adresse, string email, string kontakt, string beskrivelse)
            : base(navn, adresse, email, beskrivelse)
        {
            Kontakt = kontakt;
            Id = Counter.NextKunder(); // Generate unique Id for Kunde
        }

        protected override int GenerateId()
        {
            return Counter.NextKunder();
        }

        public static bool CreateNewCustomer(string navn, string adresse, string email, string kontakt, string beskrivelse)
        {
            // Alt skal være udfyldt
            if (string.IsNullOrWhiteSpace(navn) ||
                string.IsNullOrWhiteSpace(adresse) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(kontakt) ||
                string.IsNullOrWhiteSpace(beskrivelse))
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Findes firma allerede
            if (!IsUniqueCompany(navn))
            {
                MessageBox.Show("Virksomhedsnavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Kunde newKunde = new Kunde(navn, adresse, email, kontakt, beskrivelse);
            KunderData.alleKunderList.Add(newKunde);
            return true;
        }

        private static bool IsUniqueCompany(string firmaNavn)
        {
            return !KunderData.alleKunderList.Any(kunde => kunde.Navn.Equals(firmaNavn));
        }
    }

    internal static class BrugerData
    {
        public static List<Brugere> alleBrugereList = new List<Brugere>();
    }

    internal static class KunderData
    {
        public static List<Kunde> alleKunderList = new List<Kunde>();
    }

    public static class PersonHandler
    {
        public static void LoadKunderList(ListBox listBoxKunder)
        {
            if (KunderData.alleKunderList == null || KunderData.alleKunderList.Count == 0)
            {
            }

            listBoxKunder.DataSource = KunderData.alleKunderList;
            listBoxKunder.DisplayMember = "Info";

            // Clear
            listBoxKunder.ClearSelected();
        }

        public static void DeleteKunde(ListBox listBoxKunder, TextBox txtBoxNavn, TextBox txtBoxAdresse, TextBox txtBoxEmail, TextBox txtBoxKontakt, TextBox txtBoxBeskrivelse)
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

        public static void UpdateKunde(ListBox listBoxKunder, TextBox txtBoxNavn, TextBox txtBoxAdresse, TextBox txtBoxEmail, TextBox txtBoxKontakt, TextBox txtBoxBeskrivelse)
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
    }
}
