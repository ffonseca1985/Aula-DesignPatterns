using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.JeitoErrado
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }

        //Quem esta criando o item não é o pedido!!!!!
        //Quem esta criando é quem chama o pedido..
        //Qual o problema?
        //Estamos delegando a criação de itens a uma classe que não tem esta responsabilidade
        //Fora que a classe Pedido fica com baixa coesão..
        public void AddItemPedido(ItemPedido item)
        {
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
