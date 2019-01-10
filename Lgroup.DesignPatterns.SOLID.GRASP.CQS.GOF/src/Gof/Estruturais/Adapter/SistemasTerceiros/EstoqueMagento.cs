using System;

namespace Adapter.SistemasTerceiros
{
    //Poderia ser uma API Rest, um Webservice Soap,  
    public class EstoqueMagento
    {
        public void Baixar(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} itens");
        }
    }
}
