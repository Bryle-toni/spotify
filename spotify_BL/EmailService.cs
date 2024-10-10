using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace new_email_tool
{
    public class EmailService
    {
        string _smtpServer = "sandbox.smtp.mailtrap.io";
        int _port = 2525;
        string _userName = "2bc92b3ed245e3";
        string _password = "40e85a3eaffcd4";
        string _recipientName = "Bryle Anthony Atienza";
        string _recipientEmail = "bryleatienza1@gmail.com";
        public void SendEmail(string subject, string htmlBody)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Top 10 Songs", "spotify.com"));
            message.To.Add(new MailboxAddress(_recipientName, _recipientEmail));
            message.Subject = subject;

            message.Body = new TextPart("html")
            {
                Text = htmlBody
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_smtpServer, _port, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(_userName, _password);
                    client.Send(message);
                    Console.WriteLine("Email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}