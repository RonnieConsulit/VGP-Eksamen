using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return ++ticketCounter;
        }

        public static int NextActivty()
        {
            return ++activityCounter;
        }

        public static int NextKunder()
        {
            return ++kundeCounter;
        }

        public static int NextBruger()
        {
            return ++brugerCounter;
        }
    }

}
