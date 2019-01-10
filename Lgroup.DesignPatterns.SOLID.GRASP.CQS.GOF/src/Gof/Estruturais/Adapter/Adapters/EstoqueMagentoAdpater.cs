using Adapter.Constracts;
using Adapter.SistemasTerceiros;
using System;

namespace Adapter.Adapters
{
    //Quais são as condições para este cara 
    //estar no nosso domonio???
    //Resposta: Ele tem que ser um ILogistica
    public class EstoqueMagentoAdpater : ILogistica
    {
        //Para que o magento(sistemaTerceiro) se integre com o nosso(Domain Model)
        //Precisamos passar toda a regra do magento para o nosso
        //Como fazemos isso??
        //Por composição
        private EstoqueMagento _estoqueMagento;

        public EstoqueMagentoAdpater()
        {
            _estoqueMagento = new EstoqueMagento();
        }

        public void BaixarEstoque(int idProduto, int qtde)
        {
            _estoqueMagento.Baixar(idProduto, qtde);
        }
    }
}
