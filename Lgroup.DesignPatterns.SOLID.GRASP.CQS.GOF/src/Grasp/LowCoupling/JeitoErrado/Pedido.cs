using System.Collections.Generic;

namespace LowCoupling.JeitoErrado
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }
        public Pagamento Pagamento { get; private set; }

        public void AddItemPedido(int idProduto, int qtde)
        {
            var item = new ItemPedido(idProduto, qtde);
            Itens.Add(item);
        }

        public void AdicionarPagamento(Pagamento pgto)
        {
            if (pgto == null)
                throw new System.Exception("Pgto não informado");

            Pagamento = pgto;
        }

        public void RealizarPagamento()
        {
            if (Pagamento == null)
                throw new System.Exception("Pagamento não informado");

            System.Console.WriteLine("Pagamento Realizado");
        }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var item in Itens)
            {
                total += item.SubTotal();
            }

            return total;
        }
    }
}
