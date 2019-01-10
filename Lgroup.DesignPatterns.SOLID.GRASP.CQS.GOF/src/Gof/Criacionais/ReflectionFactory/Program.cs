using ReflectionFactory.Factories;
using System;

namespace ReflectionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = DesenhoFactory.Create("Quadrado");
            quadrado.Desenhar();

            var circulo = DesenhoFactory.Create("Circulo");
            circulo.Desenhar();

            Console.ReadKey();
        }
    }
}
