using DomainEvents.Contracts;
using DomainEvents.Events;
using System;

namespace DomainEvents.Handlers
{
    public class SistemaLogisticoHandler
        : IHandler<EncomentaEvent>
    {
        public void Handler(EncomentaEvent arg)
        {
            //Isto aqui no mundo real estariamos instanciando uma api
            //de um outro sistema e enviando o evento como parametro da api.
            Console.WriteLine("<<= Logistica =>>");
            Console.WriteLine(arg.DataOcorrencia.ToString("dd/MM/yyyy"));
            Console.WriteLine(arg.Mensagem);
        }
    }
}
