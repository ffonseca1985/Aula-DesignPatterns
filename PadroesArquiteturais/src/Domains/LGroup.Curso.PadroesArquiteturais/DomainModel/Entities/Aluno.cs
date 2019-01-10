using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Curso.PadroesArquiteturais.DomainModel.Entities
{
    public class Aluno
    {
        public Aluno(string nome)
        {
            Nome = nome;
            Matriculas = new List<Matricula>();
        }
        private Aluno() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}
