using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ACWeb.Models
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public void Send()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("your email address");
            message.To.Add(new MailAddress("your recipient"));
            message.Subject = this.Subject;
            message.Body = String.Format("Name: {0}\nEmail: {1}\nPhone: {2}\n\n Message{3}: ", this.Name, this.Email, this.Phone, this.Message);

            SmtpClient client = new SmtpClient();
            client.Send(message);
        }
    }
}