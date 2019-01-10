using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity;

namespace LGroup.Curso.Infra.Data.Contexts
{
    using PadroesArquiteturais.DomainModel.Entities;

    public class ContextInterno : DbContext
    {
        public ContextInterno() 
            : base("strcon2") {}

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
    }
}
