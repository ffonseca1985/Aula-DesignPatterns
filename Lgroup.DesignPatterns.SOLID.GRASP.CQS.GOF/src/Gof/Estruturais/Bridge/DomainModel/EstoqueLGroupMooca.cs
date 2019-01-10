using Bridge.Contracts;
using System;

namespace Bridge.DomainModel
{
    public class EstoqueLGroupMooca : ILogistica
    {
        public void BaixarEstoque(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} itens");
        }
    }
}
