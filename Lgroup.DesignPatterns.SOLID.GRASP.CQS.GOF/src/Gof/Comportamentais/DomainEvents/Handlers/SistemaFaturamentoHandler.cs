using DomainEvents.Contracts;
using DomainEvents.Events;
using System;

namespace DomainEvents.Handlers
{
    public class SistemaFaturamentoHandler
        : IHandler<EncomentaEvent>
    {
        public void Handler(EncomentaEvent arg)
        {
            Console.WriteLine("<<= Faturamento =>>");
            Console.WriteLine(arg.DataOcorrencia.ToString("dd/MM/yyyy"));
            Console.WriteLine(arg.Mensagem);
        }
    }
}
