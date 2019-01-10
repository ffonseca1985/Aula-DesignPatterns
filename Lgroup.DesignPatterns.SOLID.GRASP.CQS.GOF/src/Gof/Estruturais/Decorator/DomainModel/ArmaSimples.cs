using Decorator.Contracts;
using System;

namespace Decorator.DomainModel
{
    public class ArmaSimples : IArma
    {
        //Arma crua, sem acessório
        //Preciso adicinar acessorios nesta arma.
        //Vou chamar o acessório de Decorator
        public void Montar()
        {
            Console.WriteLine( $"{this.Nome} => Montando a minha arma simples");
        }

        public string Nome { get; set; }
    }
}
