using System.Net.Mail;
using System.Net;

namespace VANTAN_AUTO.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password"),
                    EnableSsl = true,
                };
                await smtpClient.SendMailAsync(new MailMessage("your-email@gmail.com", email, subject, message) { IsBodyHtml = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể gửi email: " + ex.Message);
            }
        }
    }
}