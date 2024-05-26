using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Eksamen.Classes
{
    internal class Personer
    {
        protected static int counter = 0;

        public int Id { get; protected set; }
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
            Id = GenerateId();
        }

        // til import af data
        public Personer(string navn, string adresse, string email, string beskrivelse, int id)
        {
            Navn = navn;
            Adresse = adresse;
            Email = email;
            Beskrivelse = beskrivelse;
            Id = Id;
        }

        public static class KundeData
        {
            public static List<Kunde> alleKunderList { get; set; } = new List<Kunde>();
        }

        public static class BrugerData
        {
            public static List<Bruger> alleBrugereList { get; set; } = new List<Bruger>();
        }


        protected virtual int GenerateId()
        {
            return ++counter;
        }

        public virtual bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(Navn) &&
                   !string.IsNullOrWhiteSpace(Adresse) &&
                   !string.IsNullOrWhiteSpace(Email) &&
                   !string.IsNullOrWhiteSpace(Beskrivelse);
        }

        public virtual bool IsUnique<T>(List<T> personList) where T : Personer
        {
            return !personList.Exists(person => person.Navn.Equals(Navn));
        }

        public virtual bool CreateNewUser(string navn, string adresse, string email, int telefon, string beskrivelse, List<Bruger> userList)
        {
            return false; // Default implementation
        }

        public virtual bool CreateNewCustomer(string navn, string adresse, string email, string kontakt, string beskrivelse, List<Kunde> kundeList)
        {
            return false; // Default implementation
        }

        public static void LoadList<T>(ListBox listBox, List<T> dataList) where T : Personer
        {
            if (dataList == null || dataList.Count == 0)
                return;

            listBox.DataSource = dataList;
            listBox.DisplayMember = "Info";

            listBox.ClearSelected();
        }

        public static void Delete<T>(ListBox listBox, TextBox txtBoxNavn, TextBox txtBoxAdresse, TextBox txtBoxEmail, TextBox txtBoxKontakt, TextBox txtBoxBeskrivelse, List<T> dataList) where T : Personer
        {
            if (listBox.SelectedItem != null)
            {
                var selectedPerson = (T)listBox.SelectedItem;

                if (dataList.Contains(selectedPerson))
                {
                    dataList.Remove(selectedPerson);

                    listBox.DataSource = null;
                    listBox.DataSource = dataList;
                    listBox.DisplayMember = "Info";
                    txtBoxNavn.Text = "";
                    txtBoxAdresse.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxKontakt.Text = "";
                    txtBoxBeskrivelse.Text = "";

                    MessageBox.Show("Elementet er slettet.", "Sletning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Elementet kunne ikke findes i listen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Intet element er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Update<T>(ListBox listBox, TextBox txtBoxNavn, TextBox txtBoxAdresse, TextBox txtBoxEmail, TextBox txtBoxKontakt, TextBox txtBoxBeskrivelse) where T : Personer
        {
            if (listBox.SelectedItem != null)
            {
                var selectedPerson = (T)listBox.SelectedItem;

                selectedPerson.Navn = txtBoxNavn.Text;
                selectedPerson.Adresse = txtBoxAdresse.Text;
                selectedPerson.Email = txtBoxEmail.Text;

                if (typeof(T) == typeof(Kunde))
                {
                    ((Kunde)(object)selectedPerson).Kontakt = txtBoxKontakt.Text;
                }
                else if (typeof(T) == typeof(Bruger))
                {
                    ((Bruger)(object)selectedPerson).Telefon = int.Parse(txtBoxKontakt.Text);
                }

                selectedPerson.Beskrivelse = txtBoxBeskrivelse.Text;

            
                if (typeof(T) == typeof(Kunde))
                {
                    listBox.DataSource = null;
                    listBox.DataSource = KundeData.alleKunderList;
                }
                else if (typeof(T) == typeof(Bruger))
                {
                    listBox.DataSource = null;
                    listBox.DataSource = BrugerData.alleBrugereList;
                }

                listBox.DisplayMember = "Info";

                MessageBox.Show("Ændringerne er gemt.", "Gemt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Intet element er valgt.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

    internal class Bruger : Personer
    {
        public int Telefon { get; set; }

        public Bruger(string navn, string adresse, string email, int telefon, string beskrivelse)
            : base(navn, adresse, email, beskrivelse)
        {
            Telefon = telefon;
        }

        // til import af data
        public Bruger(string navn, string adresse, string email, int telefon, string beskrivelse, int id)
    : base(navn, adresse, email, beskrivelse)
        {
            Telefon = telefon;
        }

        protected override int GenerateId()
        {
            return ++counter;
        }

        public override bool CreateNewUser(string navn, string adresse, string email, int telefon, string beskrivelse, List<Bruger> userList)
        {
            var newUser = new Bruger(navn, adresse, email, telefon, beskrivelse);
            if (!newUser.ValidateFields())
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!newUser.IsUnique(userList))
            {
                MessageBox.Show("Brugernavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            userList.Add(newUser);
            return true;
        }

    }

    internal class Kunde : Personer
    {
        public string Kontakt { get; set; }

        public Kunde(string navn, string adresse, string email, string kontakt, string beskrivelse)
           : base(navn, adresse, email, beskrivelse)
        {
            Kontakt = kontakt;
        }

        public Kunde(string navn, string adresse, string email, string kontakt, string beskrivelse, int id)
   : base(navn, adresse, email, beskrivelse)
        {
            Kontakt = kontakt;
        }

        protected override int GenerateId()
        {
            return ++counter;
        }

        public override bool CreateNewCustomer(string navn, string adresse, string email, string kontakt, string beskrivelse, List<Kunde> kundeList)


        {
            var newKunde = new Kunde(navn, adresse, email, kontakt, beskrivelse);
            if (!newKunde.ValidateFields())
            {
                MessageBox.Show("Alle felter skal udfyldes.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!newKunde.IsUnique(kundeList))
            {
                MessageBox.Show("Virksomhedsnavnet eksisterer allerede.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            kundeList.Add(newKunde);
            return true;
        }
    }

}