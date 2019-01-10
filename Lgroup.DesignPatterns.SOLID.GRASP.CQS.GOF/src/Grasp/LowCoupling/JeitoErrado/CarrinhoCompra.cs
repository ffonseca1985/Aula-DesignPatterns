using System.Collections.Generic;

namespace LowCoupling.JeitoErrado
{
    public class CarrinhoCompra
    {
        public Pedido Pedido { get; set; }
        public Pagamento Pgto { get; set; }
        public List<ItemCarrinho> Itens { get; set; }

        public void AdicionarPagamento()
        {
            Pgto = new Pagamento();
            Pgto.QtdeParcelas = 2;
            Pgto.FormaPagto = "Boleto";

            decimal total = 0;

            foreach (var item in Itens) {
                total += item.SubTotal();      
            }

            Pgto.Total = total;

            Pedido.AdicionarPagamento(Pgto);
            Pedido.RealizarPagamento();
        }
    }
}
