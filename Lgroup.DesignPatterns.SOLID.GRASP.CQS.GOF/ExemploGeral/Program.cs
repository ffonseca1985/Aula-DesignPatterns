using ExemploGeral.DomainModel.Especificacoes;
using ExemploGeral.Repositories;
using System.Linq;

namespace ExemploGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new PessoaRespository();

            var pessoas = repository.GetAll();
            var mulheresSolteiras = pessoas.Where(MulherDisponivel.IsValid().Compile());
        }   
    }
}
