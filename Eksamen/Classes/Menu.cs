namespace Eksamen.Classes
{
    public class Menu
    {
        private static Menu instance = null;
        private static readonly object lockObject = new object();

        private Form activeForm = null;


        private Menu() { }

 
        public static Menu Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Menu();
                    }
                    return instance;
                }
            }
        }

        private void OpenNewForm(Form newForm)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                openForm.Hide();
            }

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = newForm;
            activeForm.Show();
        }

        public void ÅbnDashboard(Form parentForm)
        {
            OpenNewForm(new FormDashboard());
        }

        public void ÅbnAktiviteter(Form parentForm)
        {
            OpenNewForm(new FormAktiviteter());
        }

        public void ÅbnTickets(Form parentForm)
        {
            OpenNewForm(new FormTickets());
        }

        public void ÅbnKunder(Form parentForm)
        {
            OpenNewForm(new FormKunder());
        }

        public void ÅbenBrugere(Form parentForm)
        {
            OpenNewForm(new FormBrugere());
        }

        public void ÅbenTilføjKunder(Form parentForm)
        {
            OpenNewForm(new FormTilføjKunder());
        }

        public void ÅbenTilføjTickets(Form parentForm)
        {
            OpenNewForm(new FormTilføjTickets());
        }

        public void ÅbenTilføjBrugere(Form parentForm)
        {
            OpenNewForm(new FormTilføjBrugere());
        }

        public void ÅbenTilføjAktiviteter(Form parentForm, Ticket selectedTicket)
        {
            if (selectedTicket != null)
            {
                FormTilføjAktivitet formTilføjAktivitet = new FormTilføjAktivitet(selectedTicket);
                formTilføjAktivitet.FormClosed += (s, args) => parentForm.Show();
                formTilføjAktivitet.Show();
                parentForm.Hide();
            }
            else
            {
                MessageBox.Show("Ingen valgt ticket.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Exit(Form parentForm)
        {
            try
            {
                // Close all open forms
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm != parentForm)
                    {
                        openForm.Close();
                    }
                }

                // Close the parent form
                parentForm.Close();

                // Terminate the application
                Application.Exit();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error closing the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
