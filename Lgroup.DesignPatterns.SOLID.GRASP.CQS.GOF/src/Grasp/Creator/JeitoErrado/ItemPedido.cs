using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.JeitoErrado
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Qtd { get; set; }

        public decimal SubTotal()
        {
            return Produto.Preco * Qtd;
        }
    }
}
