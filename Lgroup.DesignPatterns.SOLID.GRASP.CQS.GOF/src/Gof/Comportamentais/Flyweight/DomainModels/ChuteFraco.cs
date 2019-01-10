using Flyweight.Contracts;
using System;

namespace Flyweight.DomainModels
{
    public class ChuteFraco : IGolpe
    {
        public void Executar()
        {
            Console.WriteLine("Executando chute fraco");
        }
    }
}
