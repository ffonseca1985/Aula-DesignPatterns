namespace HighCohesion.JeitoCerto.DomainModel
{
    public class ItemPedido
    {
        public int Id { get; set; }

        public ItemPedido(int idProduto, int qtde)
        {
            Produto = new Produto(idProduto);
            Qtd = qtde;
        }

        public Produto Produto { get; private set; }
        public int Qtd { get; private set; }

        public void AddQtde(int qtde)
        {
            Qtd += qtde;
        }

        public decimal SubTotal()
        {
            return Produto.Preco * Qtd;
        }
    }
}
