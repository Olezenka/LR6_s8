using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_s8.UsersClasses
{
    internal class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body) : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("olezasinnicyn@gmail.com", "Вещий Олег");
            EmailPassword = "skkc tmag wfzh hxav";
            Port = 587;
        }
    }
}
