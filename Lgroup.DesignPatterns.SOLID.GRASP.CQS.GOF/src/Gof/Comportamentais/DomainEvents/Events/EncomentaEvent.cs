using DomainEvents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Events
{
    public class EncomentaEvent : IDomainEvent
    {
        public DateTime DataOcorrencia { get; private set; }
        public string Mensagem { get; private set; }

        public EncomentaEvent(string mensagem)
        {
            DataOcorrencia = DateTime.Now;

            if (string.IsNullOrWhiteSpace(mensagem))
                throw new 
                ApplicationException("mensagem não fornecida");

            Mensagem = mensagem;
        }
    }
}
