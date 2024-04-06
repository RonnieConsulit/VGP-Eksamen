﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamen
{
    public class Menu
    {
        private FormTilføjAktivitet formTilføjAktivitet;
        private Form activeForm = null;

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
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm != parentForm)
                    {
                        openForm.Close();
                    }
                }
                parentForm.Close();
            }
            catch (InvalidOperationException)
            {
                // Ignore the exception
            }
        }
    }
}
