using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.JeitoCerto
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public override string GetDocumento()
        {
            return Cpf;
        }
    }
}
