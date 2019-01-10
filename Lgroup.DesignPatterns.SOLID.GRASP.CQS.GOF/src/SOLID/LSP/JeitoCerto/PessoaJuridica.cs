using System;

namespace LSP.JeitoCerto
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public override string GetDocumento()
        {
            return Cnpj;
        }
    }
}
