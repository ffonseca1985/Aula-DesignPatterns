using ExemploGeral.DomainModel;
using System.Collections.Generic;

namespace ExemploGeral.Repositories
{
    public class PessoaRespository
    {
        public IEnumerable<Pessoa> GetAll()
        {
            var pessoas = new List<Pessoa>()
            {
                new Pessoa() {
                    DataNascimento = System.DateTime.Now,
                    EstadoCivil = EstadoCivil.Amigado,
                    Nome = "Maria",
                    Sexo = Sexo.Feminino
                },
                new Pessoa() {
                    DataNascimento = System.DateTime.Now,
                    EstadoCivil = EstadoCivil.Solteiro,
                    Nome = "Jão",
                    Sexo = Sexo.Masculino
                },
                new Pessoa(){
                    DataNascimento = System.DateTime.Now,
                    EstadoCivil = EstadoCivil.Viuvo,
                    Nome = "Renata",
                    Sexo = Sexo.Feminino
                }
            };
            return pessoas;
        }
    }
}
