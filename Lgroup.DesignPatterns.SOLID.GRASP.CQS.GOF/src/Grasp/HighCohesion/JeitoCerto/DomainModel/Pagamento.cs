namespace HighCohesion.JeitoCerto.DomainModel
{
    public class Pagamento
    {
        public int QtdeParcelas { get; set; }
        public string FormaPagto { get; set; }
        public decimal Total { get; set; }
    }
}
