using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.JeitoErrado
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        //Poderia fazer assim, mas é gambiarra!!!!
        //public override string ToString()
        //{
        //    return Cpf;
        //}
    }
}
