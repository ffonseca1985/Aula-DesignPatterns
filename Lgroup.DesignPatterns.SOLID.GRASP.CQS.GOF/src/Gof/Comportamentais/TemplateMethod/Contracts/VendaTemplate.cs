using System.Collections.Generic;
using System.Linq;

namespace TemplateMethod.Contracts
{
    public abstract class VendaTemplate
    {
        public void Finalizar(string cpf)
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(cpf))
                throw new System.Exception("Cpf não informado");

            if (!this.PuxarCapivara(cpf))
                erros.Add("Nome sujo");

            if (!this.ValidarEstoque())
                erros.Add("Sem estoque");

            if (!this.EfetuarPagamento())
                erros.Add("Erro ao gerar pgto");

            if (erros.Count == 0)
                this.DarBaixa();

            if (erros.Count > 0)
                System.Console.WriteLine(string.Join(",", erros));
        }

        protected abstract bool PuxarCapivara(string cpf);
        protected abstract bool ValidarEstoque();
        protected abstract bool EfetuarPagamento();
        protected abstract void DarBaixa();
    }
}
