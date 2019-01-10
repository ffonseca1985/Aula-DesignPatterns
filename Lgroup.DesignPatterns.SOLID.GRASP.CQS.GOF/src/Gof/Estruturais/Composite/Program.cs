using Composite.DomainModel;
using Composite.DomainModel.Services;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatacaoGeralService formatacaoGeral = new FormatacaoGeralService();
            formatacaoGeral.Adicionar(new Criptografia());
            formatacaoGeral.Adicionar(new Empacotamento());
            formatacaoGeral.Adicionar(new Minificacao());

            formatacaoGeral.Formatar();
        }
    }
}
