using Eksamen.Classes;
using Menu = Eksamen.Classes.Menu;

namespace Eksamen
{
    public partial class FormDashboard : Form
    {

        private FormAktiviteter formAktiviteter;
        private FormTickets formTickets;
        private FormKunder formKunder;
        private FormBrugere formBrugere;
        private FormDashboard formDashboard;
        private List<Aktiviteter> alleAktiviteter;


        public FormDashboard()
        {
            alleAktiviteter = new List<Aktiviteter>();
            InitializeComponent();
        }

       

        


        

        private void formDashboard_Load(object sender, EventArgs e)
        {


            alleAktiviteter = Aktiviteter.GetAllAktiviteterFromTickets(TicketData.alleTicketsList);

            int countAabneTickets = TicketData.alleTicketsList.Count(ticket => ticket.Status == "�ben");
            textBox�bneTickets.Text = countAabneTickets.ToString();

            int countLukkedeTickets = TicketData.alleTicketsList.Count(ticket => ticket.Status == "Lukket");
            textBoxLukkedeTickets.Text = countLukkedeTickets.ToString();

            int countAabneAkt = alleAktiviteter.Count(aktivitet => aktivitet.Status == "�ben");
            textBox�bneAkt.Text = countAabneAkt.ToString();

            int countLukkedeAkt = alleAktiviteter.Count(aktivitet => aktivitet.Status == "Lukket");
            textBoxLukkedeAkt.Text = countLukkedeAkt.ToString();
            textBoxAntalBrugere.Text = Personer.BrugerData.alleBrugereList.Count.ToString();
            textBoxAntalKunder.Text = Personer.KundeData.alleKunderList.Count.ToString();
 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           Menu.Instance.�bnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            Menu.Instance.�bnKunder(this);
        }
        private void btnBrugere_Click(object sender, EventArgs e)
        {
            Menu.Instance.�benBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu.Instance.Exit(this);
        }

   
    }
}
