using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.JeitoCerto
{
    public class Email
    {
        private Email(string de, string para, string mensagem)
        {
            this.De = de;
            this.Para = para;
            this.Mensagem = mensagem; 
        }

        public static Email Create(string de, string para, string mensagem)
        {
            if (string.IsNullOrWhiteSpace(de))
                throw new ApplicationException("Remetente não informado");

            if (string.IsNullOrWhiteSpace(para))
                throw new ApplicationException("Destinatario não informado");

            if (string.IsNullOrWhiteSpace(mensagem))
                throw new ApplicationException("Mensagem não informada");

            return new Email(de, para, mensagem);
        }

        public static Email CreateEmailMensagemPadrao(string de, string para)
        {
            var mensagem = "Mensagem Paradrão";
            return Create(de, para, mensagem);
        }

        public string De { get; private set; }
        public string Para { get; private set; }
        public string Mensagem { get; private set; }

        internal void EnviarEmail()
        {
            Console.WriteLine(string.Format("De: {0}, Para:{1}, Mensagem: {2}", De, Para, Mensagem));
        }
    }
}
