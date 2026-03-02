using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_s8.UsersClasses
{
    internal class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("olezasinnicyn@mail.ru", "Вещий Олег");
            EmailPassword = "bosOvHLbCBVs0i4ZeDI5";
            Port = -1;
        }
    }
}
