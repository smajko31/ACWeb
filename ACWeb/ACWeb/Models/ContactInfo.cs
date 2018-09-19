﻿using System;
using System.Net.Mail;
using System.Configuration;

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
            MailMessage message = new MailMessage(new MailAddress(ConfigurationManager.AppSettings["SourceEmail"]), new MailAddress(ConfigurationManager.AppSettings["DestinationEmail_1"]));
            //message.From = new MailAddress(ConfigurationManager.AppSettings["SourceEmail"]);
            //message.To.Add(new MailAddress(ConfigurationManager.AppSettings["DestinationEmail_1"]));
            message.CC.Add(new MailAddress(ConfigurationManager.AppSettings["DestinationEmail_2"]));
            message.CC.Add(new MailAddress(ConfigurationManager.AppSettings["DestinationEmail_3"]));
            message.Subject = this.Subject;
            message.Body = String.Format("Name: {0}\nEmail: {1}\nPhone: {2}\n\n Message: {3} ", this.Name, this.Email, this.Phone, this.Message);

            SmtpClient client = new SmtpClient();
            client.Send(message);
        }
    }
}