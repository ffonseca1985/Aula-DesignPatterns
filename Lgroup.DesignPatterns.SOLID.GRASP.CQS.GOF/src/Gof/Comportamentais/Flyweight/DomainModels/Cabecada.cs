using Flyweight.Contracts;
using System;

namespace Flyweight.DomainModels
{
    public class Cabecada : IGolpe
    {
        public void Executar()
        {
            Console.WriteLine("Cabecada sendo executada");
        }
    }
}
