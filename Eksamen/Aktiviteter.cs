using System;

namespace Eksamen
{
    public class Aktiviteter
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int TicketNummer { get; set; }
        public string Kunde { get; set; }
        public string Ansvarlig { get; set; }
        public string Beskrivelse { get; set; }

        public string Status { get; set; }

        public Aktiviteter(Ticket ticket, int ticketNummer, string navn, string beskrivelse)
        {
            Id = GenerateId();
            Navn = navn;
            TicketNummer = ticketNummer;
            Kunde = ticket.Kunde;
            Ansvarlig = ticket.Ansvarlig;
            Beskrivelse = beskrivelse;
            Status = "Åben";
        }

        protected virtual int GenerateId()
        {
            return Counter.NextActivty();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}";
        }


        public static List<Aktiviteter> GetAllAktiviteterFromTickets(List<Ticket> tickets)
        {
            List<Aktiviteter> alleAktiviteter = new List<Aktiviteter>();

            foreach (Ticket ticket in tickets)
            {
                foreach (Aktiviteter aktivitet in ticket.Aktiviteter)
                {
                    alleAktiviteter.Add(aktivitet);
                }
            }

            return alleAktiviteter;
        }

    }


}


