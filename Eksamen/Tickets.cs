using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen
{

    public class Ticket
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Kunde { get; set; }
        public string Ansvarlig { get; set; }
        public string Status { get; set; }
        public List<Aktiviteter> Aktiviteter { get; set; } = new List<Aktiviteter>();

        public Ticket(string navn, string kunde, string ansvarlig, string status)
        {
            Id = GenerateId();
            Navn = navn;
            Kunde = kunde;
            Ansvarlig = ansvarlig;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}, Kunde: {Kunde}";
        }

        protected virtual int GenerateId()
        {
            return Counter.NextTicket();
        }

    }

    internal static class TicketData
    {
        public static List<Ticket> alleTicketsList = new List<Ticket>();
        public static List<string> alleTicketStatus = new List<string> { "Åben", "Lukket" };

    }
}
 