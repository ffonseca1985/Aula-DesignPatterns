using Builder.Builders;
using Builder.Model;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro()
            {
                Motor = "V4",
                Ano = 2015,
                Cor = "Amarelo",
                Preco = 35000M,
                Licenciamento = new Licenciamento(),
                Adicionais = new Adicionais()
            };

            var fiat = new FiatBuilder();
            var diretor = new DirectorBuider(fiat);

            diretor.Builder(carro);

            decimal total = diretor.GetCarro().GetTotal();

        }
    }
}
