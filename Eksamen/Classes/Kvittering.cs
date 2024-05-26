using System.Collections.Generic;
using System.Text;

namespace Eksamen.Classes
{
    public class Kvittering
    {
        public static string GenerateKvittering(Ticket ticket, List<Aktiviteter> closedActivities)
        {
            StringBuilder kvitteringBuilder = new StringBuilder();

            kvitteringBuilder.AppendLine($"Kvittering for ticket: {ticket.Navn}");
            kvitteringBuilder.AppendLine();

            kvitteringBuilder.AppendLine("Aktiviteter:");

            foreach (Aktiviteter aktivitet in closedActivities)
            {
                kvitteringBuilder.AppendLine($"Aktivitet: {aktivitet.Navn}");
                kvitteringBuilder.AppendLine($"Beskrivelse: {aktivitet.Beskrivelse}");
                kvitteringBuilder.AppendLine($"Status: {aktivitet.Status}");
                kvitteringBuilder.AppendLine();
            }

            return kvitteringBuilder.ToString();
        }
    }
}
