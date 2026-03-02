using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LR5_s8.UsersClasses
{
    public class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAdress,
     StringPair emailAdressFrom,
     string emailPassword,
     StringPair emailAdressTo,
     string subject,
     string body)
        {
            smtpClientAdress = String.IsNullOrWhiteSpace(smtpClientAdress) ?
                throw new Exception("Нех вставлять пробелы или пустоту") :
                smtpClientAdress;

            SmtpClientAdress = smtpClientAdress;

            EmailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));
            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
                 throw new Exception("иди на") :
                 emailPassword;
            EmailAdressTo = emailAdressTo ?? throw new ArgumentNullException(nameof(emailAdressTo));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            Body = body ?? throw new ArgumentNullException(nameof(body));
        }

        public string SmtpClientAdress { get; set; }
        public StringPair EmailAdressFrom { get; set; }
        public string EmailPassword { get; set; }
        public StringPair EmailAdressTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


    }

}
