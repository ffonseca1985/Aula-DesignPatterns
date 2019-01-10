using Composite.Contracts;
using System;

namespace Composite.DomainModel
{
    public class Minificacao : IFormatacao
    {
        public void Formatar()
        {
            Console.WriteLine("Arquivo Minificado");
        }
    }
}
