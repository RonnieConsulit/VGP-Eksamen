using System;
using System.Net;
using System.Net.Mail;

namespace Eksamen.Classes
{
    public class Email
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SmtpUsername = "ronniesticketsystem@gmail.com";
        private const string SmtpPassword = "zwng akly kehl kgpb";

        public void SendEmail(string to, string subject, string body)
        {
            using (var client = new SmtpClient(SmtpServer, SmtpPort))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(SmtpUsername, SmtpPassword);

                var message = new MailMessage
                {
                    From = new MailAddress(SmtpUsername),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                };

                message.To.Add(to);

                try
                {
                    client.Send(message);
                    MessageBox.Show("E-mail sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {
                    string errorMessage = ex.StatusCode == SmtpStatusCode.Ok ? "The operation was successful." : $"Error code: {ex.StatusCode}";
                    MessageBox.Show($"Error sending email: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
