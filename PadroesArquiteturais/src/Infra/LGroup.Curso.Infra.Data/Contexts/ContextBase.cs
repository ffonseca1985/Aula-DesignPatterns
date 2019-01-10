using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity;

namespace LGroup.Curso.Infra.Data.Contexts
{
    using PadroesArquiteturais.DomainModel.Entities;

    public abstract class ContextBase<T> : DbContext
    {
        public ContextBase(string con)
                : base(con)
        {}

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
