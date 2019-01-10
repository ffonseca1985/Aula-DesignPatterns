namespace DomainEvents.Contracts
{
    //O Handler o a classe que vai receber
    //o evento, logo a assinatura dela é a seguinte:
    //<T> => Generics
    public interface IHandler<T> 
        where T : IDomainEvent
    {
        void Handler(T arg);
    }
}
