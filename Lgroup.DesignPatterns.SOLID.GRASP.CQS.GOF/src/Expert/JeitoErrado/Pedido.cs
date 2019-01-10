using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.JeitoErrado
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }

        public decimal GetTotal()
        {
            decimal total = 0;

            foreach (var item in Itens)
            {
                total += item.Produto.Preco;
            }

            return total;
        }
    }
}
