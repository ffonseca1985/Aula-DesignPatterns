using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.JeitoCerto
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }
        
        public void AddItemPedido(int idProduto, int qtde)
        {
            var item = new ItemPedido(idProduto, qtde);
            Itens.Add(item);
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
