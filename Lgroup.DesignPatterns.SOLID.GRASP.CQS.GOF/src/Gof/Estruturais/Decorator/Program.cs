using Decorator.DomainModel;
using Decorator.DomainModel.Decorator.Arma;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arma = new ArmaSimples();
            arma.Nome = "Taurus";
            arma.Montar();

            var montadorMira = new ArmaComMira(arma);
            montadorMira.Montar();

            var adicinonarSilenciador = new ArmaComSilenciador(arma);
            adicinonarSilenciador.Montar();

            System.Console.WriteLine(arma.Nome);

            System.Console.ReadLine();
        }
    }
}
