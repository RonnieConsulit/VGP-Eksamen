using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Eksamen.Classes.Personer;

namespace Eksamen.Classes
{

    public class Counter
    {
        private static int ticketCounter = 0;
        private static int activityCounter = 0;
        private static int brugerCounter = 0;
        private static int kundeCounter = 0;

        public static int NextTicket()
        {
            ticketCounter = TicketData.alleTicketsList.Count;
            return ++ticketCounter;
        }

        public static int NextActivty()
        {
            activityCounter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList).Count;
            return ++activityCounter;
        }

        public static int NextKunder()
        {   kundeCounter = KundeData.alleKunderList.Count;
            return ++kundeCounter;
        }

        public static int NextBruger()
        {
            brugerCounter = BrugerData.alleBrugereList.Count;
            return ++brugerCounter;
        }
    }

}
