using System.Collections.Generic;

namespace HighCohesion.JeitoCerto.DomainModel
{
    public class CarrinhoCompra
    {
        public Pedido Pedido { get; set; }
        public List<ItemCarrinho> Itens { get; set; } 

        //Seria como uma factory interna
        public Pedido CriarPedidoApartirCarrinho()
        {
            return new Pedido();
        } 

        public void AdicionarItensCarrinho(int idProduto, int qtde)
        {
            Itens.Add(new ItemCarrinho(idProduto, qtde));
        }
    }
}
