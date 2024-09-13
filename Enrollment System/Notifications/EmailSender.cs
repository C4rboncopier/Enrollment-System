using Enrollment_System.Entity_Class;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System.Notifications
{
    public class EmailSender
    {
        public static async Task SendEmailAsync(Accounts account, Tickets ticket)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("c4rboncopier@gmail.com");
                    mail.To.Add($"{account.email}");
                    mail.Subject = "Enrollment Queue";
                    mail.Body = $"Your ticket number {ticket.ticketNum} is approaching. Please proceed to the Enrollment Room.";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpClient.Credentials = new NetworkCredential("c4rboncopier@gmail.com", "msoy yidw ujuy ftor");
                        smtpClient.EnableSsl = true;

                        await smtpClient.SendMailAsync(mail);
                    }
                }

                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}