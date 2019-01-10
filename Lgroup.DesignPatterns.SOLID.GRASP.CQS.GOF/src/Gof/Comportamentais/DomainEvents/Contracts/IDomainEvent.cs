using System;

namespace DomainEvents.Contracts
{
    //Algo que aconteceu no passado e quero informa a alguém
    //Então DomainEvents => é algo que aconteceu de importe no seu negocio(Domain)
    //E que é necessário informar a algo (outros serviços/ sistemas) 
    public interface IDomainEvent
    {
        DateTime DataOcorrencia { get; }
        string Mensagem { get; }
    }
}
