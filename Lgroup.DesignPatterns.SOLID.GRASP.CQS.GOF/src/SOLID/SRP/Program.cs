using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            JeitoCerto.Email email = JeitoCerto.Email.Create("ffonseca", "everton", "Olá");
            email.EnviarEmail();

            JeitoCerto.Email emailMensagemPadrao = JeitoCerto.Email.CreateEmailMensagemPadrao("ffonseca", "everton");
            email.EnviarEmail();
        }
    }
}
