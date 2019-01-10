namespace LGroup.Curso.PadroesArquiteturais.DomainModel.ValueObjects
{
    public class Preco
    {
        public Preco(decimal cotacao, Moeda moeda, decimal valor)
        {
            Cotacao = cotacao;
            Moeda = Moeda;
            Valor = valor;
        }
        public decimal PrecoTotal => GetValorTotal();
        public decimal Valor { get; private set; }
        public decimal Cotacao { get; private set; }
        public Moeda Moeda { get; private set; }

        private decimal GetValorTotal()
        {
            switch (Moeda)
            {
                case Moeda.Real:
                    return Valor;

                case Moeda.Dolar:
                    return Valor * Cotacao;

                case Moeda.Euro:
                    return Valor * Cotacao;
                default:
                    throw new System.Exception("Moeda Inválida");
            }
        }
    }

    public enum Moeda
    {
        Real,
        Dolar,
        Euro
    }
}
