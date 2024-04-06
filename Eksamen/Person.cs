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
    }

    internal static class BrugerData
    {
        public static List<Brugere> alleBrugereList = new List<Brugere>();
    }

    internal static class KunderData
    {
        public static List<Kunde> alleKunderList = new List<Kunde>();
    }
}
