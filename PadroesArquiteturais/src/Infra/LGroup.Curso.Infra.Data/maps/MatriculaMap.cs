using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LGroup.Curso.Infra.Data.maps
{
    public class MatriculaMap
        : EntityTypeConfiguration<Matricula> {

        public MatriculaMap()
        {
            HasRequired(x => x.Aluno)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdAluno);

            HasRequired(x => x.Curso)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdCurso);
        } 
    }
}
