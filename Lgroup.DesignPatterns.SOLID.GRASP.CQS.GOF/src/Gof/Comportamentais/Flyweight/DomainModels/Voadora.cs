using Flyweight.Contracts;
using System;

namespace Flyweight.DomainModels
{
    public class Voadora : IGolpe
    {
        public void Executar()
        {
            Console.WriteLine("Executando uma voadora");
        }
    }
}
