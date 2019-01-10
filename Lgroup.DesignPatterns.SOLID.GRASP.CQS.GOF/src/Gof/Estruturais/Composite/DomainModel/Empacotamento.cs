using Composite.Contracts;
using System;

namespace Composite.DomainModel
{
    public class Empacotamento : IFormatacao
    {
        public void Formatar()
        {
            Console.WriteLine("Arquivo Empacotado");
        }
    }
}
