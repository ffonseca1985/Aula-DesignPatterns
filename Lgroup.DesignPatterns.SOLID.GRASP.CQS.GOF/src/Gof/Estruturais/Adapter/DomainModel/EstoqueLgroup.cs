using Adapter.Constracts;
using System;

namespace Adapter.DomainModel
{
    //Este aqui é o nosso dominio, o nosso modelo de negócio
    public class EstoqueLgroup : ILogistica
    {
        public void BaixarEstoque(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} itens");
        }
    }
}
