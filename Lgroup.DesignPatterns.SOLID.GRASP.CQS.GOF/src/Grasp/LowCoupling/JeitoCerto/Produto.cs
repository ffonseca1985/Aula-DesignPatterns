namespace LowCoupling.JeitoCerto
{
    public class Produto
    {
        public Produto(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public decimal Preco { get; set; }
    }
}
