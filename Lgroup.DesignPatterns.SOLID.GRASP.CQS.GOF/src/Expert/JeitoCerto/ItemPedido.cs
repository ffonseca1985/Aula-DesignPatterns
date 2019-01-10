namespace Expert.JeitoCerto
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
