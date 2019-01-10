using Composite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.DomainModel
{
    public class Criptografia : IFormatacao
    {
        public void Formatar()
        {
            Console.WriteLine("Arquivo Criptigrafado");
        }
    }
}
