using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace mailerCLI
{
    class SendMail
    {
        public static void send(config configuration, MailInfo info)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                MailMessage message = new MailMessage(info.from, info.to, configuration.subject, configuration.body);
                client.Credentials = LoginInfo.credentials;
                client.EnableSsl = true;
                client.Send(message);
            }
        }
    }
}
