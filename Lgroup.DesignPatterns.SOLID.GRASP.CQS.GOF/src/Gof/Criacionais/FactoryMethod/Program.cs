using FactoryMethod.DomainModel.Constracts;
using FactoryMethod.DomainModel.Factories;
using FactoryMethod.DomainModel.Models;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbacaxi abacaxiUSA = AbacaxiFactory.Create(EstacaoAno.Inverno);
            IAbacaxi abacaxiBrasileiro = AbacaxiFactory.Create(EstacaoAno.Verao);
            
            System.Console.WriteLine(abacaxiUSA.GetDescricao());
            System.Console.WriteLine(abacaxiBrasileiro.GetDescricao());
        }
    }
}
