using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_AZ.Functions
{
    internal static class FunctionsUsefull
    {
        public static void SendEmail(string to, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("kerimzzade@gmail.com", "jkkzbwltznpjrkvi"),
                EnableSsl = true,
            };

            smtpClient.Send("kerimzzade@gmail.com",to, subject, body);
        }
    }
}
