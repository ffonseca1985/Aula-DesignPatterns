namespace Observer.Contracts
{
    public interface INewsLetters
    {
        void EnviarEmail();
        void Registrar(IAssinante assinantes);
        void Remove(IAssinante assinantes);
    }
}
