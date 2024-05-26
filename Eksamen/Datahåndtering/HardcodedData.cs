using System;
using System.Collections.Generic;
using System.Text;
using Eksamen.Classes;

namespace Eksamen.Datahåndtering
{
    public class HardcodedData
    {
        public static void InitializeTickets()
        {
            if (TicketData.alleTicketsList == null || TicketData.alleTicketsList.Count == 0)
            {
                Ticket ticket1 = new Ticket("Problemer med mail", "FirmaX", "Peter Hansen", "Åben");
                Aktiviteter aktivitet1 = new Aktiviteter(ticket1, 1, "Geninstaller outlook", "Installere office365 i stedet");
                Aktiviteter aktivitet2 = new Aktiviteter(ticket1, 1, "Ny licens", "Købes ved vores licens levenrandør");
                ticket1.AktivitetList.Add(aktivitet1);
                ticket1.AktivitetList.Add(aktivitet2);
                TicketData.alleTicketsList.Add(ticket1);

                Ticket ticket2 = new Ticket("Ingen internet", "FirmaY", "Hans Hansen", "Åben");
                Aktiviteter aktivitet3 = new Aktiviteter(ticket2, 2, "Genstart router", "Gl. asus router, bør udskiftes");
                Aktiviteter aktivitet4 = new Aktiviteter(ticket2, 2, "Kontakt ISP", "Norlys på tlf: 12345678");
                ticket2.AktivitetList.Add(aktivitet3);
                ticket2.AktivitetList.Add(aktivitet4);
                TicketData.alleTicketsList.Add(ticket2);

                Ticket ticket3 = new Ticket("PC slukker", "FirmaY", "Hans Hansen", "Åben");
                Aktiviteter aktivitet5 = new Aktiviteter(ticket3, 3, "Tjek strøm kabel", "Kabel sidder løst");
                ticket3.AktivitetList.Add(aktivitet5);
                TicketData.alleTicketsList.Add(ticket3);

                Ticket ticket4 = new Ticket("Puds hans glorie", "Ronnies biks og bajer", "Hans Hansen", "Åben");
                Aktiviteter aktivitet6 = new Aktiviteter(ticket4, 4, "Hent pudsemiddel", "I T-Hansen");
                Aktiviteter aktivitet7 = new Aktiviteter(ticket4, 4, "Puds glorie", "Pudse pudse");
                ticket4.AktivitetList.Add(aktivitet6);
                ticket4.AktivitetList.Add(aktivitet7);
                TicketData.alleTicketsList.Add(ticket4);
            }

        }

        public static void InitializeKunder()
        {
            Personer.KundeData.alleKunderList.Add(new Kunde("FirmaX", "123 Dinvej", "john.doe@example.com", "invoice@example.com", "Sølger alt hvad du ikke ønsker"));
            Personer.KundeData.alleKunderList.Add(new Kunde("FirmaY", "456 Ikkedinvej", "jane.smith@example.com", "invoice2@example.com", "Sælger alt hvad du ønsker"));
            Personer.KundeData.alleKunderList.Add(new Kunde("Ronnies biks og bajer", "Hvilkenvej 123", "RonniePetersen@hotmail.com", "RonniePetersen@hotmail.com", "Verdensmand"));
        }

        public static void InitializeBrugere()
        {
            Personer.BrugerData.alleBrugereList.Add(new Bruger("Hans Hansen", "123 Stationsvej", "h.hansen@example.com", 12345678, "IT supporter"));
            Personer.BrugerData.alleBrugereList.Add(new Bruger("Peter Hansen", "456 Stadionvej", "p.petersen@example.com", 87654321, "Netværks specialist"));
        }

    }
}
