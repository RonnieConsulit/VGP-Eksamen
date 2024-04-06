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

            int countAabneTickets = TicketData.alleTicketsList.Count(ticket => ticket.Status == "Åben");
            textBoxÅbneTickets.Text = countAabneTickets.ToString();

            int countLukkedeTickets = TicketData.alleTicketsList.Count(ticket => ticket.Status == "Lukket");
            textBoxLukkedeTickets.Text = countLukkedeTickets.ToString();

            int countAabneAkt = alleAktiviteter.Count(aktivitet => aktivitet.Status == "Åben");
            textBoxÅbneAkt.Text = countAabneAkt.ToString();

            int countLukkedeAkt = alleAktiviteter.Count(aktivitet => aktivitet.Status == "Lukket");
            textBoxLukkedeAkt.Text = countLukkedeAkt.ToString();
            textBoxAntalBrugere.Text = BrugerData.alleBrugereList.Count.ToString();
            textBoxAntalKunder.Text = KunderData.alleKunderList.Count.ToString();
 
        }
        private Menu menu = new Menu();

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            menu.ÅbnDashboard(this);
        }

        private void btnAktiviteter_Click(object sender, EventArgs e)
        {
            menu.ÅbnAktiviteter(this);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            menu.ÅbnTickets(this);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            menu.ÅbnKunder(this);
        }
        private void btnBrugere_Click(object sender, EventArgs e)
        {
            menu.ÅbenBrugere(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu.Exit(this);
        }

   
    }
}
