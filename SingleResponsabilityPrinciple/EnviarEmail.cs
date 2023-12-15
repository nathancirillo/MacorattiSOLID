using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    class EnviarEmail
    {
        public string Body  { get;  set; }
        public string From { get;  set; }
        public string Subject { get;  set; }
        public string To { get;  set; }
   

        public void Enviar()
        {
            MailMessage mailMessage = new MailMessage(From, To, Subject,Body);
        }

    }
}
