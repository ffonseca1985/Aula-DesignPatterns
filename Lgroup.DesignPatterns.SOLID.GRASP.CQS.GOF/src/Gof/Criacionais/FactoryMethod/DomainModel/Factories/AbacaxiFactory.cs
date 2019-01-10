using FactoryMethod.DomainModel.Constracts;
using FactoryMethod.DomainModel.Models;

namespace FactoryMethod.DomainModel.Factories
{
    public static class AbacaxiFactory
    {
        //Se a regra para criar o meu objeto for muito complexa e depende de muitas condições
        //podemos delegar esta construção para uma factorymethod
        public static IAbacaxi Create(EstacaoAno estacao)
        {
            switch (estacao)
            {
                case EstacaoAno.Inverno:
                    return new AbacaxiAmericano() { Nome = "Abacaxi - USA", Localizacao = "Nova York" };
                case EstacaoAno.Verao:
                    return new AbacaxiBrasileiro() { Nome = "Abacaxi - BR", Localizacao = "São Paulo"};
                default:
                    throw new System.ArgumentException("Estação desconhecida");
            }
        }
    }
}
