using ReflectionFactory.Contracts;
using System;

namespace ReflectionFactory.Model
{
    public class Circulo : IDesenho
    {
        public void Desenhar()
        {
            Console.WriteLine("Desenhando um Circulo...");
        }
    }
}
