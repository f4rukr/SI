using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace OnlineBanking.Web.Helper
{
    public class Email
    {
        public static void Posalji(string naslov, string sadrzaj, params string[] primaoci)
        {
            MailMessage mail = new MailMessage();
            using (SmtpClient SmtpServer = new SmtpClient())
            {
                mail.From = new MailAddress("fitbanka@gmail.com");
                foreach (string s in primaoci)
                {
                    mail.To.Add(s);
                }
                mail.Subject = naslov;
                mail.Body = sadrzaj;
                mail.IsBodyHtml = true;

                SmtpServer.Send(mail);
            }
        }
               
    }
}
