using System.Collections.Generic;

namespace LowCoupling.JeitoCerto
{
    public class CarrinhoCompra
    {
        public Pedido Pedido { get; set; }
        public List<ItemCarrinho> Itens { get; set; } 

        public void CriarPedido()
        {
            System.Console.WriteLine("Pedido sendo criado");
        } 
    }
}
